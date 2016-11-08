//Jordan Koehler
//November 8th, 2016
//CIS 237 TR 3:30 - 5:00

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        private MergeSort()
        {

        }

        //This takes the seperated and sorted parts of the original array and puts them back together in the correct order.

        public static void Merge(IComparable[] og, IComparable[] aux, int low, int mid, int high)
        {
            for (int k = low; k <= high; k++)
            {
                if (og[k] != null)
                {
                    aux[k] = og[k];
                }
            }

            int i = low, j = mid + 1;
            for (int k = low; k <= high; k++)
            {
              
                    if (i > mid)
                    {
                        og[k] = aux[j++];
                    }
                    else
                    {
                        if (j > high)
                        {
                            og[k] = aux[i++];
                        }
                        else
                        {
                            if (Less(aux[j], aux[i]))
                            {
                                og[k] = aux[j++];
                            }
                            else
                            {
                                og[k] = aux[i++];
                            }
                        }
                   
                }
                
            }
        }

       //This sort is the first part of the  MergeSort that can be called by other classes. Starts the whole merge sort process.

        public static void Sort(IComparable[] og, int arraysize)
        {
            IComparable[] aux = new IComparable[arraysize];
            Sort(og, aux, 0, arraysize - 1);
            
        }

        //This sort is does most of the heavy lifting of the merge sort by calling itself recursively two times followed by merge to put the sorted data in order.

        private static void Sort(IComparable[] og, IComparable[] aux, int low, int high)
        {
            if (high <= low) return;
            int mid = low + (high - low) / 2;
            Sort(og, aux, low, mid);
            Sort(og, aux, mid + 1, high);
            Merge(og, aux, low, mid, high);
            
            
        }

        //This checks to see if one comparable object is smaller than the other.

        private static bool Less(IComparable v, IComparable w)
        {           
            return v.CompareTo(w) < 0;
        }

        
    }
}
