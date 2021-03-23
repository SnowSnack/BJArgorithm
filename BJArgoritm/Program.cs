using System;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    int[] sorted;
    public void merge(int[] _list, int _left, int _mid, int _right)
    {
        Console.WriteLine(_left + " " + _mid + " " + _right);
        int l = _left;
        int r = _mid + 1;
        int tmp = _left;

        Console.WriteLine(l + " " + r);

        while (l <= _mid && r <= _right)
        {
            if (_list[l] > _list[r])
            {
                sorted[tmp++] = _list[r++];
                sorted[tmp] = _list[r - 2];
            }
            else
            {
                sorted[tmp++] = _list[l++];
            }
            Console.WriteLine("tmp : " + (tmp - 1));
        }

        Console.WriteLine(tmp + "" + _mid);

        if(tmp>=_mid)
        {
            for(int i=r-1; i<_right; i++)
            {
                sorted[i] = _list[tmp++];
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine(1111);
        }
        else
        {
            for(int i=l; i<=_left; i++)
            {
                sorted[i] = _list[tmp++];
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine(2222);
        }

        for(int i= _left; i<=_right; i++)
        {
            _list[i] = sorted[i];
            Console.WriteLine("final i:" + i);
        }
        Console.WriteLine("Sorted : " + sorted[0] + " " + sorted[1] + " " +sorted[2]+ " " + sorted[3] + " " + sorted[4]);
    }

    public void mergeSort( int[] _list, int _left, int _right)
    {
        if (_left<_right)
        {
            int mid = (_left + _right) / 2;
            mergeSort( _list, _left, mid);
            mergeSort( _list, mid+1, _right);
            merge( _list, _left, mid, _right);
        }
    }

    public void Solution()
    {
        int count = int.Parse(Console.ReadLine());
        int[] inputs = new int[count];
        for (int i = 0; i < count; i++)
        {
            inputs[i] = int.Parse(Console.ReadLine());
        }

        sorted = inputs;

        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        mergeSort( inputs, 0, inputs.Length-1);

        for(int i=0; i<inputs.Length; i++)
        {
            sb.Append(inputs[i]);
            sb.AppendLine();
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