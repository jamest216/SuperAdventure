using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class MessageEventArgs : EventArgs
    {
        /// <summary>
        /// message prompt
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// adds a new line
        /// </summary>
        public bool AddExtraNewLine { get; private set; }

        public MessageEventArgs(string message, bool a)
        {
            Message = message;
            AddExtraNewLine = a;
        }
    }
}
