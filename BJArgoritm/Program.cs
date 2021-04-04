using System;
using System.Linq;
using System.Text;
using System.IO;
class Program
{
    int[] board;
    int cnt;
    int len;
    StringBuilder sb;
    public void Queen(int _qCnt)
    {
        bool possible;
        if (_qCnt.Equals(len))
        {
            cnt++;
            return;
        }
        else
        {
            for (int hrzt = 0; hrzt < len; hrzt++)
            {
                possible = true;
                for (int vtc = 0; vtc < _qCnt; vtc++)
                {
                    if (vtc.Equals(hrzt) || (Math.Abs(_qCnt - vtc)).Equals(Math.Abs(hrzt - board[vtc])))
                    {
                        possible = false;
                        break;
                    }
                }
                if (possible)
                {
                    board[_qCnt] = hrzt;
                    Queen(_qCnt+1);
                }
            }
        }
    }

    public void Solution()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        sb = new StringBuilder();

        len = int.Parse(sr.ReadLine());

        cnt = 0;
        board = new int [len];

        Queen(0);

        sb.Append(cnt);

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
        sb.Clear();
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        p.Solution();
    }
}