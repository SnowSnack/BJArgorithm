using System;
using System.Collections.Generic;
using static System.Console;

class Program
{
    void PartSort(List<int> _nums, int _left, int _high, int _pivot)
    {
        while (true)
        {
            if (_nums[_left] >= _nums[_high])
            {
                int tmp = _nums[_left];
                _nums[_left] = _nums[_high];
                _nums[_high] = tmp;
            }
            else
            {

            }
            _left++; _high--;
            if (_left >= _high)
                break;
        }
        List<int> lefList = new List<int>();
        //_nums.CopyTo()
    }

    void Solution()
    {
        int pivot;
        int left, right, low, high;

        int count = int.Parse(ReadLine());

        List<int> a = new List<int>();

        List<int> nums = new List<int>();
        
        for(int i=0; i<count; i++)
        {
            nums.Add(int.Parse(ReadLine()));
        }

        pivot = 0;

        left = 0;

        right = nums.Count;

        low = left+1;

        high = right;

        PartSort(nums, left, high, pivot);

    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}