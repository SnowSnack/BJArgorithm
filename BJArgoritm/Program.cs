using System;
using System.IO;
using System.Text;

class Program
{
	static void Main()
	{
		StreamReader sin = new StreamReader(Console.OpenStandardInput(2048), Encoding.ASCII, false, 2048);
		StreamWriter sout = new StreamWriter(Console.OpenStandardOutput(2048), Encoding.ASCII, 2048);
		StringBuilder sb = new StringBuilder();
		int[] cnt = new int[10001];
		int n = int.Parse(sin.ReadLine());

		while (n-- > 0)
		{
			cnt[int.Parse(sin.ReadLine())]++;
		}
		int tmp = 0;
		for (int i = 1; i <= 10000; i++)
		{
			while (cnt[i]-- > 0)
			{	sb.Append(i).Append('\n');
				if (tmp.Equals(785))
				{
					sout.Write(sb);
					tmp = 0;
					sb.Clear();
				}
				else
				{
					tmp++;
				}
			}
		}
		sout.Write(sb);
		sout.Flush();
		sin.ReadLine();
	}
}