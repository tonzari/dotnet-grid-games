using System;
using System.Collections.Generic;

namespace GridBasedGames
{
    class Grid
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public Cell[,] Cells { get; set; }

        public Grid(int columnCount, int rowCount)
        {
            ColumnCount = columnCount;
            RowCount = rowCount;
            Cells = new Cell[ColumnCount, RowCount];
        }

        public void Init()
        {
            for (int row = RowCount - 1; row >= 0; row--)
            {
                for (int column = 0; column < ColumnCount; column++)
                {
                    Cells[column, row] = new Cell(new Vector2(column, row));
                }
            }
        }

        public void Print()
        {
            for (int y = Cells.GetLength(0) - 1; y >= 0; y--)
            {
                for (int x = 0; x < Cells.GetLength(1); x++)
                {
                    Console.Write($" {Cells[x,y].CurrentCharacters} ");
                }

                Console.WriteLine("");
            }
        }

        public void DisplayGameObject(GameObject go)
        {
            Vector2 position = go.Position;
            int height = go.ArtMatrix.GetLength(0);
            int width = go.ArtMatrix.GetLength(1);

            for (int artRow = 0; artRow < height; artRow++)
            {
                for (int artColumn = 0; artColumn < width; artColumn++)
                {
                    Cells[(int)position.X + artRow, (int)position.Y + width - 1 - artColumn].CurrentCharacters = go.ArtMatrix[artColumn, artRow];
                }
            }

        }
    }
}
