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

        public static void Merge(IComparable[] og, IComparable[] aux, int low, int mid, int high)
        {
            for (int k = low; k <= high; k++)
            {
                aux[k] = og[k];
            }

            int i = low, j = mid + 1;
            for (int k = low; k <= high; k++)
            {
                if (aux[j] != null)
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
        }

        public static void Sort(IComparable[] og)
        {
            IComparable[] aux = new IComparable[og.GetLength(0)];
            Sort(og, aux, 0, og.GetLength(0)- 1);
            
        }


        private static void Sort(IComparable[] og, IComparable[] aux, int low, int high)
        {
            if (high <= low) return;
            int mid = low + (high - low) / 2;
            Sort(og, aux, low, mid);
            Sort(og, aux, mid + 1, high);
            Merge(og, aux, low, mid, high);
        }



        private static bool Less(IComparable v, IComparable w)
        {           
            return v.CompareTo(w) < 0;
        }

        
    }
}
