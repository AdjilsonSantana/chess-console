
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

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        //go to the piece matrix and put the piece in the rigth position in the matriz,
        //After that give the piece the new position. 
        public void InsertPiece(Piece piece, Position position)
        {
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

    }
}
