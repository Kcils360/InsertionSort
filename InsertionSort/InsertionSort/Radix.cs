﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class Radix
    {
        public int[] Radixsort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits
            int m = GetMax(arr, n);

            //this handles moving from 1s to 10s, to 100s etc.
            for (int exp = 1; m / exp > 0; exp *= 10)
            {
                CountSort(arr, n, exp);
            }
            return arr;
            
        }
        // A utility function to get maximum value in arr[]
        static public int GetMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

         static public void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; // output array
            int i;
            int[] count = new int[10];
            Array.Fill(count, 0);

            for (i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            //output array is sorted here, this rearanges the original arr[] to match the sorted output array
            for (i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

       public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

        }
    }
}
