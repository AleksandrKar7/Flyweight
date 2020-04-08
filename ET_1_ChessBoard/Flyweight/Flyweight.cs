using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard.Flyweights
{
    public class Flyweight
    {
        public Cell _sharedState { get; }

        public Flyweight(Cell cell)
        {
            this._sharedState = cell;
        }

        public void Operation(Cell uniqueState)
        {
            Console.WriteLine($"Flyweight: Displaying state.");
        }
    }
}
