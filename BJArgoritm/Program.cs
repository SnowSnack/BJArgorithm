using System.Collections.Generic;
using static System.Console;

class Program
{
    public void Solution()
    {
        int input = int.Parse(ReadLine());


        int fiveQuotient = input / 5;
       

        int tmp = input%5;
        int answer = 0;

        if (input.Equals(0))
        {
            WriteLine(0);
            ReadLine();
            return;
        }
        for (int i = fiveQuotient; i >= 0; i--)
        {
            if(!i.Equals(fiveQuotient))
                tmp += 5;
            WriteLine(i + " : "+tmp);
            if ((tmp % 3).Equals(0))
            {
                answer = i + tmp/ 3;
                break;
            }
            else
                continue;
        }

        if (answer.Equals(0))//답이 안나왓다면
            answer = -1;

        WriteLine(answer);


        ReadLine();
        ReadLine();
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}