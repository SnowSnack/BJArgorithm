using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJArgoritm
{
    class Program
    {
        public void Solution()
        {
            int standard = int.Parse(Console.ReadLine());
            
            bool isTrue()
            {
                return ((standard <= 10000) && (standard >= 1));
            }

            while (!isTrue())
            {
                standard = int.Parse(Console.ReadLine());
            }

            int answer=0;
            for(int i=1; i<=standard; i++)
            {
                answer += i;
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        { 
            Program program = new Program();
            program.Solution();
        }
    }
}
