using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class Insertion
    {
        public void InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            //print to console
            foreach( var point in arr )
            {
                Console.Write($"{point} ");
            }
            Console.ReadKey();


        }

    }
}
