namespace Sorting
{
    public class MergeSort
    {
        public string[] Sort(string[] a)
        {
            string[] aux = new string[a.Length];
            Sort(a, aux, 0, a.Length - 1);
            return a;
        }
        private void Sort(string[] a, string[] aux, int lo, int hi)
        {
            // If lo = hi, means that our array contains just 1 element, so return
            if(hi <= lo) { return; }
            // Calculate middle of array
            int mid = lo + (hi - lo) / 2;
            // Sort first part of array
            Sort(a, aux, lo, mid);
            // Sort second part of array
            Sort(a, aux, mid + 1, hi);
            // If fist element of second array is bigger than last element of first array, return because both parts are sorted, so no need to merge
            if (Less(a, mid, mid+1)) { return; }
            Merge(a, aux, lo, mid, hi);
        }
        private void Merge(string[] a, string[] aux, int lo, int mid, int hi)
        {
            // Copy original array into aux
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            // Set i to lo and j to mid+1
            int i = lo;
            int j = mid + 1;

            // Iterate throught array, from lo to hi
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) { a[k] = aux[j++]; } // If i(lo) is bigger than mid, the 1st part of the array is merged, so the rest must be on the 2nd half of the array.
                else if (j > hi) { a[k] = aux[i++]; } // If j(mid+1) is bigger than hi, the 2nd part of the array is merged, so the rest must be on the 1st half of the array.
                else if (Less(aux, j, i)) { a[k] = aux[j++]; } // If aux[j] is smaller than aux[i], merge aux[j] into main array.
                else { a[k] = aux[i++]; } // Else, merge aux[i] into main array
            }
        }
        public bool Less(string[] a, int i, int j)
        {
            return a[i].CompareTo(a[j]) < 0;
        }
    }
}
