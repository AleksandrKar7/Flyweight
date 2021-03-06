﻿
using ET_1_ChessBoard.Flyweights;
using static ET_1_ChessBoard.Cell;

namespace ET_1_ChessBoard.Logics.Boards
{
    public class Board
    {
        private Cell[,] cells;
        private FlyweightFactory factory;
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public Cell this[int row, int column]
        {
            get
            {
                return cells[row, column];
            }
            set
            {
                cells[row, column] = value;
            }
        }


        public Board(int numberOfRows, int numberOfColumns)
        {
            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
            factory = new FlyweightFactory(
                new Flyweight(CellColor.White)
                , new Flyweight(CellColor.Black));
        }

        public virtual void InitCells()
        {
            int x = 0;
            int y = 0;
            bool isNextWhite = true;

            cells = new Cell[NumberOfRows, NumberOfColumns];
            while (y <= cells.GetLength(1))
            {
                if (x < cells.GetLength(0) && y == cells.GetLength(1))
                {
                    x++;
                    y = 0;
                }
                if (x == cells.GetLength(0))
                {
                    break;
                }

                if (x % 2 == 1 && y == 0)
                {
                    cells[x, y] = new Cell(x, y,
                        factory.GetFlyweight(new Flyweight(CellColor.Black)));
                    isNextWhite = true;
                    y++;
                }
                else if (x % 2 == 0 && y == 0)
                {
                    cells[x, y] = new Cell(x, y,
                        factory.GetFlyweight(new Flyweight(CellColor.White)));
                    isNextWhite = false;
                    y++;
                }

                if (isNextWhite)
                {
                    cells[x, y] = new Cell(x, y,
                        factory.GetFlyweight(new Flyweight(CellColor.White)));
                    isNextWhite = false;
                }
                else
                {
                    cells[x, y] = new Cell(x, y,
                        factory.GetFlyweight(new Flyweight(CellColor.Black)));
                    isNextWhite = true;
                }
                y++;
            }
        }
    }
}
