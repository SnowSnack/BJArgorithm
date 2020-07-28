using System;
using static System.Console;

class Program
{
    public void Solution()
    {
        int countInput = int.Parse(ReadLine());

        double remain;
        int x=0, y =0;

        for (int j=0; j<countInput; j++)
        {
            string[] inputs = ReadLine().Split(' ');

            if (inputs.Length < 2)
                return;
            WriteLine("lenth" + inputs.Length);
            for (int i = 0; i < inputs.Length; i++)
            {
                if(i.Equals(0))
                    x = int.Parse(inputs[i]);
                else
                    y = int.Parse(inputs[i]);
            }

            for (int i = 1; i < i + 1; i++)
            {
                if (i * i >= y - x)
                {
                    if ((--i).Equals(0))
                    {
                        WriteLine(1);
                    }
                    remain = Math.Ceiling((double)(y-x - i * i)/i);
                    WriteLine(i*2-1+remain);
                    break;
                }
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