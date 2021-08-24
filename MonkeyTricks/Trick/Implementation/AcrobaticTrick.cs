namespace MonkeyTricks.TrickModel
{
    internal class AcrobaticTrick : ITrick
    {
        public string Name { get; set; }

        public AcrobaticTrick(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "le tour d'acrobatie " + "'" + this.Name + "'";
        }
    }
}