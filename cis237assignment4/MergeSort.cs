using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort<IComparable>
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
                        if (less(aux[j], aux[i]))
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
