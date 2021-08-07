
namespace ChessConsole.Boards
{
    class Position
    {
        //Properties
        public int Line { get; set; }
        public int Column { get; set; }

        //Constructors
        public Position(int line, int column)
        {
            Line = line;
            Column = column;
        }

        //Methods
        public override string ToString()
        {
            return $"{Line}, {Column}";
        }
    }
}
