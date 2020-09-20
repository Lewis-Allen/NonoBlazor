using System;
using System.Collections.Generic;
using System.Text;

namespace NonoBlazor.Shared
{
    public class StandardNonogramCell
    {
        public bool MarkedFilled { get; set; } = false;
        public bool MarkedEmpty { get; set; } = false;

        public void FlipMarkedFilled()
        {
            if (!MarkedEmpty)
                MarkedFilled = !MarkedFilled;
        }

        public void FlipMarkedEmpty()
        {
            if (!MarkedFilled)
                MarkedEmpty = !MarkedEmpty;
        }
    }
}
