using System;

namespace _31_10
{
    class Program
    {
        static void Main()
        {
            Series1();
        } 
        static public void Series1()
        {
            double[] a = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            double s = 0;
                for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
                Console.WriteLine(s);
            }
        }
        static public void Series4()
        {
            int n = 7;
            double s = 0;
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                s += a[i];
            }
            Console.WriteLine(s);
        }
        public static void Series14()
        {
            double N = 7;
            double K = 0;
            int[] A = new int[5] { 1, 2, 3, 4, 6 };
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0)
                {
                    A[i] *= 2;
                    K += A[i];
                }
            }
            Console.WriteLine(K);
        }
        public int Series16(int k, int[] arr)
        {
            int arrayLength = arr.Length;
            Array.Sort(arr, 0, arrayLength - 2);
            return (arr[arrayLength - 2] > k ? arrayLength - 1 : 0);
        }
        public static int[] Series19(int N, int K)
        {
            N = 7; K = 0;
            int[] a = new int[] { 1, 5, 13, 6, 3, 68, 35, 72, 91 };
            int[] rez = new int[N];
            for (int i = 1; i <= N; i++)
            {
                if (a[i] < a[i - 1])
                {
                    rez[K] = a[i];
                    K++;
                }
            }
            return rez;
        }
        static void Series20(int n, int[] arr)
        {
            int amountOfNums = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(arr[i] < arr[i + 1] ? arr[i] : (int?)null);
                amountOfNums++;
            }
            Console.WriteLine(amountOfNums);
        }
        public static void Series23()
        {
            int N = 7, cntr = 0;
            int[] a = new int[] { 21, 35, 72, 103, 133, 170 };
            for (int i = 0; i < N;)
            {
                if (a[i] < a[i + 1])
                    Console.WriteLine(a[i]);
                cntr++;
                i++;
                break;

            }
            if (cntr == 0)
                Console.WriteLine(cntr);
        }
        public static void Series26()
        {
            double k=3; double n=7; 
            double[] arr;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], k));
            }
        }
        static void Series28(int n, double[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], n - i));
            }
        }
        static void Series32(int n, int k, int[][] arr)
        {
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(Array.IndexOf(arr, 2) + 1);
            }
        }   

    }
}
