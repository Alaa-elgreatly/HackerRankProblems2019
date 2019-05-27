using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping_on_Clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(jumpingOnClouds(new int [] { 0 ,0 ,1 ,0 ,0 ,1 ,0 }).ToString());
        }
        static int Cloud_Count = 0;
        static int position = 0;

        static int jumpingOnClouds(int[] c)
        {
            while (position < c.Length)
            {
                if ((c.Length - position) == 2)
                    return Cloud_Count + 1;

                else if (c[position + 2] == 0)
                {
                    position += 2;
                    Cloud_Count++;
                }
                else
                {
                    position += 1;
                    Cloud_Count++;
                }

                if (position == c.Length-1)
                {
                    return Cloud_Count;
                }
            }
            return Cloud_Count;
        }

    }
}
