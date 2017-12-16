using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    /// <summary>
    /// Item1 = arrival Time
    /// Item2 = Cooking Time
    /// </summary>
    static List<Tuple<long, long>> customers = new List<Tuple<long, long>>();
    static List<Tuple<long, long>> order = new List<Tuple<long, long>>();

    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (long i = 0; i < n; i++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            customers.Add(Tuple.Create(input[0], input[1]));
        }
        customers.Sort(compare);

        // Calculate
        long totalTIme = 0;
        long currentCookingTime = 0;
        int index = 0;
        while (true)
        {
            int i = 0;
            for (i = index; i < n; i++)
            {
                if (customers[i].Item1 <= currentCookingTime) minAdd(order, customers[i]);
                else
                {
                    index = i;
                    break;
                }
            }

            if (i == n) index = n;

            if(order.Count != 0)
            {
                totalTIme += currentCookingTime + order[0].Item2 - order[0].Item1;
                currentCookingTime += order[0].Item2;
                Delete(order, order[0]);
            }
            else
            {
                if(index != n) currentCookingTime = customers[index].Item1;
            }

            if (index == n && order.Count == 0) break;
        }

        Console.WriteLine(totalTIme / n);
    }

    static int compare(Tuple<long, long> t1, Tuple<long, long> t2)
    {
        if (t1.Item1 == t2.Item1) return 0;
        else if (t1.Item1 > t2.Item1) return 1;
        else return -1;
    }

    static void minAdd(List<Tuple<long, long>> heap, Tuple<long, long> value)
    {
        if (heap.Count == 0) heap.Add(value);
        else
        {
            heap.Add(value);
            int currentPosition = heap.Count - 1;
            int parentPosition = (currentPosition - 1) / 2;

            while (currentPosition > 0 && heap[currentPosition].Item2 < heap[parentPosition].Item2)
            {
                Tuple<long, long> temp = heap[parentPosition];
                heap[parentPosition] = heap[currentPosition];
                heap[currentPosition] = temp;

                currentPosition = parentPosition;
                parentPosition = (currentPosition - 1) / 2;
            }
        }
    }

    static void Delete(List<Tuple<long, long>> heap, Tuple<long, long> value)
    {
        int currentPosition = 0;
        int iter = 0;
        foreach (var item in heap)
        {
            if (item.Item1 == value.Item1 && item.Item2 == value.Item2)
            {
                currentPosition = iter;
                break;
            }
            iter++;
        }

        heap[currentPosition] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        int parentPosition = currentPosition;
        int leftPosition = currentPosition * 2 + 1;
        int rightPosition = leftPosition + 1;
        int childPosition = 0;

        while (leftPosition < heap.Count)
        {
            if (rightPosition >= heap.Count) childPosition = leftPosition;
            else
            {
                childPosition = (heap[leftPosition].Item2 < heap[rightPosition].Item2) ? leftPosition : rightPosition;
            }

            if (heap[parentPosition].Item2 > heap[childPosition].Item2)
            {
                Tuple<long, long> temp = heap[parentPosition];
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