using Boards;

namespace Chess
{
    class Tower : Piece
    {
        //Constructors
        public Tower(Color color, Board board) : base(color, board)
        {
        }

        //Methods
        public override string ToString()
        {
            return "T";
        }
    }
}