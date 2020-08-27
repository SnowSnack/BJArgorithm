using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    void PartSort(List<int> _nums, int _left, int _right)
    {
        if(_left<_right)
        {
            int pivot = _nums[(_left + _right) / 2];
            int high = _right;
            int low = _left;
            int tmp;

            while (low < high)
            {
                while (_nums[low] < pivot && low < high)
                    low++;
                while (_nums[high] > pivot && high > low)
                    high--;

                tmp = _nums[low];
                _nums[low] = _nums[high];
                _nums[high] = tmp;
            }

            PartSort(_nums, _left, high - 1);
            PartSort(_nums, high + 1, _right);

        }

    }

    public void quickSort(List<int> arr, int left, int right)
    {
        int i, j, pivot, tmp;
        if (left < right)
        {
            i = left; j = right;
            pivot = arr[(left + right) / 2];
            //분할 과정
            while (i < j)
            {
                while (arr[j] > pivot) j--;
                // 이 부분에서 arr[j-1]에 접근해서 익셉션 발생가능함.
                while (i < j && arr[i] < pivot) i++;

                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
            //정렬 과정
            quickSort(arr, left, i - 1);
            quickSort(arr, i + 1, right);
        }
    }

    void Solution()
    {
        int left, right, low, high;

        int count = int.Parse(ReadLine());

        List<int> nums = new List<int>();
        
        for(int i=0; i<count; i++)
        {
            nums.Add(int.Parse(ReadLine()));
        }

        left = 0;

        right = nums.Count-1;

        low = left+1;

        high = right;

        PartSort(nums, left, right);

        for (int i = 0; i < nums.Count; i++)
        {
            Write(nums[i]);
        }
        ReadLine();
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}