using System;
using Boards;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p = new Position(2, 5);

            Board b = new Board(5, 5);

            Console.WriteLine(p);
            Console.WriteLine(b);
        }
    }
}
