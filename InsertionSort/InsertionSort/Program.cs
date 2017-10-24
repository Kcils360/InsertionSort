using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monday = { 10, 25, 14, 9, 32, 7 };

            Insertion sort = new Insertion();
            sort.InsertionSort(monday);
        }
    }
}
