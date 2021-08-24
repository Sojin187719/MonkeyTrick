using MonkeyTricks.TrickModel;

namespace MonkeyTricks.Tricks
{
    public class MusicalTrick : ITrick
    {
        public string Name { get; set; }

        public MusicalTrick(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "le tour de musique " + "'" + this.Name + "'";
        }
    }
}