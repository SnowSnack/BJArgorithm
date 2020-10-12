using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void dfs(int[][] _a, bool[] _c, int _v, bool _flag, StringBuilder _sb)
    {
        Stack<int> stack = new Stack<int>();
        int n = _a.Length - 1;

        stack.Push(_v);
        _c[_v] = true;
        _sb.Append(_v + " ");

        while (!stack.Equals(default))
        {
            int vv = stack.Peek();
            _flag = false;
            for (int i = 1; i <= n; i++)
            {
                if (_a[vv][i] == 1 && !_c[i])
                {
                    stack.Push(i);
                    _sb.Append(i + " ");
                    _c[i] = true;
                    _flag = true;
                    break;
                }
            }
            if (!_flag)
            {
                stack.Pop();
            }
        }
    }

    public void Solution(int _num,int _cnt, int _prevNum, StringBuilder _sb)
    {
        if(_cnt>=0)
        {
            for (int i = 1; i < _num + 1; i++)
            {
                Solution(_num, _cnt - 1, i, _sb);

                if (_prevNum.Equals(-1))
                {

                }
                else if (_prevNum.Equals(i))
                {
                    return;
                }
                else
                {
                    if (_cnt.Equals(0))
                        _sb.AppendFormat("{0} {1}\n", _prevNum, i);
                    _sb.AppendFormat("{0} ", _prevNum);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        BufferedStream bsI = new BufferedStream(Console.OpenStandardInput());
        StreamReader sr = new StreamReader(bsI);
        BufferedStream bsO = new BufferedStream(Console.OpenStandardOutput());
        StreamWriter sw = new StreamWriter(bsO);

        sw.AutoFlush = true;
        Console.SetOut(sw);

        int[] inputs = sr.ReadLine().Split().Select(a => int.Parse(a)).ToArray();

        Program pg = new Program();
        pg.Solution(inputs[0], inputs[1], -1, sb);

        sw.Write(sb);
    }
}