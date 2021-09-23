using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            Square newSquare = (Square.At(currentPosition.Row + 2, currentPosition.Col + 1));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }
            newSquare = (Square.At(currentPosition.Row - 2, currentPosition.Col - 1));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }

            newSquare = (Square.At(currentPosition.Row + 1, currentPosition.Col + 2));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }
            newSquare = (Square.At(currentPosition.Row - 1, currentPosition.Col - 2));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }

            newSquare = (Square.At(currentPosition.Row - 1, currentPosition.Col + 2));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }
            newSquare = (Square.At(currentPosition.Row + 1, currentPosition.Col - 2));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }

            newSquare = (Square.At(currentPosition.Row - 2, currentPosition.Col + 1));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }
            newSquare = (Square.At(currentPosition.Row + 2, currentPosition.Col - 1));
            if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
            {
                availableSquares.Add(newSquare);
            }


            return availableSquares;

            
        }
    }
}