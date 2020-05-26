using System;
using System.Collections.Generic;
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
                result[i] = random.Next(0, 500);
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] X = Data.GenRandomArray(100);
            int[] Y = Data.GenRandomArray(100);
            Console.WriteLine(MWCS(X, Y));
        }

        public static int MWCS(int[] X, int[] Y)
        {
            int m = X.Length;
            int n = Y.Length;
            int[,] W = new int[m,n];

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if(X[i] == Y[j])
                    {
                        //Console.WriteLine("EQUAL");
                        if(X[i] < 0)
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
            }


            return W[m - 1, n - 1];
        }
    }
}
