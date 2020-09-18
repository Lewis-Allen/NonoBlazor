﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NonoBlazor.Shared
{
    public class StandardNonogram
    {
        public int ID { get; set; }
        public Guid PublicID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string RowValues { get; set; }
        public string ColumnValues { get; set; }
    }
}
