using System;
using static System.Console;

class Program
{
    public int Factorial(short _num)
    {
        if (_num > 0)
            return Factorial((short) (_num - 1)) * _num;
        return 1;
    }
    public int Fivonacii(short _num)
    {
        if (_num > 1)
        {
            return Fivonacii((short) (_num - 1)) + Fivonacii((short) (_num - 2));
        }
        return _num;
    }

    void solve(ref char[,] _mat, int _y, int _x, int _num)
    {
        if (_num.Equals(1))
        {
            WriteLine("num = " + _num + " mat[{0}][{1}]", _y, _x);
            _mat[_y, _x] = '*';
            return;
        }

        int divTmp = _num / 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == 1 && j == 1)
                {
                    WriteLine("in if = num = " + _num + " mat[{0}][{1}]", _y + (i * divTmp), _x + (j * divTmp));
                }
                else
                    solve(ref _mat, _y + (i * divTmp), _x + (j * divTmp), divTmp);
            }
        }
    }


    public void Solution()
    {
        short input = short.Parse(ReadLine());
        char[,] mat = new char[2000, 2000];
        solve(ref mat, 0, 0, input);


        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Write(mat[i, j]);
            }
            WriteLine();
        }

    }