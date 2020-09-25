using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class Program
{
    static void Swap(int[,] _arr, int beforeIndex, int foreIndex)
    {
        var tmp = _arr[beforeIndex, 0];
        var tmp2 = _arr[beforeIndex, 1];
        _arr[beforeIndex, 0] = _arr[foreIndex, 0];
        _arr[beforeIndex, 1] = _arr[foreIndex, 1];
        _arr[foreIndex, 0] = tmp;
        _arr[foreIndex, 1] = tmp;
    }

    public int Partition(int[,] _arr, int _left, int _right)
    {
        int pivot = _left;
        for (int i = _left; i < _right; i++)
        {
            if (_arr[i,0] <= _arr[_right,0])
            {
                Swap(_arr, pivot, i);
                pivot++;
            }
        }
        Swap(_arr, pivot, _right);
        return pivot;
    }

    public void QuickSort(int[,] _arr, int _left, int _right)
    {
        if (_left < _right)
        {
            int pivot = Partition(_arr, _left, _right);
            QuickSort(_arr, _left, pivot - 1);
            QuickSort(_arr, pivot + 1, _right);
        }
    }

    void Solution()
    {
        int cnt = int.Parse(ReadLine());

        int[,] pairs = new int[cnt,2];

        for(int i=0; i<cnt; i++)
        {
            int[] arr = ReadLine().Split(' ').Select(a=>int.Parse(a)).ToArray();
            pairs[i, 0] = arr[0];
            pairs[i, 1] = arr[1];
        }

        QuickSort(pairs, 0, cnt-1);

        for(int i=0; i<cnt; i++)
        {
            WriteLine("{0} {1}", pairs[i, 0], pairs[i, 1]);
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}