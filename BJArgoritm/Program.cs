using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
class Program
{
    public void merge(ref KeyValuePair<int, int>[] _arr, int _left, int _right)
    {
        KeyValuePair<int,int>[] arr = new KeyValuePair<int, int>[_right];
        int mid = (_left + _right) / 2;

        int lIndex = _left;  //왼쪽 시작 인덱스
        int rIndex = mid;//오른쪽 시작 인덱스
        int tmp = _left;

        while(lIndex<mid&&rIndex<_right)
        {
            if (_arr[lIndex].Value < _arr[rIndex].Value)
                arr[tmp++] = _arr[lIndex++];
            else
                arr[tmp++] = _arr[rIndex++];  
        }

        int remainIndex = lIndex > mid ? rIndex : lIndex;
        
        while (tmp < _right)
            arr[tmp++] = _arr[remainIndex++];

        Write(_left +" "+ _right+" : \n");
        for(int i=_left;i<_right;i++)
            WriteLine(arr[i]);

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

        Partition(ref oftenArr, 0, oftenArr.Length);

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

        for (int i = 0; i < oftens.Count; i++)
        {
            WriteLine("{0} {1}", oftenArr[i].Key, oftenArr[i].Value);
        }

        //보완필요(앞에서 두번쨰 검출)

        Write("{0}\n{1}\n{2}\n{3}\n", arith, middleVal, oftenArr[index].Key, range);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}