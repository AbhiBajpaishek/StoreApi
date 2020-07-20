using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                String[] line = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(line[0]);
                int m = Convert.ToInt32(line[1]);
                line = Console.ReadLine().Split(' ');
                long[] arr = new long[n];
                for (int j = 0; j < n; j++)
                    arr[j] = Convert.ToInt64(line[j]);
                Array.Sort(arr);
                int begPoint = beginPoint(arr, n, m);
                if (begPoint == -1)
                    Console.WriteLine(begPoint);
                else
                {
                    Console.WriteLine(n - begPoint + 1);
                }
            }
        }

        public static int beginPoint(long[] arr, int n, int m)
        {
            int beg = 0, end = n;
            int mid = (beg + end) / 2;
            bool flag = true;
            while (beg != end && flag)
            {
                if (arr[mid] == m)
                    flag = false;
                else if (m > arr[mid])
                    beg = mid + 1;
                else
                    end = mid - 1;
                mid = (beg + end) / 2;
            }
            if (flag)
                return mid;
            return -1;
        }
    }
}
