using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    class TextMemento
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }
    }
}
