﻿
namespace Boards
{
    class Piece
    {
        //Properties
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtMoviments { get; protected set; }
        public Board  Board { get; protected set; }

        //Construcors
        public Piece(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            QtMoviments = 0;
            Board = board;
        }

        
    }
}
