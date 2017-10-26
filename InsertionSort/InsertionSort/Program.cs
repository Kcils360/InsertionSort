using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 25, 14, 9, 32, 7 };
            int len1 = arr1.Length - 1;

            int[] arr2 = { 69, 56, 77, 44, 8, 0, 566, 111 };
            int len2 = arr2.Length - 1;

            int[] arr3 = { 170, 45, 75, 90, 802, 24, 2, 66, 7, 666, 256, 12 };
            int len3 = arr3.Length;

            Insertion sort = new Insertion();
            Merge merger = new Merge();
            Radix radsort = new Radix();

            Console.WriteLine("Insertion Sort");
            sort.InsertionSort(arr1);

            Console.WriteLine("\n\nMerge Sort");
            merger.SortMethod(arr2, 0, len2);
            merger.Print(arr2);
            
            Console.WriteLine("\n\nRadix Sort");
            radsort.Radixsort(arr3, len3);
            radsort.Print(arr3);

            Console.ReadKey();

        }
    }
}
