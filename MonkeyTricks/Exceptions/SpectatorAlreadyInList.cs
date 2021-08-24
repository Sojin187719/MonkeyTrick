using System;


namespace MonkeyTricks.Exceptions
{
    public class SpectatorAlreadyInList : Exception
    {
        public SpectatorAlreadyInList(string name) : base(String.Format(name + " is already present in the observers list"))
        {

        }
    }
}
