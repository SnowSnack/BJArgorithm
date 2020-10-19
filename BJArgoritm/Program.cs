using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void dfs2(bool[,] _array, bool[] _visited, int _startVertex,int _len, StringBuilder _sb)
    {
        _visited[_startVertex] = true;
        _sb.Append(_startVertex + " ");
        for (int i = 1; i < _len; i++)
        {
            if (_array[_startVertex,i].Equals(true) && !_visited[i])
            {
                dfs2(_array, _visited, i,_len, _sb);
            }
        }
    }

    public static void dfs(bool[,] _array, bool[] _visited, int _startVertex, int _len, bool _flag, StringBuilder _sb)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(_startVertex);
        _visited[_startVertex] = true;
        _sb.Append(_startVertex + " ");

        while (!(stack.Count==0))
        {
            int root = stack.Peek();
            _flag = false;

            for (int i = 1; i < _len; i++)
            {
                if (_array[root,i].Equals(true) && !_visited[i])
                {
                    _sb.AppendFormat("{0} {1} {2}",root, i,_array[root,i]);
                    stack.Push(i);
                    _sb.Append(i + " ");
                    _visited[i] = true;
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

    public void MyDFS(ref int _len, StringBuilder _sb)
    {
            
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
        //int first = 10, s = 7;
        int toLength = 0;
        
        //int[] toOutput = new int[first];

        //for(int i=0; i<first; i++)
        //{
        //    toOutput[i] = 0;
        //}

        //bool[] b = new bool[first];
        bool flag = false;
        //dfs2(toOutput, b, 1, first, sb);
        
        

        Program pg = new Program();
        for(int i=0; i<inputs[0]; i++)
        {
            pg.MyDFS(ref toLength, sb);
        }
        
        //pg.Solution(inputs[0], inputs[1], -1, sb);

        sw.Write(sb);
    }
}