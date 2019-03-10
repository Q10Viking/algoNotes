namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            Quicksort(collection, 0, collection.Count - 1);
        }   
        
        private void Quicksort(List<T> array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            T pivot = array[start];
            int storeIndex = start + 1;

            for (int i = start + 1; i <= end; i++)
            {
                if (array[i].CompareTo(pivot) < 0)
                {
                    var temp = array[storeIndex];
                    array[storeIndex] = array[i];
                    array[i] = temp;
                    storeIndex++;
                }
            }

            storeIndex--;
            var newTemp = array[storeIndex];
            array[storeIndex] = array[start];
            array[start] = newTemp;
            Quicksort(array, start, storeIndex);
            Quicksort(array, storeIndex + 1, end);
        }

        private static void Swap(ref T i, ref T j)
        {
            if (i.CompareTo(j) == 0)
            {
                return;
            }

            //i = i ^ j;
            //j ^= i;
            //i ^= j;
        }
    }
}
