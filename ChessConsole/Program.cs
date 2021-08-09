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
                Board board = new Board(8, 8);

                board.InsertPiece(new Tower(Color.White, board), new Position(1,1));
                board.InsertPiece(new Tower(Color.Black, board), new Position(7,7));

                Screen.PrintBoard(board);



            }
            catch (BoardException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}
