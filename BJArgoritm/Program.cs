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

        int[] nums = new int[cnt];
        int[] oftens;
        int often;
        int sum = 0;


        for (int i = 0; i < cnt; i++)
        {
            nums[i] = int.Parse(ReadLine());
            sum += nums[i];
        }

        Array.Sort(nums);
        int Arith = sum / cnt;
        int middleVa = nums[cnt / 2];
        int range = nums[cnt - 1] - nums[0];
        oftens = new int[nums[cnt - 1]];

        for (int i = 0; i < cnt; i++)
        {
            if (nums[i].Equals(0))
            {
                oftens[0]++;
            }
            else
            {
                break;
            }
        }

        for (int i=1; i<nums[cnt-1]; i++)
        {
            for(int j=oftens[i-1]-1; j<cnt; j++)
            {
                if(nums[j].Equals(i))
                {
                    oftens[i]++;
                }
                else 
                { 
                    break;
                }
            }
        }

        

    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}