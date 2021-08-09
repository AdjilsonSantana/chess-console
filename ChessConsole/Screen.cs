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
                        Screen.PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color== Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor c = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = c;
            }
        }
    }
}
