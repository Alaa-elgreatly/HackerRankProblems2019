using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            TripletComparer triplet = new TripletComparer(a);
            List<int> result = triplet.CompareTriplet(b);
            return result;
        }

        static void Main(string[] args)
        {
            List<int> temp = compareTriplets(new List<int>() {5 , 6 , 7 } , new List<int>() {3,6,10 } );
        }
    }
}
