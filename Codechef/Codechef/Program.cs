using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    class Program
    {
        public static void Main()
        {
            short t = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                uint n = Convert.ToUInt32(Console.ReadLine());
                long[] c = new long[n];
                long[] h = new long[n];
                long[] level = new long[n];

                String[] ax = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                    c[j] = Convert.ToInt64(ax[j]);

                ax = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                    h[j] = Convert.ToInt64(ax[j]);

                for (int j = 1; j <= n; j++)
                {
                    long a = j - c[j - 1];
                    long z = j + c[j - 1];
                    level = ChangeValue(level, n, a - 1, z - 1);
                }

                Dictionary<long, long> map = new Dictionary<long, long>();
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        map[level[j]]++;
                    }
                    catch
                    {
                        map[level[j]] = 0;
                        map[level[j]]++;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        map[h[j]]--;
                    }
                    catch
                    {
                        map[h[j]] = 0;
                        map[h[j]]--;
                    }
                }

                if (Check(map))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            Console.ReadKey();
        }


        public static bool Check(Dictionary<long, long> map)
        {
            foreach (KeyValuePair<long, long> j in map)
                if (map[j.Key] != 0)
                    return false;
            return true;
        }

        public static long[] ChangeValue(long[] arr, uint n, long a, long z)
        {
            if (a < 0)
                a = 0;
            if (z >= n)
                z = n - 1;
            for (long i = a; i <= z; i++)
            {
                arr[i] += 1;
            }
            return arr;
        }
    }
}
