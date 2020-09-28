using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class Program
{
    public void Swap(int[,] _arr, int _left,int _right, int _tmp1, int _tmp2)
    {
        _tmp1 = _arr[_left,0];
        _tmp2 = _arr[_left, 1];
        _arr[_left, 0] = _arr[_right, 0];
        _arr[_left, 1] = _arr[_right, 1];
        _arr[_right, 0] = _tmp1;
        _arr[_right, 1] = _tmp2;
        WriteLine("[{0} , {1}] [{2} , {3}]", _arr[_left, 0], _arr[_left, 1], _arr[_right, 0], _arr[_right, 1]);
    }

    int Partition(int[,] _arr, int _left, int _right, int _secIndex)
    {
        WriteLine(_secIndex);
        int pivot, tmp1=0, tmp2=0;
        int low, high;

        low = _left;
        high = _right + 1;
        pivot = _arr[_left,_secIndex]; // 정렬할 리스트의 가장 왼쪽 데이터를 피벗으로 선택(임의의 값을 피벗으로 선택)

        /* low와 high가 교차할 때까지 반복(low<high) */
        do
        {
            /* list[low]가 피벗보다 작으면 계속 low를 증가 */
            do
            {
                low++; // low는 left+1 에서 시작
            } while (low <= _right && _arr[low,_secIndex] < pivot);

            /* list[high]가 피벗보다 크면 계속 high를 감소 */
            do
            {
                high--; //high는 right 에서 시작
            } while (high >= _left && _arr[high,_secIndex] > pivot);

            // 만약 low와 high가 교차하지 않았으면 list[low]를 list[high] 교환
            if (low < high)
            {
                Swap(_arr, low, high, tmp1, tmp2);
            }
        } while (low < high);
        Swap(_arr, _left, high, tmp1, tmp2);

        // 피벗의 위치인 high를 반환
        return high;
    }

    int PartitionKey(int[,] _arr, int _left, int _right)
    {
        int pivot, tmp1 = 0, tmp2 = 0;
        int low, high;

        low = _left;
        high = _right + 1;
        pivot = _arr[_left, 1]; // 정렬할 리스트의 가장 왼쪽 데이터를 피벗으로 선택(임의의 값을 피벗으로 선택)

        /* low와 high가 교차할 때까지 반복(low<high) */
        do
        {
            /* list[low]가 피벗보다 작으면 계속 low를 증가 */
            do
            {
                low++; // low는 left+1 에서 시작
            } while (low <= _right && _arr[low, 1] < pivot);

            /* list[high]가 피벗보다 크면 계속 high를 감소 */
            do
            {
                high--; //high는 right 에서 시작
            } while (high >= _left && _arr[high, 1] > pivot);

            // 만약 low와 high가 교차하지 않았으면 list[low]를 list[high] 교환
            if (low < high)
            {
                Swap(_arr, low, high, tmp1, tmp2);
            }
        } while (low < high);
        Swap(_arr, _left, high, tmp1, tmp2);

        // 피벗의 위치인 high를 반환
        return high;
    }

    public void QuickSort(int[,] _arr, int _left, int _right, int _secIndex)
    {
        int pivot = Partition(_arr, _left, _right, _secIndex);

        if (_left < _right)
        {
            QuickSort(_arr, _left, pivot - 1, _secIndex);
            QuickSort(_arr, pivot, _right, _secIndex);
        }
        int keyLeft = _left;
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

        QuickSort(pairs, 0, cnt - 1, 0);
        QuickSort(pairs, 0, cnt - 1, 1);
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