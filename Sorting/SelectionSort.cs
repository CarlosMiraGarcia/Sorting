namespace Sorting
{
    public class SelectionSort
    { 
        public void Sort(string[] a)
        {
            // N indicates the lenght of the array
            int N = a.Length;
            // Iterates throught the array
            for (int i = 0; i < N; i++)
            {
                // Keeps track of the mininmum value
                int min = i;
                // Interates throught the array AFTER the string we are comparing
                for (int j = i + 1; j < N; j ++)
                {
                    // Compares the rest of the string with the selected one
                    if(Less(a[j], a[min]))
                    {
                        min = j;
                    }
                }
                // Exachanges minimum string with the selected one, 
                // even if the selected one is already the minimum (sorted)
                Exchange(a, i, min);
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
