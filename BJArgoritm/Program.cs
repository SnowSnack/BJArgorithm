using System;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    int max, cnt;
    bool[] visited;
    int[] nums;
    StringBuilder sb;
    public void dfs(int _level)
    {
        if(_level.Equals(cnt))
        {
            for (int i = 0; i < cnt; i++)
            {
                sb.Append(nums[i] + " ");
            }
            sb.AppendLine();
        }
        else
        {
            for(int i=1; i<=max; i++)
            {
                if (visited[i])
                    continue;

                visited[i] = true;
                nums[_level] = i;
                dfs(_level + 1);
                visited[i] = false;
            }
        }
    }

    public void Solution()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        sb = new StringBuilder();

        int[] inputs = sr.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        max = inputs[0];
        cnt = inputs[1];

        visited= new bool[max + 1];
        nums= new int[cnt];

        for(int i=1; i<=max; i++)
        {
            visited[i] = true;
            nums[0] = i;
            dfs(1);
            visited[i] = false;
        }

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