using System.Collections.Generic;
using static System.Console;

class Program
{
    public void Solution()
    {
        int count = int.Parse(ReadLine());
        
        string  input;
        int     sum = 0;
        
        char toInspection = '\'';
        char beforeChar;

        Dictionary<char, bool> isGroupDic = new Dictionary<char, bool>();

        for (int j = 0; j < count; j++)
        {
            input = ReadLine();
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                
                
                if (i.Equals(0))
                {
                    beforeChar = toInspection;
                }
                else
                {
                    beforeChar = input[i - 1];
                }

                toInspection = input[i];

                if (isGroupDic.ContainsKey(toInspection))
                {
                    if (!toInspection.Equals(beforeChar))
                    {
                        if (isGroupDic[toInspection].Equals(true))
                        {
                            isGroupDic[toInspection] = false;
                            sum--;
                        }
                    }
                }
                else
                {
                    isGroupDic.Add(toInspection, true);
                    sum++;
                }
            }
        }
        WriteLine(sum);
        ReadLine();
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}