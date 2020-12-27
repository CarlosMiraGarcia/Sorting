  using System;

namespace Sorting
{
    public class QuickSort
    {
        public void Sort(string[] a)
        {
            Shuffle(a);
            Sort(a, 0, a.Length - 1);
        }

        public void Sort(string[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int lt = lo;
            int gt = hi;
            string v = a[lo];
            int i = lo;
            while (i <= gt)
            {
                int cmp = a[i].CompareTo(v);
                if (cmp < 0) Exchange(a, lt++, i++);
                else if (cmp > 0) Exchange(a, i, gt--);
                else i++;
            }

            Sort(a, lo, lt-1);
            Sort(a, gt +1, hi);
            // Since j is right in the middle, it will always be sorted. It will be smaller than 
            // the elments on the left side and bigger than the elements on the right side
        }
        private int Partition(string[] a, int lo, int hi)
        {
            int i = lo;
            int j = hi + 1;

            while (true)
            {
                while (Less(a, ++i, lo))
                {
                    if (i == hi) break;
                }
                while (Less(a, lo, --j))
                {
                    if (j == lo) break;
                }

                if (i >= j) break;

                else
                {
                    Exchange(a, i, j);
                }
            }
            
            Exchange(a, lo, j);
            return j;

        }
        private void Exchange(string[] a, int i, int j)
        {
            // Swaps one string for another
            string swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
        public void Shuffle(string[] a)
        {
            Random rnd = new Random();
            int N = a.Length;

            for (int i = 0; i < N; i++)
            {
                int r = rnd.Next(i + 1);
                Exchange(a, i, r);
            }
        }
        public bool Less(string[] a, int i, int j)
        {
            return a[i].CompareTo(a[j]) < 0;
        }
    }    
}

