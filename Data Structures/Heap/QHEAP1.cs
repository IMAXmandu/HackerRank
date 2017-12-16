using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static List<int> heap = new List<int>();
    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            int[] query = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            switch (query[0])
            {
                case 1: Add(query[1]); break;
                case 2: Delete(query[1]); break;
                case 3: Console.WriteLine(heap[0]); break;
            }
        }
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

    static void Delete(int value)
    {
        int currentPosition = heap.FindIndex(x => x == value);
        heap[currentPosition] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        int parentPosition = currentPosition;
        int leftPosition = currentPosition * 2 + 1;
        int rightPosition = leftPosition + 1;
        int childPosition = 0;

        while(leftPosition < heap.Count)
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