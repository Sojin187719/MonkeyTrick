using MonkeyTricks.Exceptions;
using MonkeyTricks.TrickModel;
using System;



namespace MonkeyTricks.MonkeyModel
{
    public class Monkey : Observable
    {
        public static readonly int MINIMUM_OF_TRICKS_IN_LIST = 0;
        public string Name { get; set; }
        public TrickList Tricks { get; set; }


        public Monkey(string name)
        {
            Name = name;
            Tricks = new TrickList();
        }

        public void ExecuteOrder()
        {
            CheckIfTrickListIsEmpty();
            foreach (ITrick trick in Tricks.GetTricks())
            {
                Console.WriteLine("Le singe " + this.Name + " réalise " + trick.ToString());
                Notify(this, trick);
            }
        }
        public void CheckIfTrickListIsEmpty()
        {
            if (Tricks.GetTricks().Count <= MINIMUM_OF_TRICKS_IN_LIST)
                throw new TrickListEmptyException(Name);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
