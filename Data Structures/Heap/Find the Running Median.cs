using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static List<double> minHeap = new List<double>();
    static List<double> maxHeap = new List<double>();

    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double median = -1;

        int i = 0;
        if(n >= 2)
        {
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:f1}", first));

            int second = int.Parse(Console.ReadLine());
            median = (first + second) / 2.0;
            Console.WriteLine(string.Format("{0:f1}", median));
            if(first < second)
            {
                minAdd(second);
                maxAdd(first);
            }
            else
            {
                maxAdd(second);
                minAdd(first);
            }
            i = 2;
        }

        for (; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if (median < value) minAdd(value);
            else maxAdd(value);

            if (minHeap.Count > maxHeap.Count + 1)
            {
                maxAdd(minHeap[0]);
                minHeap[0] = minHeap[minHeap.Count - 1];
                minHeap.RemoveAt(minHeap.Count - 1);
                Sort(minHeap, true);
            }
            else if (minHeap.Count + 1 < maxHeap.Count)
            {
                minAdd(maxHeap[0]);
                maxHeap[0] = maxHeap[maxHeap.Count - 1];
                maxHeap.RemoveAt(maxHeap.Count - 1);
                Sort(maxHeap, false);
            }

            if (minHeap.Count == maxHeap.Count) median = (minHeap[0] + maxHeap[0]) / 2;
            else if (minHeap.Count > maxHeap.Count) median = minHeap[0];
            else if (minHeap.Count < maxHeap.Count) median = maxHeap[0];

            Console.WriteLine(string.Format("{0:f1}", median));
        }
    }

    static void minAdd(double value)
    {
        if (minHeap.Count == 0) minHeap.Add(value);
        else
        {
            minHeap.Add(value);
            int currentPosition = minHeap.Count - 1;
            int parentPosition = (currentPosition - 1) / 2;
            while (currentPosition > 0 && minHeap[currentPosition] < minHeap[parentPosition])
            {
                double temp = minHeap[parentPosition];
                minHeap[parentPosition] = minHeap[currentPosition];
                minHeap[currentPosition] = temp;

                currentPosition = parentPosition;
                parentPosition = (currentPosition - 1) / 2;
            }
        }
    }

    static void maxAdd(double value)
    {
        if (maxHeap.Count == 0) maxHeap.Add(value);
        else
        {
            maxHeap.Add(value);
            int currentPosition = maxHeap.Count - 1;
            int parentPosition = (currentPosition - 1) / 2;
            while (currentPosition > 0 && maxHeap[currentPosition] > maxHeap[parentPosition])
            {
                double temp = maxHeap[parentPosition];
                maxHeap[parentPosition] = maxHeap[currentPosition];
                maxHeap[currentPosition] = temp;

                currentPosition = parentPosition;
                parentPosition = (currentPosition - 1) / 2;
            }
        }
    }

    static void Sort(List<double> heap, bool isMinHeap)
    {
        int parentPosition = 0;
        int leftPosition = 1;
        int rightPosition = 2;
        int childPosition = 0;

        while (leftPosition < heap.Count)
        {
            if (rightPosition >= heap.Count) childPosition = leftPosition;
            else childPosition = ((isMinHeap == true && heap[leftPosition] < heap[rightPosition]) || (isMinHeap == false && heap[leftPosition] > heap[rightPosition])) ? leftPosition : rightPosition;

            if ((isMinHeap == true && heap[parentPosition] > heap[childPosition]) ||
                (isMinHeap == false && heap[parentPosition] < heap[childPosition]))
            {
                double temp = heap[parentPosition];
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