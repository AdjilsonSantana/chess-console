//Class which converts the screen position of the board to the system chessposition

using Boards;

namespace Chess
{
    class ChessPosition
    {
        //Properties 
        public char Column { get; set; }
        public int Line { get; set; }

        //Constructors
        public ChessPosition(char column, int line)
        {
            Column = column;
            Line = line;
        }

        //Methods

        public Position ToPosition()
        {
            return new Position(8 - Line, Column - 'a');
        }

        public override string ToString()
        {
            return ""+ Column + Line;
        }


    }
}
