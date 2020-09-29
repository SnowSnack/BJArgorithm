using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
class Program
{

    void Solution()
    {
        int cnt = int.Parse(ReadLine());
        StringBuilder sb = new StringBuilder();

        int[] arr = new int[cnt];

        int sum = 0;
        int arith;
        int middle;
        int often;
        int len;
        int tmpIndex=0;

        for(int i=0;i<cnt; i++)
        {
            arr[i] = int.Parse(ReadLine());
            sum += arr[i];
        }

        Array.Sort(arr);

        arith = (int) Math.Round((double) sum / cnt);
        middle = arr[cnt / 2];

        len = arr[cnt - 1] - arr[0];

        int[,] myDictionary = new int[cnt, 2];
        bool isContains = false;
        tmpIndex = 0;
        for (int i = 0; i < cnt; i++)
        {
            isContains = false;
            for (int j = 0; j < cnt; j++)
            {

                if (myDictionary[j, 0].Equals(arr[i]))
                {
                    myDictionary[j, 1]++;
                    isContains = true;
                    break;
                }
            }
            if(!isContains)
            {
                myDictionary[tmpIndex, 0] = arr[i];
                myDictionary[tmpIndex, 1] = 1;
                tmpIndex++;
            }
            
        }
        often = myDictionary[0, 0];
        for(int i=tmpIndex-1; i>0; i--)
        {
            WriteLine("{0} [{1} {2}] , {3} [{4} {5}]",i,myDictionary[i, 0], myDictionary[i, 1], i-1 ,myDictionary[i - 1, 0], myDictionary[i - 1, 1]);
            //durlrk answp
            if (myDictionary[i,1].Equals(myDictionary[i-1,1]))
            {
                if(i.Equals(1))
                {
                    often = myDictionary[1, 0];
                    break;
                }
            }
            else
            {
                if (i.Equals(cnt - 1))
                {
                    often = myDictionary[i, 0];
                    break;

                }
                else
                {
                    often = myDictionary[i + 1, 0];
                    break;
                }
            }
        }
        sb.AppendFormat("{0}\n{1}\n{2}\n{3}", arith, middle, often, len);
        Write(sb);

        ReadLine();
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        program.Solution();
    }
}