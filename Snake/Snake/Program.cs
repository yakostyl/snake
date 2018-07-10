using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;
            char sym1;
            x1 = 5;
            y1 = 7;
            sym1 = '*';
            Draw(x1, y1, sym1);

            Console.ReadLine();
        }

        private static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
