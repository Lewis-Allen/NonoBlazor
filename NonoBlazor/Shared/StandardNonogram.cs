using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NonoBlazor.Shared
{
    public class StandardNonogram
    {
        public int ID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<List<int>> RowValues { get; set; }
        public List<List<int>> ColumnValues { get; set; }

        [NotMapped]
        public StandardNonogramCell[][] CellRows { get; set; }

        [NotMapped]
        public StandardNonogramCell[][] CellColumns { get; set; }

        [NotMapped]
        public bool HasWon { get; set; } = false;

        [NotMapped]
        private bool Initialized = false;

        public void Initialize()
        {
            CellRows = new StandardNonogramCell[Height][];
            CellColumns = new StandardNonogramCell[Width][];

            for(var i = 0; i < CellRows.Length; i++)
            {
                CellRows[i] = new StandardNonogramCell[Width];
            }

            for(var i = 0; i < CellColumns.Length; i++)
            {
                CellColumns[i] = new StandardNonogramCell[Height];
            }

            for(var x = 0; x < CellRows.Length; x++)
            {
                for(var y = 0; y < CellRows[x].Length; y++)
                {
                    var cell = new StandardNonogramCell();
                    CellRows[y][x] = cell;
                    CellColumns[x][y] = cell;
                }
            }

            Initialized = true;
        }

        public void CheckForWin()
        {
            if (!Initialized)
                throw new Exception("Nonogram has not been initialized. Call Initialize() first.");

            for (int i = 0; i < CellRows.Length; i++)
            {
                if (!ValidateLine(RowValues[i], CellRows[i]))
                {
                    HasWon = false;
                    return;
                }
            }

            for (int i = 0; i < CellColumns.Length; i++)
            {
                if (!ValidateLine(ColumnValues[i], CellColumns[i]))
                {
                    HasWon = false;
                    return;
                }
            }

            HasWon = true;
        }

        private bool ValidateLine(List<int> headerValues, StandardNonogramCell[] cells)
        {
            string cellstring = string.Join("", cells.Select(c => c.MarkedFilled ? "1" : "0").ToList());

            string[] blocks = cellstring.Split("0", StringSplitOptions.RemoveEmptyEntries);

            if (blocks.Length != headerValues.Count)
            {
                return false;
            }

            for (int i = 0; i < headerValues.Count; i++)
            {
                int blockCount = headerValues[i];

                if (blocks[i].Length != blockCount)
                    return false;
            }

            return true;
        }
    }
}
