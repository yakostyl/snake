﻿using System;
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
            int x1 = 5;
            int y1 = 7;
            char sym1 = '*';
            sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 7;
            int y2 = 66;
            char sym2 = '#';
            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        private static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
