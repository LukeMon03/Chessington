using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            // find current location
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();


            
            for (int i =  1; i < GameSettings.BoardSize; i++)
            {
                Square newSquare = (Square.At(currentPosition.Row + i,currentPosition.Col - i));
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
            return availableSquares;
        }
    }
}