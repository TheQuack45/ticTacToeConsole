﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board testBoard = new Board();

            Console.WriteLine(testBoard[0]);

            Console.ReadKey();
        }
    }
}
