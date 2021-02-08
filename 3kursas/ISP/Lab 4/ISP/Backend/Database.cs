using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ISP.Backend
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class DatabaseField : Attribute
    {
        public string DBName { get; set; }
        public DatabaseField(string dbname) { DBName = dbname; }
    }

    public class Database
    {
        // Databse port
        private const int Port = 3306;

        private MySqlConnection SqlConnection { get; set; } = new MySqlConnection($"server=localhost;port={Port};userid=root;database=isp");

        public Database()
        {
            SqlConnection.Open();
        }

        private void addParameters<T>(MySqlCommand cmd, T obj) where T : new()
        {
            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                object value = pi.GetValue(obj);

                if (value is string)
                {
                    cmd.Parameters.AddWithValue("@" + pi.Name, (value as string).Trim('"'));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@" + pi.Name, value);
                }
            }
        }

        public void Insert<T>(string query, T obj) where T : new()
        {
            MySqlCommand cmd = new MySqlCommand(query, SqlConnection);

            // Add a little spice
            if (obj != null)
            {
                addParameters<T>(cmd, obj);
            }

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        //Insert that return the ID of the inserted row
        public int InsertLastID<T>(string query, T obj) where T : new()
        {
            MySqlCommand cmd = new MySqlCommand(query, SqlConnection);

            // Add a little spice
            if (obj != null)
            {
                addParameters<T>(cmd, obj);
            }

            cmd.Prepare();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void setFKCheck(bool value)
        {
            MySqlCommand cmd = new MySqlCommand($"SET FOREIGN_KEY_CHECKS={(value ? "1" : "0")};", SqlConnection);
            cmd.ExecuteNonQuery();
        }

        public void Delete<T>(string query, T obj) where T : new()
        {
            MySqlCommand cmd = new MySqlCommand(query, SqlConnection);

            // Add a little spice
            if (obj != null)
            {
                addParameters<T>(cmd, obj);
            }

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void Edit<T>(string query, T obj) where T : new()
        {
            MySqlCommand cmd = new MySqlCommand(query, SqlConnection);

            // Add a little spice
            if (obj != null)
            {
                addParameters<T>(cmd, obj);
            }

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public List<T> Get<T>(string query, Dictionary<string, object> parameters = null) where T : new()
        {
            // Add a little spice
            Dictionary<string, PropertyInfo> mapableProperties = new Dictionary<string, PropertyInfo>();

            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                var attr = pi.GetCustomAttributes(typeof(DatabaseField), false).FirstOrDefault() as DatabaseField;

                if (attr != null)
                {
                    // Has mapping attribute
                    mapableProperties.Add(attr.DBName, pi);
                }
            }

            if (mapableProperties.Count == 0)
            {
                throw new Exception("No DatabaseField inside specified T type");
            }

            MySqlCommand cmd = new MySqlCommand(query, SqlConnection);

            if (parameters != null)
            {
                foreach (var entry in parameters)
                {
                    cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                }
            }

            using MySqlDataReader rdr = cmd.ExecuteReader();
            List<T> result = new List<T>();

            while (rdr.Read())
            {
                T entry = new T();

                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    string dbName = rdr.GetName(i);

                    if (mapableProperties.ContainsKey(dbName))
                    {
                        object val = rdr.GetValue(i);

                        if (val is DateTime)
                        {
                            mapableProperties[dbName].SetValue(entry, val.ToString());
                        }
                        else if (mapableProperties[dbName].PropertyType == typeof(bool))
                        {
                            mapableProperties[dbName].SetValue(entry, Convert.ToBoolean(val));
                        }
                        else
                        {
                            mapableProperties[dbName].SetValue(entry, val);
                        }
                    }
                }

                result.Add(entry);
            }

            return result;
        }
    }
}
