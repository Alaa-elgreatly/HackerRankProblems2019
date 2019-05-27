using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class TripletComparer 
    {
        List<int> mylist= new List<int>();
        List<int> result=new List<int>();

        public TripletComparer(List<int> inputList)
        {
            mylist = inputList;
        }
        public List<int> CompareTriplet(List<int> other)
        {
            if (mylist.Count != other.Count)
                return mylist;
            else
            {
                result.Add(0);
                result.Add(0);
                for (int i = 0; i < mylist.Count; i++)
                {
                    if (mylist[i] > other[i])
                        result[0]++;
                    else if (mylist[i] == other[i])
                        continue;
                    else
                        result[1]++;
                }
                return result;
            }
            
        }
    }
}
