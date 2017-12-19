using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Engine.Model
{
    class Move
    {
        public Position StartPosition { get; set; }
        public Position EndPosition { get; set; }

        Move(Position startPos, Position endPos)
        {
            StartPosition = startPos;
            EndPosition = endPos;
        }
    }
}
