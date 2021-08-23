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
            if (spectators.Contains(spectator)) return;
            spectators.Add(spectator);
        }
        public void Detach(Spectator spectator)
        {
            spectators.Remove(spectator);
        }
        public void Notify(Monkey observable, ITrick trickInProgress)
        {
            foreach(Spectator spectator in spectators)
            {
                spectator.Update(observable, trickInProgress);
            }
        }
    }
}
