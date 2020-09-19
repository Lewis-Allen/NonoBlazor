using System;
using System.Collections.Generic;
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
    }
}
