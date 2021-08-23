using System.Collections.Generic;


namespace MonkeyTricks.TrickModel
{
    public class TrickList
    {
        private IList<ITrick> Tricks { get; set; }
        public TrickList()
        {
            Tricks = new List<ITrick>();
        }
        public void AddTrick(ITrick newTrick)
        {
            if (Tricks.Contains(newTrick)) return;
            Tricks.Add(newTrick);
        }
        public IList<ITrick> GetTricks()
        {
            List<ITrick> TricksClone = new List<ITrick>();
            foreach (ITrick trick in Tricks)
            {
                TricksClone.Add(trick);
            }
            return TricksClone;
        }

    }
}
