using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
class Program
{
    public void MergeValue(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        int lIndex = _left;
        int mid = (_left + _right) / 2;
        int rIndex = mid;
        int tmpIndex = _left;

        KeyValuePair<int, int>[] newArr = new KeyValuePair<int, int>[_right];
        while(lIndex<mid&&rIndex<_right)
        {
            if(_arr[lIndex].Value < _arr[rIndex].Value)
            {
                newArr[tmpIndex++] = _arr[lIndex++];
            }
            else
            {
                newArr[tmpIndex++] = _arr[rIndex++];
            }
        }

        int remainIndex = lIndex < mid ? lIndex : rIndex;

        while(tmpIndex<_right)
        {
            newArr[tmpIndex++] = _arr[remainIndex++];
        }

        for(int i=_left;i<_right; i++)
        {
            _arr[i] = newArr[i];
        }

    }
    public void DivideValue(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        int mid = (_left + _right) / 2;
        if(_left<_right)
        {
            DivideValue(ref _arr, _left, mid);
            DivideValue(ref _arr, mid + 1, _right);
            MergeValue(ref _arr, _left, _right);
        }
    }

    public void ValueMergeSort(ref KeyValuePair<int,int>[] _arr, int _left, int _right)
    {
        DivideValue(ref _arr, _left, _right);
        int i = 0;
        while(i+1<_right&&_arr[i].Value.Equals(_arr[i+1].Value))
        {
            i++;
        }
        KeyDivide(ref _arr, _left, i);

        for(i=0; i<_right; i++)
        {
            WriteLine(i + " " + _arr[i]);
        }
    }

    public void KeyDivide(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        int mid = (_left + _right) / 2;
        if (_left < _right)
        {
            KeyDivide(ref _arr, _left, mid);
            KeyDivide(ref _arr, mid + 1, _right);
            KeyMerge(ref _arr, _left, _right);
        }
    }

    public void KeyMerge(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        int lIndex = _left;
        int mid = (_left + _right) / 2;
        int rIndex = mid;
        int tmpIndex = _left;

        KeyValuePair<int, int>[] newArr = new KeyValuePair<int, int>[_right];
        while (lIndex < mid && rIndex < _right)
        {
            if (_arr[lIndex].Key < _arr[rIndex].Key)
            {
                newArr[tmpIndex++] = _arr[lIndex++];
            }
            else
            {
                newArr[tmpIndex++] = _arr[rIndex++];
            }
        }

        int remainIndex = lIndex < mid ? lIndex : rIndex;

        while (tmpIndex < _right)
        {
            newArr[tmpIndex++] = _arr[remainIndex++];
        }

        for (int i = _left; i < _right; i++)
        {
            WriteLine(i +" "+newArr[i]);
            _arr[i] = newArr[i];
        }
        WriteLine();
    }

    public void KeyMergeSort(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        KeyDivide(ref _arr, _left, _right);
    }

    void Solution()
    {
        int cnt = int.Parse(ReadLine());

        int[] nums = new int[cnt];
        Dictionary<int, int> oftens = new Dictionary<int, int>();
        int sum = 0;
        int numMax;

        for (int i = 0; i < cnt; i++)
        {
            nums[i] = int.Parse(ReadLine());
            sum += nums[i];
        }

        Array.Sort(nums);

        int arith = (int)Math.Round((double)sum / cnt);
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

        ValueMergeSort(ref oftenArr, 0, oftenArr.Length);

        int oftLen = oftenArr.Length;
        int index = oftLen-1;
        int beforeIndex = oftLen - 2;
        bool beforeEqual =false;


        if (index>1)
        {
            while (true)
            {
                if (oftenArr[index].Value.Equals(oftenArr[beforeIndex].Value))
                {
                    if (!(index > 1))
                    {
                        //[0]과 같음
                        break;
                    }
                    index--;
                    beforeIndex--;
                    beforeEqual = true;
                }
                else
                {
                    //앞과 다름
                    if (beforeEqual)
                        index++;
                    break;
                }
            }
        }

        //for (int i = 0; i < oftens.Count; i++)
        //{
        //    WriteLine("{0} {1}", oftenArr[i].Key, oftenArr[i].Value);
        //}

        //보완필요(앞에서 두번쨰 검출)

        Write("{0}\n{1}\n{2}\n{3}\n", arith, middleVal, oftenArr[index].Key, range);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}