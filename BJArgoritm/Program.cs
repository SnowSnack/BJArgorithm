using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static System.Console;

class Program
{
    public void PartSort(int[] _arr, int _left, int _right)
    {
        if (_left < _right)
        {
            int tmp;
            int low = _left;
            int high = _right;
            int pivot = _arr[(_left + _right) / 2];
            while (low < high)
            {
                while (_arr[low] < pivot) low++;
                while (_arr[high] > pivot && low < high) high--;

                tmp = _arr[low];
                _arr[low] = _arr[high];
                _arr[high] = tmp;
            }

            PartSort(_arr, _left, high - 1);
            PartSort(_arr, high + 1, _right);
        }
    }


    void Solution()
    {
        int left, right;

        int count = int.Parse(ReadLine());

        int[] nums = new int[count];

        StringBuilder sb = new StringBuilder();

        for(int i=0; i<count; i++)
        {
            nums[i] = int.Parse(ReadLine());
        }

        left = 0;

        right = nums.Length-1;

        PartSort(nums, left, right);

        for (int i = 0; i < nums.Length; i++)
        {
            sb.AppendFormat("{0}\n",nums[i]);
        }

        Write(sb);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}