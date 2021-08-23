using System;
using System.Linq;
using System.Text;
using System.IO;
class Program
{
    int cnt;
    StringBuilder sb;

    public void Solution()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        sb = new StringBuilder();

        cnt = int.Parse(sr.ReadLine());
        int[] nums = new int[cnt];
        int[] sums = new int[cnt];

        nums = sr.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            sums[i] = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                    sums[i]++;
            }
            sb.Append(sums[i] + " ");
        }
        sb.AppendLine();

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
        sb.Clear();
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        p.Solution();
    }
}