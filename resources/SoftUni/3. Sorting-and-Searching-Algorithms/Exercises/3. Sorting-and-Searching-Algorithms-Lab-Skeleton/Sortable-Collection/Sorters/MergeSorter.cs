namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            this.MergeSort(collection);
        }

        private List<T> MergeSort(List<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int middleIndex = collection.Count / 2;
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            for (int i = 0; i < middleIndex; i++)
            {
                left.Add(collection[i]);
            }

            for (int i = middleIndex; i < collection.Count; i++)
            {
                right.Add(collection[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(collection, left, right);
        }

        private List<T> Merge(List<T> collection, List<T> left, List<T> right)
        {
            int leftIndex = 0;
            int rightIndex = 0;

            collection.Clear();
            while (left.Count - leftIndex > 0 && right.Count - rightIndex > 0)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                {
                    collection.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    collection.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                collection.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                collection.Add(right[rightIndex]);
                rightIndex++;
            }

            return collection;
        }
    }
}
