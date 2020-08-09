using System;
using static System.Console;
using System.Linq;

class Program
{
    public class Vector2
    {
        public int x;
        public int y;

        public Vector2(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int DistanceFomula(Vector2 _toCompare)
        {
            return (int)Math.Sqrt(x - _toCompare.x) + (int)Math.Sqrt(y - _toCompare.y);
        }
    }
    public void Solution()
    {
        int[] inputs = ReadLine().Split(' ').Select(a=>int.Parse(a)).ToArray();

        Vector2 pos = new Vector2(inputs[0], inputs[1]);

        int w = inputs[2];
        int h = inputs[3];


        int xDistance;
        int yDistance;
        int answer;
        if (pos.x <= w / 2)
        {
            xDistance = pos.x;
        }
        else
        {
            xDistance = w - pos.x;
        }
        if (pos.y <= h / 2)
        {
            yDistance = pos.y;
        }
        else
        {
            yDistance = h - pos.y;
        }

        if (xDistance < yDistance)
        {
            answer = xDistance;
        }
        else
        {
            answer = yDistance;
        }
            

        WriteLine(answer);

    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution();
        return;
    }
}