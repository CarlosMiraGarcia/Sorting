using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting
{
    partial class Program
    {
        static int[] SplitNumbers { get; set; }
        static int NumberCaves { get; set; }
        static string[] s;
        static void Main(string[] args)
        {
            //// To read and generate array with 2.5 million integers
            //var fileString = File.ReadAllText("generated5000-1" + ".cav");
            //FindingNumberOfCaves(fileString);
            //var numberOfSplits = CalculateTotalSplits(NumberCaves);
            //SplitNumbers = SplittingAndParsing(fileString, numberOfSplits);

            // Reads a file with 5611673 strings
            string line = File.ReadAllText("strings2.txt");
            s = line.Split(',').ToArray();


            //// Calls SelectionSort
            //var selectS = CallSelectionSort();
            //Console.WriteLine(selectS.Length);

            ////Calls InsertionSort
            //var insertS = CallInsertionSort();
            //Console.WriteLine(insertS.Length);

            ////Calls ShellSort     
            //var shellS = CallShellSort();
            //Console.WriteLine(shellS.Length);

            //Calls MergeSort
            var mergeS = CallMergeSort();
            Console.WriteLine(mergeS.Length);

            //Calls QuickSort
            var quickSort = CallQuickSort();
            Console.WriteLine(quickSort.Length);

            //Calls HeapSort
            var heapSort = CallHeapSort();
            Console.WriteLine(heapSort.Length);

            //Using Array.Sort
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Array.Sort(s);
            stopwatch.Stop();
            Console.WriteLine("\nUsing system Sort - Time Elapsed: " + stopwatch.Elapsed);
        }


        static string[] CallSelectionSort()
        {
            SelectionSort selectionSort = new SelectionSort();
            string[] SS = new string[s.Length];
            for (int i= 0; i < s.Length; i++)
            {
                SS[i] = s[i];
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            selectionSort.Sort(SS);

            stopwatch.Stop();
            Console.WriteLine("\nSelection Sort - Time Elapsed: " + stopwatch.Elapsed);

            //var temp = " ";
            //foreach (string str in SS)
            //{
            //    if (!str.StartsWith(temp[0]))
            //    {
            //        Console.Write("\n" + str[0] + ": ");
            //    }
            //    Console.Write(str + " ");
            //    temp = str;
            //}

            return SS;
        }
        static string[] CallInsertionSort()
        {
            InsertionSort insertionSort = new InsertionSort();
            string[] IS = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                IS[i] = s[i];
            }

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            insertionSort.Sort(IS);

            stopwatch2.Stop();
            Console.WriteLine("\nInsertion Sort - Time Elapsed: " + stopwatch2.Elapsed);

            //var temp = " ";
            //foreach (string str in IS)
            //{
            //    if (!str.StartsWith(temp[0]))
            //    {
            //        Console.Write("\n" + str[0] + ": ");
            //    }
            //    Console.Write(str + " ");
            //    temp = str;
            //}

            return IS;
        }
        static string[] CallShellSort()
        {
            ShellSort shellSort = new ShellSort();
            string[] SHS = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                SHS[i] = s[i];
            }

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();

            shellSort.Sort(SHS);

            stopwatch3.Stop();
            Console.WriteLine("\nShell Sort - Time Elapsed: " + stopwatch3.Elapsed);
            //var temp = " ";
            //foreach (string str in SHS)
            //{
            //    if (!str.StartsWith(temp[0]))
            //    {
            //        Console.Write("\n" + str[0] + ": ");
            //    }
            //    Console.Write(str + " ");
            //    temp = str;
            //}

            return SHS;
        }
        static string[] CallMergeSort()
        {
            MergeSort mergeSort = new MergeSort();
            string[] MS = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                MS[i] = s[i];
            }

            Stopwatch stopwatch4 = new Stopwatch();
            stopwatch4.Start();

            mergeSort.Sort(MS);

            stopwatch4.Stop();
            Console.WriteLine("\nMerge Sort - Time Elapsed: " + stopwatch4.Elapsed);

            //var temp = " ";
            //foreach (string str in MS)
            //{
            //    if (!str.StartsWith(temp[0]))
            //    {
            //        Console.Write("\n" + str[0] + ": ");
            //    }
            //    Console.Write(str + " ");
            //    temp = str;
            //}

            return MS;
            ;
        }
        static string[] CallQuickSort()
        {
            QuickSort quickSort = new QuickSort();
            string[] QS = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                QS[i] = s[i];
            }

            Stopwatch stopwatch5 = new Stopwatch();
            stopwatch5.Start();

            quickSort.Sort(QS);

            stopwatch5.Stop();
            Console.WriteLine("\nQuick Sort - Time Elapsed: " + stopwatch5.Elapsed);

            //var temp = " ";
            //foreach (string str in QS)
            //{
            //    if (!str.StartsWith(temp[0]))
            //    {
            //        Console.Write("\n" + str[0] + ": ");
            //    }
            //    Console.Write(str + " ");
            //    temp = str;
            //}

            return QS;
        }
        static string[] CallHeapSort()
        {
            string[] HS = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                HS[i] = s[i];
            }

            HeapSort heapSort = new HeapSort();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            heapSort.Sort(HS);

            stopwatch.Stop();
            Console.WriteLine("\nHeap Sort - Time Elapsed: " + stopwatch.Elapsed);

            //var temp = " ";
            //foreach (string str in SS)
            //{
            //    if (!str.StartsWith(temp[0]))
            //    {
            //        Console.Write("\n" + str[0] + ": ");
            //    }
            //    Console.Write(str + " ");
            //    temp = str;
            //}

            return HS;
        }



        // Just in case I want an array with 2.5 million ints
        static void FindingNumberOfCaves(string rawString)
        {
            // To outperform the string.Split and Int32.Parse method,I decided to implement it myself  .
            // In this function, we have to provide the raw string to find out the number of cavers

            // We iterate through the raw string, adding each number to the string NumberCaves
            // until we find a comma. Then we break the loop.
            for (int i = 0; i < rawString.Length; i++)
            {
                if (rawString[i] == ',')
                {
                    break;
                }
                // After each iteration, we multiply the current NumberCave by 10 so we can move the
                // current value to the tens, hundreds, and so on. Then we add it to the value of
                // the character found at i position on the rawString. The - '0' will give us the integer from the char
                NumberCaves = NumberCaves * 10 + (rawString[i] - '0');
            }
        }
        static int CalculateTotalSplits(int numberCaves)
        {
            // We need to find out how many different sets of integers are in the string.
            // We multiply by 2 the numberCaves value to obtain the number of coordinates, then we
            // square the numberCaves value to obtain the number of connections. The number 1 represents the set of integer with the value for
            // the number of caves, the first of the string.
            // We add the results to find out how many times we need to split the string.
            return (numberCaves * 2) + ((int)Math.Pow(numberCaves, 2)) + 1;
        }
        static int[] SplittingAndParsing(string rawString, int iterations)
        {
            // This method it is also created to outperform the string.Split and Int32.Parse method.
            // Providing the number of caves and iterations, we can split all the numbers and convert
            // them to int.

            int row = 0;
            int[] intArray = new int[iterations];

            // We iterate through the raw string, adding each number to the string NumberCaves,
            // Each time we find a comma, we increment the row value and use continue to avoid the
            // addition of the comma into the array
            for (int i = 0; i < rawString.Length; i++)
            {
                if (rawString[i] == ',')
                {
                    row++;
                    continue;
                }
                // After each iteration, we multiply the current value of intArray[row] by 10 so we can move the
                // current value to the tens, hundreds, and so on. Then we add it to the value of
                // the character found at i position on the rawString. The - '0' will give us the integer from the char
                intArray[row] = intArray[row] * 10 + (rawString[i] - '0');
            }
            // Once we iterate through the whole string, we return the array.
            return intArray;
        }
    }  
}

