using System;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    int max, cnt;
    bool[] fVisited;
    bool[] visited;
    int[] nums;
    StringBuilder sb;
    public void dfs(int _level)
    {
        if (_level.Equals(cnt))
        {
            for (int i = 0; i < cnt; i++)
            {
                sb.Append(nums[i]);
                sb.Append(' ');
            }
            sb.Append('\n');
        }
        else
        {
            for (int i = 1; i <= max; i++)
            {
                if (visited[i])
                {
                    continue;
                }
                //Console.WriteLine("level = " + _level + ", cnt-1 = " + (cnt-1));
                //if(_level.Equals(cnt-1))
                //    Console.WriteLine("nums["+ _level +"] = " + nums[_level] + '\n'+ "nums[0] = " + nums[0] + '\n'+ nums[_level].Equals(nums[0]) + '\n' + '\n');
                
                if (i.Equals(nums[_level-1]))
                    visited[i] = true;

                nums[_level] = i;
                dfs(_level + 1);
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

        fVisited = new bool[max + 1];
        visited= new bool[max + 1];
        nums= new int[cnt];

        for(int i=1; i<=max; i++)
        {
            visited = new bool [max+1];
            for(int j=0; j<i; j++)
            {
                visited[j] = true;
            }
            nums[0] = i;
            dfs(1);
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