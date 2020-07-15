using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

class Program
{
    public void Solution()
    {
        string input        = Console.ReadLine();
        string upperInput   = input.ToUpper();

        Dictionary<char, int> upperDictionary = new Dictionary<char, int>();

        List<char>  keys;
        List<int>   values;
        char        answer;
        int         answerIndex;

        for(int i=0; i<upperInput.Length; i++)
        {
            char toAddKey = upperInput[i];

            if (upperDictionary.ContainsKey(toAddKey))
                upperDictionary[toAddKey]++;
            else
                upperDictionary.Add(toAddKey, 1);
        }
        
        keys = upperDictionary.Keys.ToList<char>();
        values = upperDictionary.Values.ToList<int>();
        answerIndex = 0;

        if (keys.Count > 0)
        {
            for (int i = 1; i < keys.Count; i++)
            {
                if (upperDictionary[keys[i]] > upperDictionary[keys[i - 1]])
                    answerIndex = i;
                else
                    answerIndex = i - 1;
            }
        }
        else
        {
            answerIndex = 0;
        }

        answer = keys[answerIndex];
        
        for (int i = 0; i < values.Count; i++)
        {
            if (!i.Equals(answerIndex))
            {
                if (values[answerIndex].Equals(values[i]))
                {
                    answer = '?';
                    break;
                }
            }
        }

        Console.WriteLine(answer);
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}