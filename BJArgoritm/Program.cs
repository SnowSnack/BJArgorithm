using System;
using System.Collections.Generic;
using System.Windows.Markup;
using static System.Console;

class Program
{
    public void Solution()
    {

        int countInput = int.Parse(ReadLine());
        string[] inputs  = ReadLine().Split(' ');
        int[] values = new int[inputs.Length];
        string answer = 0;
        
        for(int i=0; i<inputs.Length; i++)
        {
            values[i] = int.Parse(inputs[i]);
        }

        int height = values[0];
        int width = values[1];
        int order = values[2];

        int y = 0;
        int x = 0;
        int orderTmp = 0;

        for(int i=0; i<width; i++)
        {
            for(int j=0; j<height; j++)
            {
                x++;
                //order--;
            }
        }

    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}