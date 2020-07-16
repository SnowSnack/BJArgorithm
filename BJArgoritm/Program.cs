using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    public void Solution()
    {
        string input = ReadLine();
        Dictionary<char, bool> groupDic = new Dictionary<char, bool>();
        for (int i = 0; i < input.Length-1; i++)
        {
            char toInspection = input[i];
            if (groupDic.ContainsKey(toInspection))
            {
                if(toInspection.Equals(input[i+1]))
                    groupDic[toInspection] = false;

            }
            else
                groupDic.Add(toInspection, true);
        }

        WriteLine(input.Length);
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}