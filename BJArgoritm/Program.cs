using System;
using System.Collections.Generic;
using System.Windows.Markup;
using static System.Console;

class Program
{
    public void Solution()
    {

        int countInput = int.Parse(ReadLine());
        string[] inputs;
        int[] values;
        string answer;

        int height;
        int width;
        int order;

        int y;
        int x;
        int over=0;

        string tmp;

        for (int i=0; i<countInput; i++)
        {
            inputs = ReadLine().Split(' ');
            values = new int[inputs.Length];
            
            for (int j = 0; j < inputs.Length; j++)
            {
                values[j] = int.Parse(inputs[j]);
            }

            height = values[0];
            width = values[1];
            order = values[2];

            if (height < 1 || width > 99 || order > height * width)
                return;

            if ((order % width).Equals(0))
                y = order / height;
            else
                y = order / height + 1;
            
            if (y > width)
            {
                y %= width;
                over+= y/width;
            }
            
            x = order % height + over;

            if (x.Equals(0))
                x = height;

            if (y < 10)
                tmp = "0";
            else
                tmp = "";

            answer = x+ tmp + y;
            WriteLine(answer);
            over = 0;
        }
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}