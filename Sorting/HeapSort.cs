namespace Sorting
{
    public class HeapSort
    {
        public void Sort(string[] a)
        {
            int N = a.Length;
            for (int k = N/2; k >= 1; k--)
            {
                Sink(a, k, N);
            }
            while(N > 1)
            {
                Exchange(a, 1, N--);
                Sink(a, 1, N);
            }
        }

        private void Swim(string[] a, int k)
        {
            while (k > 1 && Less(a, k/2, k))
            {
                Exchange(a, k, k/2);
                k = k/2;
            }
        }

        private void Sink(string[] a, int k, int N)
        {
            while (2*k <= N)
            {
                int j = 2 * k;
                if (j < N && Less(a, j, j + 1)) j++;
                if (!Less(a, k, j)) break;
                Exchange(a, k, j);
                k = j;
            }
        }

        private void Insert(string[] a, int N, string x)
        {            
            a[++N] = x;
            Swim(a, N);
        }

        private string RemoveMax(string[] a, int N)
        {
            string max = a[1];
            Exchange(a, 1, N--);
            Sink(a, 1, N);
            a[N + 1] = null;
            return max;
        }

        public string[] Resize(string[] s, int size, int N)
        {
            string[] NewS = new string[size];
            for (int i = 0; i < N; i++)
            {
                NewS[i] = s[i];
            }
            return NewS;
        }

        private void Exchange(string[] a, int i, int j)
        {
            // Swaps one string for another
            string swap = a[i-1];
            a[i-1] = a[j-1];
            a[j-1] = swap;
        }

        public bool Less(string[] a, int i, int j)
        {
            return a[i-1].CompareTo(a[j-1]) < 0;
        }

    }
}

