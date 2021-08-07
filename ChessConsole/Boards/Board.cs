
namespace Boards
{
    class Board
    {
        //Properties
        public int Lines { get; set; }
        public int Columns { get; set; }
        public Piece[,] Pieces  { get; set; }

        //Cosntructors
        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[lines,columns];
        }

    }
}
