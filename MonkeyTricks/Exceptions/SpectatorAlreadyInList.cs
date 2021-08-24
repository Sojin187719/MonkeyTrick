using System;

namespace MonkeyTricks.Exceptions
{
    public class SpectatorAlreadyInList : Exception
    {
        public SpectatorAlreadyInList()
        {
        }

        public SpectatorAlreadyInList(string name) : base(String.Format(name + " est déjà présent dans la liste d'observers.\n"))
        {
        }
    }
}