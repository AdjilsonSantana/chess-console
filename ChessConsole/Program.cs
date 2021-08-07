using System;
using Boards;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board b = new Board(8, 8);

                b.InsertPiece(new King(Color.Black, b), new Position(5, 1));
                b.InsertPiece(new King(Color.Black, b), new Position(5, 1));

                Screen.PrintBoard(b);
            }
            catch (BoardException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}
