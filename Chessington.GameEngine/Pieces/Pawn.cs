using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            
            // find current location
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();



            if (Player == Player.White)
            {
                 // figure out if its their first move
                 if (currentPosition.Row == 6)
                 {

                    // put that square in list
                    availableSquares.Add(Square.At(currentPosition.Row - 2, currentPosition.Col));
                    
                 }
                 
            // put that square in list
            availableSquares.Add(Square.At(currentPosition.Row - 1, currentPosition.Col));
                 
                
                
            }

            else
            {
                // figure out if its their first move
                if (currentPosition.Row == 1)
                { 
                    
                    // put that square in list
                    availableSquares.Add(Square.At(currentPosition.Row + 2, currentPosition.Col));
                    
                }
                // else would mean that its moved from its first position
                
               
  
            // put that square in list
            availableSquares.Add(Square.At(currentPosition.Row + 1, currentPosition.Col));
                

            }


            return availableSquares;
        }


    }
}
