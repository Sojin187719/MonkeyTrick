using MonkeyTricks.Exceptions;
using MonkeyTricks.SpectatorModel;
using MonkeyTricks.TrickModel;
using System.Collections.Generic;

namespace MonkeyTricks.MonkeyModel
{
    public class Observable
    {
        private IList<Spectator> spectators;
        public Observable()
        {
            spectators = new List<Spectator>();
        }

        public void Attach(Spectator spectator)
        {
            CheckIfSpectatorExistsInList(spectator);
            spectators.Add(spectator);
        }
        public void CheckIfSpectatorExistsInList(Spectator spectator)
        {
            if (spectators.Contains(spectator))
                throw new SpectatorAlreadyInList(spectator.Name);
        }
        public void Detach(Spectator spectator) => spectators.Remove(spectator);
        public void Notify(Monkey observable, ITrick trickInProgress)
        {
            foreach(Spectator spectator in spectators)
            {
                spectator.Update(observable, trickInProgress);
            }
        }
    }
}
