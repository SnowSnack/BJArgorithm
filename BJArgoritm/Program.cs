using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
class Program
{
    public void merge(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        KeyValuePair<int,int>[] arr = new KeyValuePair<int, int>[_right+1];
        int mid = (_left + _right) / 2;

        int i = _left;
        int j = mid + 1;
        int index = _left;

        while(i<=mid&&j<_right)
        {
            if (_arr[i].Value <= _arr[j].Value)
                arr[index++] = _arr[i++];
            else
                arr[index++] = _arr[j++];  
        }

        int tmp = i > mid ? j : i;
        
        while (index < _right)
            arr[index++] = _arr[tmp++];

        for (int k = _left; k < _right; k++)
            _arr[k] = arr[k];
    }

    public void Partition(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        int mid;
        if(_left < _right)
        {
            mid = (_left + _right) / 2;
            Partition(ref _arr, _left, mid);
            Partition(ref _arr, mid+1, _right);
            merge(ref _arr, _left, _right);
        }
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

        int tmp=0;
        if ((cnt % 2).Equals(0))
            tmp = 1;

        int arith = sum / cnt+tmp;
        int middleVal = nums[cnt / 2];
        int range = nums[cnt - 1] - nums[0];
        numMax = nums[nums.Length - 1];

        for(int i=0; i<nums.Length; i++)
        {
            if (!oftens.ContainsKey(nums[i]))
                oftens.Add(nums[i], 1);
            else
                oftens[nums[i]]++;
            //Write("{0} {1}\n", nums[i], oftens[nums[i]]);
        }

        KeyValuePair<int,int>[] oftenArr = oftens.ToArray();

        Partition(ref oftenArr, 0, oftenArr.Length);

        for (int i = 0; i < oftens.Count; i++)
        {
            Write("{0} , {1}\n", oftenArr[i].Key, oftenArr[i].Value);
        }

        int oftLen = oftenArr.Length;
        int index = oftLen-1;
        int beforeIndex = oftLen - 2;
        bool beforeEqual =false;

        if(index>1)
        {
            while (true)
            {
                if (oftenArr[index].Value.Equals(oftenArr[beforeIndex].Value))
                {
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

                if (!(index > 1))
                {
                    //앞과 같음
                    break;
                }
            }
        }
        
        //보완필요(앞에서 두번쨰 검출)
        
        Write("{0}\n{1}\n{2}\n{3}", arith, middleVal, oftenArr[index].Key, range);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}