using System;
using Boards;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Board b = new Board(8, 8);

            b.InsertPiece(new King(Color.Black,b), new Position(1, 1));

            Screen.PrintBoard(b);
        }
    }
}
