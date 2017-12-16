using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void insertionSort(int[] ar)
    {
        for (int i = 1; i < ar.Length; i++)
        {
            int value = ar[i];
            int index = i - 1;
            while(index >= 0 && value < ar[index])
            {
                ar[index + 1] = ar[index];
                index--;
            }
            ar[index + 1] = value;

            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main(String[] args)
    {
        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int[] _ar = new int[_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        insertionSort(_ar);
    }
}