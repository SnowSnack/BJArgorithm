using System;
using static System.Console;
using System.Text;

namespace _191009_backjoon_hanoi
{
    class Program
    {
        static void Hanoi(StringBuilder _sb, int _disks, int _from, int _to)
        {
            if (_disks.Equals(0))
                return;

            int spare = 6 - _from - _to;

            Hanoi(_sb, _disks - 1, _from, spare);
            _sb.AppendFormat("{0} {1}\n", _from, _to);
            Hanoi(_sb, _disks - 1, spare, _to);
        }

        static void Main(string[] args)
        {
            int disks = int.Parse(ReadLine());
            StringBuilder sb = new StringBuilder((Math.Pow(2,disks)-1).ToString()+"\n");
            Hanoi(sb, disks, 1, 3);
            WriteLine(sb);
        }
    }
}