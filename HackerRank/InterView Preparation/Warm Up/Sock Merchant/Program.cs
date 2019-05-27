using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Trim();
            int n = Convert.ToInt32(line1);

            var line2 = Console.ReadLine().Trim().Split();
            var ints = line2.ToList().Select(int.Parse).ToArray();
           

            int sum = sockMerchant(n, ints /*new int[] { 1, 1 ,3, 1 ,2 ,1 ,3 ,3, 3, 3 }*/);
        }

        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> socks = new Dictionary<int, int>();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (socks.TryGetValue(ar[i], out count))
                {
                    socks [ar[i]] += 1;
                }
                else
                    socks.Add(ar[i], 1);
            }

            foreach (KeyValuePair<int, int> pair in socks)
            {
                sum += pair.Value / 2;
            }
           
            return sum;
        }
    }
}

