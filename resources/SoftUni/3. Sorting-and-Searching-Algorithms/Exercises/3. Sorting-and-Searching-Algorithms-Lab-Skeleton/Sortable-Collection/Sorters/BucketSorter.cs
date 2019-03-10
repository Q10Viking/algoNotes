namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Sortable_Collection.Contracts;

    public class BucketSorter : ISorter<int>
    {
        public void Sort(List<int> collection)
        {
            var buckets = new SortableCollection<int>[collection.Count];

            foreach (var element in collection)
            {
                int bucketIndex = (int)(element / this.Max * collection.Count); 

                if (buckets[bucketIndex] == null)
                {
                    buckets[bucketIndex] = new SortableCollection<int>();
                }

                buckets[bucketIndex].Items.Add(element);
            }

            var sorter = new Quicksorter<int>();
            for (int i = 0; i < buckets.Length; i++)
            {
                if (buckets[i] != null)
                {
                    buckets[i].Sort(sorter);
                }
            }

            int index = 0;
            foreach (var bucket in buckets)
            {
                if (bucket == null)
                {
                    continue;
                }

                foreach (var item in bucket.Items)
                {
                    collection[index] = item;
                    index++;
                }
            }
             
        }

        public double Max { get; set; }
    }
}
