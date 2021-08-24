using System;


namespace MonkeyTricks.Exceptions
{
    class TrickListEmptyException : Exception
    {
        public TrickListEmptyException() {
            
        }
        public TrickListEmptyException(string name) : base(String.Format(name + " doesn't know any tricks")) 
        { 
        }
    }
}
