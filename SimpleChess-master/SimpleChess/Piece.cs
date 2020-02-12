using System;

namespace SimpleChess
{
    public abstract class Piece
    {
        public string Symbol { get; }
            public string Type;

            protected Piece(string type, string symbol)
            {
                Type = type;
                Symbol = symbol;
            }


            public abstract bool Move(string fromPosition, string toPosition);
        }
    }

