using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Engine.Model
{
    class Piece
    {
        public PieceColor Color { get; set; }
        public PieceType Type { get; set; }

        Piece(PieceColor color, PieceType type)
        {
            Color = color;
            Type = type;
        }
    }

    enum PieceColor
    {
        White,
        Black
    }

    enum PieceType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }
}
