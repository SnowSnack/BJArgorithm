using System;
using static System.Console;
using System.Text;

class Program
{

    public char[,] Init(int _max)
    {
        char[,] mat = new char[_max, _max];
        
        for(int i=0; i<_max; i++)
        {
            for(int j=0; j<_max; j++)
            {
                mat[j, i] = ' ';
            }
        }
        return mat;
    }

    public void FillStar(ref char[,]_mat, int _x, int _y, int _DrawSize)
    {
        if(_DrawSize.Equals(1))
        {
            _mat[_x, _y] = '*';
            return;
        }

        int nextDrawSize = _DrawSize / 3;


        for(int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                int nextX = _x + j * nextDrawSize;
                int nextY = _y + i * nextDrawSize;
                if(i.Equals(1)&&j.Equals(1))
                {
                    
                }
                else
                {
                    FillStar(ref _mat, nextX, nextY, nextDrawSize);
                }
            }
        }

    }

    public void Solution()
    {
        int input = int.Parse(ReadLine());

        char[,] mat = Init(input);
        StringBuilder sb = new StringBuilder();

        FillStar(ref mat, 0, 0, input);
        
        for(int i=0; i<input; i++)
        {
            for(int j=0; j<input; j++)
            {
                sb.Append(mat[j, i]);
            }
            sb.AppendLine();
        }
        WriteLine(sb);
    }

    public static void Main()
    {
        Program program = new Program();
        program.Solution();
    }
}