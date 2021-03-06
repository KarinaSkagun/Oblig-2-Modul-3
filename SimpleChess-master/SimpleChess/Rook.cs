﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    internal class Rook : Piece
    {
        public Rook(string type, string symbol) : base(type, symbol)
        {
            symbol = "TRN";
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}
