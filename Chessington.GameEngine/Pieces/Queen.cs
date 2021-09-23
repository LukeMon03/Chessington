using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();



            for (int i = 1; i < GameSettings.BoardSize; i++)
            {
                Square newSquare = (Square.At(currentPosition.Row + i, currentPosition.Col - i));
                if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
                {
                    availableSquares.Add(newSquare);
                }
                newSquare = (Square.At(currentPosition.Row + i, currentPosition.Col + i));
                if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
                {
                    availableSquares.Add(newSquare);
                }
                newSquare = (Square.At(currentPosition.Row - i, currentPosition.Col - i));
                if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
                {
                    availableSquares.Add(newSquare);
                }
                newSquare = (Square.At(currentPosition.Row - i, currentPosition.Col + i));
                if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
                {
                    availableSquares.Add(newSquare);
                }

            }

            // get available column moves
            for (int i = 0; i <= GameSettings.BoardSize; i++)
            {
                Square newSquare = (Square.At(i, currentPosition.Col));
                if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
                {
                    availableSquares.Add(newSquare);
                }
                newSquare = (Square.At(currentPosition.Row, i));
                if (newSquare.Row < 8 && newSquare.Row >= 0 && newSquare.Col < 8 && newSquare.Col >= 0)
                {
                    availableSquares.Add(newSquare);
                }

                
            }

            availableSquares.RemoveAll(s => s == Square.At(currentPosition.Row, currentPosition.Col));

            return availableSquares;

        }
    }
}