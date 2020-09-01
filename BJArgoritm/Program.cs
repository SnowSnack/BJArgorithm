
using System.Linq;
using static System.Console;
using System.Text;
class Program
{
    public int[] CountSort(int[] _arr)
    {
        int[] sum = Enumerable.Repeat(0,_arr.Max()+1).ToArray();
        int[] cumulSum = new int[_arr.Max()+1];
        int[] toReturn = new int[_arr.Length];
        for (int i=1; i<_arr.Length; i++)
        {
            sum[_arr[i]]++;
        }

        cumulSum[0] = sum[0];
        for(int i=1; i<=_arr.Max(); i++)
        {
            cumulSum[i] = cumulSum[i-1]+ sum[i];
        }
        for (int i = _arr.Length-1; i >= 1; i--)
        {
            toReturn[cumulSum[_arr[i]]] = _arr[i];
            cumulSum[_arr[i]]--;
        }

        WriteLine();

        return toReturn;
    }

    void Solution()
    {
        int cnt = int.Parse(ReadLine());

        StringBuilder sb = new StringBuilder();
        int[] arr = new int[cnt+1];
        for (int i = 1; i <= cnt; i++)
        {
            arr[i] = int.Parse(ReadLine());
        }

        int[] answers =  CountSort(arr);

        for(int i=1; i<answers.Length; i++)
        {
            if(!answers[i].Equals(0))
                sb.AppendFormat("{0}\n",
            answers[i]);
        }
        Write(sb);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}