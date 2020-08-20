using System;
using static System.Console;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    void Solution()
    {
        string input =ReadLine();
        int intInput = int.Parse(input);
        int num;
        int sum;
        
        for(int i=1; i<1000000; i++)
        {
            num = i;
            sum = num;
            while(num!=0)
            { 
                sum += num % 10;
                num /= 10;
            }
            if (sum.Equals(intInput))
            {
                WriteLine(i);
                return;
            }
                
        }

        WriteLine(0);
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}