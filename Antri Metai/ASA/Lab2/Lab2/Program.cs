using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Data
    {
        private static Random random = new Random();

        public static int[] GenRandomArray(int count)
        {
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = random.Next(0, 20);
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int[] X1 = new int[] { 1, 5, 5, 2, 1, 8 };
            int[] Y1 = new int[] { 5, 3, 2, 3, 1, 6, 8 };

            //int[] X1 = Data.GenRandomArray(15);
            //int[] Y1 = Data.GenRandomArray(15);

            Stopwatch stopwatch = new Stopwatch();

            int m = X1.Length;
            int n = Y1.Length;

            //Bench();
            //BenchCR();
            //BenchCR();
            BenchPar();
            BenchPar();

            Console.WriteLine("Uzduotis nr. 1\n");

            stopwatch.Start();
            int[,] W = MWCS_BottomUp(X1, Y1);
            Console.WriteLine("Dynamic: " + W[m, n]);
            stopwatch.Stop();
            TimeSpan dTime = stopwatch.Elapsed;

            stopwatch.Restart();
            Console.WriteLine("Recursive: " + MWCS_Recurssive(X1, Y1, m, n ) + "\n");
            stopwatch.Stop();
            TimeSpan rTime = stopwatch.Elapsed;

            Console.WriteLine("Recursive vs. Dynamic Time");
            Console.WriteLine("Recursive: " + rTime);
            Console.WriteLine("Dynamic: " + dTime);

            Console.WriteLine("\nUzduotis nr. 2\n");
            int[] priceArray = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            (int, string) rez = CutRod(priceArray, priceArray.Length);
            Console.WriteLine("Didziausias pelnas: " + rez.Item1);

            Console.WriteLine("\nUzduotis nr. 3\n");

            X1 = Data.GenRandomArray(10000);
            Y1 = Data.GenRandomArray(10000);
            m = X1.Length;
            n = Y1.Length;

            stopwatch.Restart();
            W = MWCS_BottomUp(X1, Y1);
            Console.WriteLine("Dynamic: " + W[m, n]);
            stopwatch.Stop();
            dTime = stopwatch.Elapsed;

            stopwatch.Restart();
            Console.WriteLine("Parallel: " + MWCS_Parallel(X1, Y1, W) + "\n");
            stopwatch.Stop();
            TimeSpan pTime = stopwatch.Elapsed;

            Console.WriteLine("Dynamic vs. Parallel dynamic Time");
            Console.WriteLine("Dynamic: " + dTime);
            Console.WriteLine("Parallel: " + pTime + "\n");
        }

        public static int[,] MWCS_BottomUp(int[] X, int[] Y)
        {
            int m = X.Length;
            int n = Y.Length;
            int[,] W = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        if (X[i - 1] < 0)
                        {
                            W[i, j] = W[i - 1, j - 1];
                        }
                        else
                        {
                            W[i, j] = X[i - 1] + W[i - 1, j - 1];
                        }
                    }
                    else
                    {
                        W[i, j] = Math.Max(W[i, j - 1], W[i - 1, j]);
                    }
                }
            }

            return W;
        }

        static int MWCS_Recurssive(int[] X, int[] Y, int m, int n)
        {
            if (m == 0 || n == 0)
                return 0;
            if (X[m - 1] == Y[n - 1])
                return X[m - 1] + MWCS_Recurssive(X, Y, m - 1, n - 1);
            else
                return Math.Max(MWCS_Recurssive(X, Y, m, n - 1), MWCS_Recurssive(X, Y, m - 1, n));
        }

        static int MWCS_Parallel(int[] X, int[] Y, int[,] W)
        {
            int m = X.Length;
            int n = Y.Length;
            
            Parallel.For(1, m,
                i =>
                {
                for (int j = 1; j < n; j++)
                {
                    if (X[i] == Y[j])
                    {
                        if (X[i] < 0)
                        {
                            W[i, j] = W[i - 1, j - 1];
                        }
                        else
                        {
                            W[i, j] = X[i] + W[i - 1, j - 1];
                        }
                    }
                    else
                    {
                        W[i, j] = Math.Max(W[i, j - 1], W[i - 1, j]);
                    }
                }
            });

            return W[m - 1, n - 1];
        }

        static (int, string) CutRod(int[] price, int n)
        {
            int[] val = new int[n + 1];
            val[0] = 0;
            string combination = "";

            for (int i = 1; i <= n; i++)
            {
                int max_val = int.MinValue;
                for (int j = 0; j < i; j++)
                    max_val = Math.Max(max_val, price[j] + val[i - j - 1]);
                val[i] = max_val;
            }

            return (val[n], combination);
        }

        static void Bench()
        {
            for (int i = 0; i < 5; i++)
            {
                int[] X1 = Data.GenRandomArray(10 + i * 3);
                int[] Y1 = Data.GenRandomArray(10 + i * 3);

                Stopwatch stopwatch = new Stopwatch();

                int m = X1.Length;
                int n = Y1.Length;

                stopwatch.Start();
                int[,] W = MWCS_BottomUp(X1, Y1);
                Console.WriteLine((i + 1) + "Dynamic: " + W[m, n]);
                stopwatch.Stop();
                TimeSpan dTime = stopwatch.Elapsed;

                stopwatch.Restart();
                Console.WriteLine((i + 1) + "Recursive: " + MWCS_Recurssive(X1, Y1, m, n) + "\n");
                stopwatch.Stop();
                TimeSpan rTime = stopwatch.Elapsed;

                Console.WriteLine((i + 1) + " - Recursive vs. Dynamic Time");
                Console.WriteLine("Recursive: " + rTime);
                Console.WriteLine("Dynamic: " + dTime + "\n");
            }
        }

        static void BenchCR()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] arr = Data.GenRandomArray(100 * i);
                stopwatch.Start();
                CutRod(arr, arr.Length);
                stopwatch.Stop();
                TimeSpan time = stopwatch.Elapsed;
                Console.WriteLine("N - " + (100*i) + " Time: " + time);
                stopwatch.Reset();
            }
        }

        static void BenchPar()
        {
            for (int i = 1; i <= 5; i++)
            {
                int[] X1 = Data.GenRandomArray(2000 * i);
                int[] Y1 = Data.GenRandomArray(2000 * i);
                int m = X1.Length;
                int n = Y1.Length;

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                int [,] W = MWCS_BottomUp(X1, Y1);
                Console.WriteLine("Dynamic: " + W[m, n]);
                stopwatch.Stop();
                TimeSpan dTime = stopwatch.Elapsed;

                stopwatch.Restart();
                Console.WriteLine("Parallel: " + MWCS_Parallel(X1, Y1, W) + "\n");
                stopwatch.Stop();
                TimeSpan pTime = stopwatch.Elapsed;
                stopwatch.Reset();

                Console.WriteLine("N = " + 20000 * i);
                Console.WriteLine("Dynamic: " + dTime);
                Console.WriteLine("Parallel: " + pTime + "\n");
            }
            
        }
    }
}
