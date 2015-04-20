using System;
using System.Threading.Tasks;

namespace AlgothrimDevelopment.Algothrim
{
    public class SortAlgorithm
    {
        public void InsertionSort<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length; i++)
            { // Exchange a[i] with smallest entry in a[i+1...N).
                int min = i;  // index of minimal entr.
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Less(a[j], a[min]))
                    {
                        min = j;
                    }
                    else if (a.Length < j + 1)
                    {

                        a[j + 1] = a[j];
                        a[j] = a[min];
                    }
                }
               // Show(a);
                Exch(a, i, min);
            }
        }

        public void ShellSort<T>(T[] a) where T : IComparable
        { // Sort a[] into increasing order.
            int N = a.Length;
            int h = 1;
            while (h < N / 2)
            {
                h = 2 * h + 1; // 1, 4, 13, 40, 121, 364, 1093, ..
            }
            while (h >= 1)
            { // h-sort the array.
                for (int i = h; i < N; i++)
                { // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
                    for (int j = i; j >= h && Less(a[j], a[j - h]); j -= h)
                        Exch(a, j, j - h);              
                }

                h = h / 3;
            }
        }

        public void SelectionSort<T>(T[] a) where T : IComparable
        { // Sort a[] into increasing order.
            int n = a.Length;  // array length
            for (int i = 0; i < n; i++)
            { // Exchange a[i] with smallest entry in a[i+1...N).
                int min = i;  // index of minimal entr.
                for (int j = i + 1; j < n; j++)
                    if (Less(a[j], a[min])) min = j;
                Exch(a, i, min);
            }
        }

        private static void Exch<T>(T[] a, int i, int j) where T : IComparable
        {
            T t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
        public void Show<T>(T[] a) where T : IComparable
        {            // Print the array, on a single line.
            foreach (T t in a)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
        }

        private static bool Less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public bool IsSorted(IComparable[] a)
        { // Test whether the array entries are in order.
            for (int i = 1; i < a.Length; i++)
                if (Less(a[i], a[i - 1])) return false;
            return true;
        }
        private static void GetValue(SortAlgorithm inSortAlgorithm, GenerateArrays.GenerateArray generateArrayValue)
        {
            int i = 10;
            string[] timeValue = new string[3];
            while (i <= 100000)
            {
                Parallel.Invoke(() => { timeValue[0] = TimingAlgorithm.TimeAlgorithm(inSortAlgorithm.InsertionSort, generateArrayValue, i); },
                    () => { timeValue[1] = TimingAlgorithm.TimeAlgorithm(inSortAlgorithm.SelectionSort, generateArrayValue, i); },
                    () => { timeValue[2] = TimingAlgorithm.TimeAlgorithm(inSortAlgorithm.ShellSort, generateArrayValue, i); }
                    );

                string output = String.Format("{0,-12}{1,8}{2,12}{3,14}\n",
                    i, timeValue[0], timeValue[1], timeValue[2]);

                Console.WriteLine(output);

                i = i * 10;
            }
        }
    }
}
