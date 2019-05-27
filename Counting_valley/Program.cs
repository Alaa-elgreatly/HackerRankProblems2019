using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_valley
{
    class Program
    {
        static int altitude = 0;
        static int After_Next_Step = 0;
        static int Valley_count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "DDUUUUDD").ToString());
        }
        static int countingValleys(int n, string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D')
                    After_Next_Step = altitude - 1;
                else
                    After_Next_Step = altitude + 1;

                if (altitude == 0 && After_Next_Step < 0)
                    Valley_count++;
                altitude = After_Next_Step;

            }
            return Valley_count;

        }
    }
}
