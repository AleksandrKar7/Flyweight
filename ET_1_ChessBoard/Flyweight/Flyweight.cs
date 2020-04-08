
using static ET_1_ChessBoard.Cell;

namespace ET_1_ChessBoard.Flyweights
{
    public class Flyweight
    {
        public CellColor Color { get; set; }
        private int[] WeightingAgent = new int[10000];

        public Flyweight(CellColor color)
        {
            Color = color;
        }
    }
}
