using MonkeyTricks.Exceptions;
using MonkeyTricks.SpectatorModel;
using MonkeyTricks.TrickModel;
using System;
using System.Collections.Generic;

namespace MonkeyTricks.MonkeyModel
{
    public class Observable
    {
        public IList<Spectator> Spectators { get; set; }

        public Observable()
        {
            Spectators = new List<Spectator>();
        }

        public void Attach(Spectator spectator)
        {
            try
            {
                CheckIfSpectatorExistsInList(spectator);
            }
            catch (SpectatorAlreadyInList ex)
            {
                Console.WriteLine(ex.Message);
            }

            Spectators.Add(spectator);
        }

        public void CheckIfSpectatorExistsInList(Spectator spectator)
        {
            if (Spectators.Contains(spectator))
                throw new SpectatorAlreadyInList(spectator.Name);
        }

        public void Detach(Spectator spectator) => Spectators.Remove(spectator);

        public void Notify(Monkey observable, ITrick trickInProgress)
        {
            foreach (Spectator spectator in Spectators)
            {
                spectator.Update(observable, trickInProgress);
            }
        }
    }
}