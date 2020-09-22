using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
class Program
{
    public void MergeForValue( KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        KeyValuePair<int,int>[] newArr = new KeyValuePair<int, int>[_right];
        int mid = (_left + _right) / 2;
        int lIndex = _left;
        int rIndex = mid;
        int index=_left;
        while(lIndex<=mid&&rIndex<_right)
        {
            if(_arr[lIndex].Value < _arr[rIndex].Value)
            {
                newArr[index++] = _arr[lIndex++];
            }
            else
            {
                newArr[index++] = _arr[rIndex++];
            }
        }

        int remainIndex = lIndex <= mid ? lIndex : rIndex;

        for(int i=remainIndex; i<_right; i++)
        {
            newArr[i] = _arr[i];
        }

        for(int i=_left; i<_right; i++)
        {
            _arr[i] = newArr[i];
        }
    }

    public void MergeForKey( KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        KeyValuePair<int, int>[] newArr = new KeyValuePair<int, int>[_right];
        int mid = (_left + _right) / 2;
        int lIndex = _left;
        int rIndex = mid;
        int index = _left;
        while (lIndex <= mid && rIndex < _right)
        {
            if (_arr[lIndex].Key < _arr[rIndex].Key)
            {
                newArr[index++] = _arr[lIndex++];
            }
            else
            {
                newArr[index++] = _arr[rIndex++];
            }
        }

        int remainIndex = lIndex <= mid ? lIndex : rIndex;

        for (int i = remainIndex; i < _right; i++)
        {
            newArr[i] = _arr[i];
        }

        for (int i = _left; i < _right; i++)
        {
            _arr[i] = newArr[i];
        }
    }

    public void Divide( KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        if(_left < _right)
        {
            int mid = (_left + _right) / 2;
            Divide( _arr, _left, mid);
            Divide( _arr, mid+1, _right);
            MergeForValue( _arr, _left, _right);
            
        }
    }

    public int Mode( KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        Divide( _arr, _left, _right);

        int modeIndex = 1;
        if(_right>1)//배열크기가 0일때(i+1)이 성립되지않음
        {
            for (int i = _right - 1; i > 0; i--)
            {
                if (!_arr[i].Value.Equals(_arr[i - 1].Value))
                {
                    if (i.Equals(_right - 1))//제일오른쪽이 최빈값일떄
                        modeIndex = i;
                    else
                        modeIndex = i + 1;
                    break;
                }
            }
        }
        else//배열크기가 0일때(i+1)이 성립되지않음
        {
            modeIndex = 0;
        }
        return _arr[modeIndex].Key;
    }

    void Solution()
    {
        int cnt = int.Parse(ReadLine());

        int[] nums = new int[cnt];
        int mode;
        Dictionary<int, int> oftens = new Dictionary<int, int>();
        int sum = 0;
        int numMax;

        for (int i = 0; i < cnt; i++)
        {
            nums[i] = int.Parse(ReadLine());
            sum += nums[i];
        }

        Array.Sort(nums);

        //숫자 받고 1차 정렬

        int arith = (int) Math.Round((double) sum / cnt);
        int middleVal = nums[cnt / 2];
        int range = nums[cnt - 1] - nums[0];

        numMax = nums[nums.Length - 1];

        for(int i=0; i<nums.Length; i++)
        {
            if (!oftens.ContainsKey(nums[i]))
                oftens.Add(nums[i], 1);
            else
                oftens[nums[i]]++;
        }

        KeyValuePair<int,int>[] oftenArr = oftens.ToArray();

        mode = Mode(oftenArr, 0, oftenArr.Length);

        int oftLen = oftenArr.Length;
        int index = oftLen-1;

        Write("{0}\n{1}\n{2}\n{3}\n", arith, middleVal, mode, range);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}