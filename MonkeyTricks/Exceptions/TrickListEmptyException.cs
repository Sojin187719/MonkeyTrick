using System;

namespace MonkeyTricks.Exceptions
{
    public class TrickListEmptyException : Exception
    {
        public TrickListEmptyException()
        {
        }

        public TrickListEmptyException(string name) : base(String.Format(name + " ne connait aucun tour.\n"))
        { }
    }
}