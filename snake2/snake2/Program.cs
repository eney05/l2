using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym = '*';
            Drav(x1, y1, sym);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Drav(x2, y2, sym2);

            Console.ReadLine();

        }

        static void Drav (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
