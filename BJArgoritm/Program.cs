using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

class Program
{
    public void Solution()
    {
        string[] inputs = Console.ReadLine().Split(' ');

        List<int> list = new List<int>();

        for(int i=0;i<inputs.Length; i++)
        {
            inputs[i].ToArray().Reverse().ToArray();
        }

        int answer = inputs.Length;

        Console.WriteLine(answer);
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}