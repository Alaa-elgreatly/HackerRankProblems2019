using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {

        static int diagonalDifference(int[][] arr)
        {
            int sum_first = 0;
            int sum_second = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum_first += arr[i][i];
                sum_second += arr[i][arr[i].Length - 1 - i];
            }
            return Math.Abs( sum_first - sum_second) ;

        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][] { new int [] { 11, 2, 4 }, new int[] { 4,5,6 }, new int[] { 10,8,-12 } };
            int res = diagonalDifference(arr);
        }
    }
}
