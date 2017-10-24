using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 25, 14, 9, 32, 7 };
            int[] arr2 = { 69, 56, 77, 44, 8, 0, 566, 111 };

            Insertion sort = new Insertion();

            sort.InsertionSort(arr1);
            sort.InsertionSort(arr2);



        }
    }
}
