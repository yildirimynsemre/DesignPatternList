using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    class TextOriginator
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }

        private TextUndoCareTaker _textCareTaker;

        public TextOriginator()
        {
            _textCareTaker = new TextUndoCareTaker();
        }

        // Anlık kayıt değerlerini UML diyagramındaki CareTaker üzerinden yığına eklemektedir.
        public void Save()
        {
            _textCareTaker.TextMemento = new TextMemento
            {
                CursorPosition = this.CursorPosition,
                Text = this.Text
            };
        }

        public void Undo()
        {
            TextMemento previousTextMemento = _textCareTaker.TextMemento;

            CursorPosition = previousTextMemento.CursorPosition;
            Text = previousTextMemento.Text;
        }

        public override string ToString()
        {
            return $"text: {Text}, cursor position: {CursorPosition}";
        }
    }
}
