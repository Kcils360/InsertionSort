using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 25, 14, 9, 32, 7 };
            int len1 = arr1.Length-1;

            int[] arr2 = { 69, 56, 77, 44, 8, 0, 566, 111 };
            int len2 = arr2.Length-1;
            Insertion sort = new Insertion();

            sort.InsertionSort(arr1);
            //sort.InsertionSort(arr2);

            Merge merger = new Merge();


            merger.SortMethod(arr2, 0, len2);
            merger.Print(arr2);

        }
    }
}
