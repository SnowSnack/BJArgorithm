using System;
using static System.Console;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

class Program
{
    char ChangeFloor(char _toChange, ref int _count)
    {
        _count++;
        if (_toChange.Equals('W'))
            return 'B';
        else
            return 'W';
    }

    void Solution()
    {
        int[] count = ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

        int n = count[0];
        int m = count[1];

        int cntW = 0;
        int cntB = 0;

        char[][] map = new char[n][];

        for (int i = 0; i < n; i++)
        {
            map[i] = ReadLine().ToCharArray();
        }

        for (int i=0; i<n; i++)
        {
            for(int j=0; j<m; j++)
            {
                if(((j+i)%2).Equals(0))
                {
                    if(map[i][j].Equals('W'))
                    {
                        cntW++;
                    }
                    else if (map[i][j].Equals('B'))
                    {
                        cntB++;
                    }

                }
                else if(((j+i) % 2).Equals(1))
                {
                    if (map[i][j].Equals('B'))
                    {
                        cntW++;
                    }
                    else if(map[i][j].Equals('W'))
                    {
                        cntB++;
                    }
                }
            }
        }
        if (cntW >= cntB)
            Write(cntB);
        else
            Write(cntW);
    }

    
    
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
    }
}