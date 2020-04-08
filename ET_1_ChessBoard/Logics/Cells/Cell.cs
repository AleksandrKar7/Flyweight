
using ET_1_ChessBoard.Flyweights;
using static ET_1_ChessBoard.Flyweights.Flyweight;

namespace ET_1_ChessBoard
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public enum CellColor
        {
            White = 1,
            Black = 2
        }

        public Flyweight Flyweight { get; set; }

        public Cell(int x, int y, Flyweight flyweight)
        {
            X = x;
            Y = y;
            Flyweight = flyweight;
        }

        //public static void DoSomething()
        //{
        //    System.Console.WriteLine();
        //}
    }
}
