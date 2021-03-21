using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    enum Figure
    {
        none,
        whiteKing = 'K',
        whiteQueen = 'Q',
        whiteRook = 'R',
        whiteBishop = 'B',
        whiteKnight = 'N',
        whitePawn = 'P',
        
        blackKing = 'k',
        blackQueen = 'q',
        blackRook = 'r',
        blackBishop = 'b',
        blackKnight = 'n',
        blackPawn = 'p'
    }
    
    static class FigureMethods
    {
        public static Color getColor(this Figure figure)
        {
            if (Figure.none == figure)
                return Color.none;
            return (Figure.whiteKing == figure ||
                    Figure.whiteQueen == figure ||
                    Figure.whiteRook == figure ||
                    Figure.whiteBishop == figure ||
                    Figure.whiteKnight == figure ||
                    Figure.whitePawn == figure) ? Color.white : Color.black;
        }
    }
}
