
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
            if (ExistPiece(position))
            {
                throw new BoardException("Position field! You can´t put 2 pieces in the same position ");
            }
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool ValidPosition(Position pos)
        {
            if (pos.Line <0 || pos.Line > Lines || pos.Column <0 || pos.Column > Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatingPosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException($"Invalid position. Available positions: 0 to {Lines}");
            }
        }

        public bool ExistPiece(Position pos)
        {
            ValidatingPosition(pos);
            return Piece(pos.Line,pos.Column) != null;
        }
    }
}
