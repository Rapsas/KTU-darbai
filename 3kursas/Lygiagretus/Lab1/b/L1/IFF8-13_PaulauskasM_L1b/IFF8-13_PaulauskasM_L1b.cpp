#include <nlohmann/json.hpp>
#include <fstream>
#include <omp.h>
#include <thread>
#include <mutex>
#include <condition_variable>
#include <vector>
#include <iostream>
#include <algorithm>
#include <iomanip>

const unsigned int numFilter = 60;
const unsigned int tCount = 3;
const unsigned int innerSize = 20;

struct dataType
{
	std::string String;
	int Num;
	double Decimal;
};

bool compareByNum(const dataType& a, const dataType& b)
{
	return a.Num < b.Num;
}

struct Err
{};

class Lock
{
public:
	Lock(omp_lock_t* lock)
		: m_lock(lock)
	{
		omp_set_lock(m_lock);
	}

	~Lock()
	{
		omp_unset_lock(m_lock);
	}
private:
	omp_lock_t* m_lock;
};

class Monitor
{
public:
	Monitor()
	{
		omp_init_lock(&m_writelock);
	}

	~Monitor()
	{
		omp_destroy_lock(&m_writelock);
	}

	Err* add(const dataType& data)
	{
		Lock lock(&m_writelock);

		if (m_slot + 1 >= innerSize)
		{
			return new Err();
		}

		m_slot++;
		m_data[m_slot] = data;

		return nullptr;
	}

	Err* get(dataType*& d)
	{
		Lock lock(&m_writelock);

		if (m_slot == -1)
		{
			if (Active == false)
			{
				delete d;
				d = nullptr;
			}

			return new Err();
		}

		*d = m_data[m_slot];
		m_slot--;
		return nullptr;
	}

	size_t size()
	{
		return m_slot;
	}

	bool Active = false;
private:
	omp_lock_t m_writelock;
	dataType m_data[innerSize];
	size_t m_slot = -1;
};

class AsyncStore
{
public:
	AsyncStore()
	{
		omp_init_lock(&m_writelock);
	}

	~AsyncStore()
	{
		omp_destroy_lock(&m_writelock);
	}

	void add(const dataType& data)
	{
		Lock lock(&m_writelock);

		// Sort
		int index = 0;

		for (int i = 0; i < m_data.size(); i++)
		{
			if (data.Num > m_data[i].Num)
			{
				index = i + 1;
			}
		}

		m_data.insert(m_data.begin() + index, data);

		//std::sort(m_data.begin(), m_data.end(), compareByNum);
	}

	void toFile(const std::string& filepath)
	{
		std::cout << m_data.size() << std::endl;

		std::ofstream ofs(filepath);

		ofs << std::setw(21) << "String|" << std::setw(11) << "Number|" << std::setw(11) << "Decimal\n";

		// Inferior language
		for (int i = 0; i < 42; i++)
		{
			ofs << "-";
		}

		ofs << "\n";

		for (dataType& d : m_data)
		{
			ofs << std::setw(20) << d.String << "|" << std::setw(10) << d.Num << "|" << std::setw(10) << d.Decimal << "\n";
		}
	}
private:
	omp_lock_t m_writelock;
	std::vector<dataType> m_data;
};


std::vector<dataType> readFile(const std::string& filepath)
{
	std::ifstream ifs(filepath);
	nlohmann::json jf = nlohmann::json::parse(ifs);

	std::vector<dataType> data;
	data.reserve(jf.size());

	for (auto& j : jf)
	{
		dataType dataEntry{ j["string"], j["int"], j["double"] };
		data.push_back(dataEntry);
	}

	return data;
}

int main()
{
	// Read data
	//std::vector<dataType> data = readFile("IFF8-13_PaulauskasM_L1d_dat_1.json");
	std::vector<dataType> data = readFile("IFF8-13_PaulauskasM_L1_dat_1.json");
	// Max thread count + 1 since one is the master thread
	omp_set_num_threads(tCount + 1);

	Monitor m;
	AsyncStore sorted;

	#pragma omp parallel default(none) shared(std::cout, data, sorted, m)
	{
		#pragma omp master
		{
			m.Active = true;

			for (dataType& de : data)
			{
			tingiu:
				Err* error = m.add(de);
				if (error != nullptr)
				{
					delete error;
					goto tingiu;
				}
			}

			m.Active = false;

			// Master thread will just skip the working loop after this
		}

		dataType* d = new dataType();
		while (true) {
			Err* err = m.get(d);

			if (err != nullptr) {
				if (d == nullptr) {
					// Shutdown
					break;
				}

				// Try read again
				delete err;
				continue;
			}

			if (d->Num > numFilter)
			{
				// Add to sorted
				sorted.add(*d);
			}

			// Expensive operation
			//std::this_thread::sleep_for(std::chrono::seconds(1));
		}

		// Only for master thread
		if (d != nullptr)
		{
			delete d;
		}
	}

	sorted.toFile("IFF8-13_PaulauskasM_L1_rez.txt");

	return 0;
}