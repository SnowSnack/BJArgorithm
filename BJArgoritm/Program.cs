using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using static System.Console;

class Program
{

    public int Method(int count, int answer, int origin, int distance)
    {
        answer++;
        for (int i = 0; i < count; i++)
        {
            origin++;
            if (origin == distance)
            {
                WriteLine(answer);
                return -1;
            }
        }
        return origin;
    }
    public void Solution()
    {
        int countInput = int.Parse(ReadLine());

        string[] inputs;
        int[] values;

        int distance;
        int count;
        int answer;
        int origin;
        for (int j=0; j<countInput; j++)
        {
            inputs = ReadLine().Split(' ');
            values = new int[inputs.Length];

            distance = 0;

            count = 1;
            answer = 0;
            origin = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                values[i] = int.Parse(inputs[i]);
            }

            distance = values[1] - values[0];

            while (true)
            {
                origin = Method(count, answer++, origin, distance);
                if (origin.Equals(-1))
                    break;
                origin = Method(count, answer++, origin, distance);
                if (origin.Equals(-1))
                    break;
                count++;
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