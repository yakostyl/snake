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
            Console.SetBufferSize(120, 40);
            Console.SetWindowSize(120, 40);
            НоrizontalLine upLine = new НоrizontalLine(0, 100, 0, '=');         
         НоrizontalLine downLine = new НоrizontalLine(0, 100, 35, '_');
         VerticalLine leftLine = new VerticalLine(0, 0, 35, '|');
         VerticalLine rigthLine = new VerticalLine(100, 0, 35, '|');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();     
            rigthLine.Draw();
            Console.ReadLine();
        }

       
        
    }
}
