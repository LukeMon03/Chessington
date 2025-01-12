﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            

            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            for (int i = 0; i <= GameSettings.BoardSize; i++)
            {
                availableSquares.Add(Square.At(i, currentPosition.Col));
                availableSquares.Add(Square.At(currentPosition.Row, i));
            }

            return availableSquares;

        }
    }
}