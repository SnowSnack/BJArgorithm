using System;
using static System.Console;
using System.Linq;

class Program
{
    public void Solution()
    {
        double r = double.Parse(ReadLine());
        WriteLine(string.Format("{0:#.000000}",r * r * Math.PI));
        WriteLine(string.Format("{0:#.000000}", r*r*2f));
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}