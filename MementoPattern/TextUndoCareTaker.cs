using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    class TextUndoCareTaker
    {
        private Stack<TextMemento> _mementos;

        public TextUndoCareTaker()
        {
            _mementos = new Stack<TextMemento>();
        }

        public TextMemento TextMemento
        {
            get
            {
                return _mementos.Pop();
            }
            set
            {
                _mementos.Push(value);
            }
        }
    }
}
