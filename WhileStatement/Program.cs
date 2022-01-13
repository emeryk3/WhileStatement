using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhileStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This is a very simple While Statement, it evaluates the variable num. If num is less than 20 (which it is) then increment.
             */

            /*
            int num;
            num = 1;

            while (num < 20)
            {
                Console.WriteLine(num++);
            }
            Console.ReadLine();
            */

            /* Breaking from Loops / Reading a text file:
             * It is easy to forget to break from loops, meaning the While Statement goes on and on. When breaking from loops you use the break keyword. Create a text file and save it on your desktop; make sure it has a few lines of text, a paragraph is fine. Then at the top where the using directives are, add the System.IO namespace: */

            string path = @"C:\Users\kizwi\source\repos\WhileStatement\c sharp test.txt";
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadToEnd();
            while (line != null)
            {
                Console.WriteLine(line);
                break;
            }
            Console.ReadLine();

        }
    }
}
