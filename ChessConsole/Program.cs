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
                ChessPosition c = new ChessPosition('a', 1);

                Console.WriteLine(c.ToPosition());
            }
            catch (BoardException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}
