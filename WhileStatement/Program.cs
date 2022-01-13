using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This is a very simple While Statement, it evaluates the variable num. If num is less than 20 (which it is) then increment.
             */
            int num;
            num = 1;

            while (num < 20)
            {
                Console.WriteLine(num++);
            }
            Console.ReadLine();
        }
    }
}
