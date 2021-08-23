using MonkeyTricks.TrickModel;


namespace MonkeyTricks.Tricks
{
    class MusicalTrick : ITrick
    {
        public string Name { get; set; }

        public MusicalTrick(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "le tour d'acrobatie " + "'" + this.Name + "'";
        }
    }
}
