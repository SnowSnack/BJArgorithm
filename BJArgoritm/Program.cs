using System;
using static System.Console;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Runtime.InteropServices.WindowsRuntime;

class Program
{
    void Solution()
    {
        int[] count = ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

        int n = count[0];
        int m = count[1];

        char[,] map = new char[n,m];

        for (int i = 0; i < n; i++)
        {
            //map[n] = ReadLine().ToCharArray();
        }

        for (int i=0; i<n; i++)
        {
            for(int j=0; j<m; j++)
            {

            }
        }
    }

    
    
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}