using MonkeyTricks.MonkeyModel;
using MonkeyTricks.TrickModel;
using MonkeyTricks.Tricks;
using System;


namespace MonkeyTricks.SpectatorModel
{
    public class Spectator: IObserver
    {
        public string Name { get; set; }
        public Spectator(string name)
        {
            Name = name;
        }

        public void Update(Monkey observable, ITrick trickInprogress) => ReactToTrick(observable, trickInprogress);
        public void ReactToTrick(Monkey observable, ITrick trickInProgress)
        {
            if (trickInProgress is MusicalTrick)
            {
                Applaude(observable, trickInProgress);
            } else if(trickInProgress is AcrobaticTrick) {
                Whistle(observable, trickInProgress);
            }
        }
        public void Applaude(Monkey observable, ITrick trickInProgress)
        {
            Console.WriteLine(Name + " applaudit pendant " 
                + trickInProgress.ToString() + " de " 
                + observable.ToString() + "\n");
        }
        public void Whistle(Monkey observable, ITrick trickInProgress)
        {
            Console.WriteLine(Name + " siffle pendant " 
                + trickInProgress.ToString() + " de " 
                + observable.ToString() + "\n");
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
