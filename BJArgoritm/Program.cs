using System;
using System.Collections.Generic;
using System.Windows.Markup;
using static System.Console;

class Program
{
    int[,] array;
    public int Method(int _k, int _n)
    {
        int sum = 0;
        if (_k.Equals(0))
        {
            return _n;
        }
            
        for(int i=1; i<=_n; i++)
        {
            sum += Method(_k-1, i);
        }
        
        return sum;
    }
    public void Solution()
    {
        int inputCount = int.Parse(ReadLine());
        int k=0, n=0;
        
        for(int i=0;i<inputCount; i++)
        {
            for(int j=0;j<2;j++)
            {
                if (j.Equals(0))
                    k = int.Parse(ReadLine());
                else
                    n = int.Parse(ReadLine());
            }
            if(i.Equals(0))
                array = new int[k,n];

            WriteLine(Method(k, n));
        }
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}