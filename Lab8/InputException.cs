using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
    class InputException : Exception
    {
        public InputException(string message)
            : base(message)
        {

        }
        public InputException()
        : base("\n Your choice isn't correct!")
        {

        }
    }

}
