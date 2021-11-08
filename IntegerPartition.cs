using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_system
{
    // This class finds integer partition of the given integer number.

    public static class IntegerPartition
    {
        public static List<List<int>> results = new List<List<int>>();

        public static List<List<int>> Partition(int n, int max,int length)
        {
            Partition(n, max);
            List<List<int>> newResult = new List<List<int>>();
            foreach(List<int> list in results)
            {
                if(list.Count==length)
                {
                    newResult.Add(list);
                }
            }
            return newResult;
        }

        public static List<List<int>> Partition(int n, int max)
        {
            Partition(n,max, new List<int>());
            return results;
        }


        //Thanks to the max variable we find unique partition i.e. 1+2 is the same as 2+1.
        public static void Partition(int n, int max,  List<int> tempList)
        {
            if (n == 0)
            {
                results.Add(new List<int>(tempList));
            }

            for (int i = Math.Min(n, max); i >= 1; i--)
            {
                    List<int> tempListcopy = new List<int>(tempList);
                    tempListcopy.Add(i);
                    Partition(n - i, i, tempListcopy);
            }

        }

    }
}

