using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void insertionSort(int[] ar)
    {
        bool isFind = false;
        int value = ar[ar.Length - 1];
        for (int i = ar.Length - 2; i >= 0; i--)
        {
            if(value > ar[i])
            {
                isFind = true;
                ar[i + 1] = value;
            }
            else
            {
                ar[i + 1] = ar[i];
            }
            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            if (isFind == true) break;
        }

        if (isFind == false)
        {
            ar[0] = value;
            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }
        }
    }
    /* Tail starts here */
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