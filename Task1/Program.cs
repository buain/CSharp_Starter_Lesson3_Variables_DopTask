using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 20;
            Console.WriteLine("первоначальный х = " + x);
            Console.WriteLine("первоначальный y = " + y);
            x += 5;
            Console.WriteLine("х увеличили на 5 = " + x);
            y = y + x;
            Console.WriteLine("к y прибавили х = " + y);
            int z = 25;
            int r = 4;
            z *= r;
            Console.WriteLine("z равно " + z);
            Console.ReadLine();
        }
    }
}
