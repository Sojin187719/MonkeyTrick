using MonkeyTricks.TrickModel;
using System;



namespace MonkeyTricks.MonkeyModel
{
    public class Monkey: Observable
    {
        public string Name { get; set; }
        public TrickList Tricks { get; set; }


        public Monkey(string name)
        {
            Name = name;
            Tricks = new TrickList();
        }

        public void ExecuteOrder()
        {
            foreach(ITrick trick in Tricks.GetTricks())
            {
                Console.WriteLine("Le singe " + this.Name + " réalise " + trick.ToString());
                Notify(this, trick);
            }
        }
        public override string ToString()
        {
            return Name;    
        }
    }
}
