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
            int x1 = 1;
            int x2 = 3;
            char syml = '*';

            Drow(x1, x2, syml);
       

            int y1 =5;
            int y2 = 3;
            char syml2 = '#';

            Drow(y1, y2, syml2);
            Console.ReadLine();
        }
        static void Drow (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
            
        }
    }
}
