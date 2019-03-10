namespace Sortable_Collection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Sortable_Collection.Contracts;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private Func<T, T, int> Subtract;
        private Func<T, T, int> Multiply;

        public SortableCollection()
        {
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.Items = new List<T>(items);
        }

        public SortableCollection(IEnumerable<T> items, Func<T, T, int> subtract, Func<T, T, int> multiply): this(items)
        {
            this.Multiply = multiply;
            this.Subtract = subtract;
        }

        public SortableCollection(params T[] items)
            : this(items.AsEnumerable())
        {
        }

        public List<T> Items { get; } = new List<T>();

        public int Count => this.Items.Count;

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.Items);
        }

        public int BinarySearch(T item)
        {
            return this.BinarySearchProcedure(item, 0, this.Count - 1);
        }

        private int BinarySearchProcedure(T item, int startIndex, int endIndex)
        {
            if (endIndex < startIndex)
            {
                return -1;
            }

            int midpoint = startIndex + (endIndex - startIndex) / 2;

            if (this.Items[midpoint].CompareTo(item) > 0)
            {
                return this.BinarySearchProcedure(item, startIndex, midpoint - 1);
            }

            if (this.Items[midpoint].CompareTo(item) < 0)
            {
                return this.BinarySearchProcedure(item, midpoint + 1, endIndex);
            }

            return midpoint;
        }

        public int InterpolationSearch(T item)
        {
            return this.InterpolationSearch(this.Items.ToArray(), item);
        }

        private int InterpolationSearch(T[] array, T item)
        {
            if (array.Length < 1)
            {
                return -1;
            }

            int low = 0;
            int high = array.Length - 1;
            int mid;
            while (array[high].CompareTo(array[low]) != 0 &&
                item.CompareTo(array[low]) >= 0 &&
                item.CompareTo(array[high]) <= 0)
            {
                mid = low + this.Subtract(item, array[low]) * (high - low) / this.Subtract(array[high], array[low]);

                if (array[mid].CompareTo(item) < 0)
                {
                    low = mid + 1;
                }
                else if (array[mid].CompareTo(item) > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            if (item.CompareTo(array[low]) == 0)
            {
                return low;
            }
            else
            {
                return -1;
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            var n = this.Items.Count;
            for (var i = 0; i < n; i++)
            {
                // Exchange array[i] with random element in array[i … n-1]
                int r = i + rnd.Next(0, n - i);
                var temp = this.Items[i];
                this.Items[i] = this.Items[r];
                this.Items[r] = temp;
            }
        }

        public T[] ToArray()
        {
            return this.Items.ToArray();
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this.Items)}]";
        }        
    }
}