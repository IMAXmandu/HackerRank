using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static List<int> heap = new List<int>();
    static void Main(String[] args)
    {
        int k = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)[1];
        int[] query = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        foreach (var item in query) Add(item);

        Calcul(k);
    }

    static void Add(int value)
    {
        if (heap.Count == 0) heap.Add(value);
        else
        {
            heap.Add(value);
            int currentPosition = heap.Count - 1;
            int parentPosition = (currentPosition - 1) / 2;
            while (currentPosition > 0 && heap[currentPosition] < heap[parentPosition])
            {
                int temp = heap[parentPosition];
                heap[parentPosition] = heap[currentPosition];
                heap[currentPosition] = temp;

                currentPosition = parentPosition;
                parentPosition = (currentPosition - 1) / 2;
            }
        }
    }

    static void Calcul(int k)
    {
        int repeat = 0;
        if (heap.Count == 1)
        {
            Console.WriteLine("1");
            return;
        }
        else if (heap[0] >= k)
        {
            Console.WriteLine(repeat);
            return;
        }

        while (heap.Count > 1)
        {
            repeat++;
            int first = heap[0];

            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            Sort();

            heap[0] = first + 2 * heap[0];
            Sort();

            if (heap[0] >= k)
            {
                Console.WriteLine(repeat);
                return;
            }
        }

        Console.WriteLine("-1");
    }

    static void Sort()
    {
        int parentPosition = 0;
        int leftPosition = 1;
        int rightPosition = 2;
        int childPosition = 0;

        while (leftPosition < heap.Count)
        {
            if (rightPosition >= heap.Count) childPosition = leftPosition;
            else childPosition = (heap[leftPosition] < heap[rightPosition]) ? leftPosition : rightPosition;

            if (heap[parentPosition] > heap[childPosition])
            {
                int temp = heap[parentPosition];
                heap[parentPosition] = heap[childPosition];
                heap[childPosition] = temp;

                parentPosition = childPosition;
            }
            else break;

            leftPosition = childPosition * 2 + 1;
            rightPosition = leftPosition + 1;
        }
    }
}