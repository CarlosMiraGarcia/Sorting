namespace Sorting
{
    public class ShellSort
    {
        public void Sort(string[] a)
        {
            int N = a.Length;
            int h = 1;

            while (h < N/3)
            {
                h = 3 * h + 1;
            }

            while(h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && Less(a[j], a[j-h]); j-=h)
                    {
                        Exchange(a, j, j - h);
                    }
                }
                h = h / 3;
            }

        }
        private bool Less(string v, string w)
        {
            // Compares two strings, if v is smaller than w
            return v.CompareTo(w) < 0;
        }
        private void Exchange(string[] a, int i, int j)
        {
            // Swaps one string for another
            string swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
    }
}


