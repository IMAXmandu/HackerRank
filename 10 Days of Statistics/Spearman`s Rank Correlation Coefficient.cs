using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Solution
{
    class valueAndRank
    {
        public double value;
        public int rank;
        public valueAndRank(double a)
        {
            value = a;
        }
    }

    static void Main(String[] args)
    {
        int size = int.Parse(Console.ReadLine());
        valueAndRank[] x = new valueAndRank[size];
        valueAndRank[] y = new valueAndRank[size];
        double[] xd = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), double.Parse);
        double[] yd = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), double.Parse);

        for(int i = 0; i < size ; ++i)
        {
            x[i] = new valueAndRank(xd[i]);
            y[i] = new valueAndRank(yd[i]);
        }
        for(int i = 0; i < size ;++i){
            int countx = 1;
            int county = 1;
            for(int j = 0; j < size; ++j){
                if(x[i].value > x[j].value){
                    ++countx; 
                }
                if(y[i].value > y[j].value){
                    ++county; 
                }
            }
            x[i].rank = countx;
            y[i].rank = county;
        } 
        double result = spearman(x,y,size);
        Console.WriteLine(string.Format("{0:F3}",result));
    }
    static double spearman(valueAndRank[] x, valueAndRank[] y, int n)
    {
        double di2 = 0;
        for (int i = 0; i < n; ++i)
        {
            di2 += (x[i].rank - y[i].rank) * (x[i].rank - y[i].rank);
        }
        return 1 - ((6 * di2) / (n * ((n * n) - 1)));
    }
}