using System;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    public void Solution()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int[] inputs = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        for(int i=0; i<inputs[1]; i++)
        {

        }

        sb.Length--;
        sw.WriteLine(sb);
        sb.Clear();
        sw.Close();
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        p.Solution();
    }
}