﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NonoBlazor.Shared
{
    public class StandardNonogram
    {
        public int StandardNonogramID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<string> RowValues { get; set; }
        public List<string> ColumnValues { get; set; }
    }
}
