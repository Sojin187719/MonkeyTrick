using MonkeyTricks.MonkeyModel;
using MonkeyTricks.TrickModel;


namespace MonkeyTricks.SpectatorModel
{
    interface IObserver
    {
        public void Update(Monkey observable, ITrick trickInprogress);
    }
}
