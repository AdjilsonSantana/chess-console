using Boards;

namespace Chess
{
    class King : Piece
    {
        //Constructors
        public King(Color color, Board board) : base(color, board)
        {
        }

        //Methods
        public override string ToString()
        {
            return  "R";
        }
    }
}
