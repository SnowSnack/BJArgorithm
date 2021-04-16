using System;
using System.Linq;
using System.Text;
using System.IO;
class Program
{
    int cnt;
    int[] board;
    StringBuilder sb;

    public void Set(bool _toSet, int y, int x, int l)
    {

    }

    public bool DigonalCheck(int _yDiffer, int _xDiffer)
    {
        return Math.Abs(_yDiffer).Equals(Math.Abs(_xDiffer));
    }

    public bool YCheck(int _px, int _cx)
    {
        return _px.Equals(_cx);
    }

    public void Queen(int _qCnt, int _bMax)
    {
        bool possible;
        if(_qCnt.Equals(_bMax))
        {
            cnt++;
            return;
        }
        else
        {
            for(int hrzt = 0; hrzt<_bMax; hrzt++)
            {
                possible = true;
                for(int vtc = 0; vtc<_qCnt; vtc++)
                {
                    if (YCheck(board[vtc], hrzt) || DigonalCheck(_qCnt - vtc,hrzt - board[vtc]))
                    {
                        possible = false;
                        break;
                    }
                }
                if(possible)
                {
                    board[_qCnt] = hrzt;
                    Queen(_qCnt + 1, _bMax);
                }
            }
        }
    }


    public void Solution()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        sb = new StringBuilder();

        int boardMax = int.Parse(sr.ReadLine());
        board = new int[boardMax];
        cnt = 0;

        Queen(0, boardMax);

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