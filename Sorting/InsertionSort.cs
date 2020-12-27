namespace Sorting
{
    public class InsertionSort
    {
        public void Sort(string[] a)
        {
            // N indicates the lenght of the array
            int N = a.Length;
            // Iterates throught the array
            for (int i = 0; i < N; i++)
            {
                // Interates throught the array to the left, from i to the start
                for (int j = i; j > 0; j--)
                {
                    // Compares the selected j string, with the one on the left
                    if (Less(a[j], a[j - 1]))
                    {
                        // Exachanges minimum string with the selected one, 
                        // even if the selected one is already the minimum (sorted)
                        Exchange(a, j, j - 1);
                    }
                    else break;
                }              
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
