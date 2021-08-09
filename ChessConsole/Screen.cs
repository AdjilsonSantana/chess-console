using System;
using Boards;

namespace ChessConsole
{
    class Screen
    {
        //Properties 

        //Constructors 


        //Methods
        public static void PrintBoard(Board board)
        {
            for (int i =0; i < board.Lines; i++)
            {
                Console.Write(board.Lines-i + " ");

                for (int j = 0; j <board.Columns; j++)
                {
                    if (board.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(i,j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }
    }
}
