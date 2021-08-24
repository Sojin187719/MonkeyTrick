using MonkeyTricks.MonkeyModel;

namespace MonkeyTricks.TamerModel
{
    public class Tamer
    {
        private Monkey Monkey { get; set; }
        public string Name { get; set; }

        public Tamer(string name, Monkey monkey)
        {
            Name = name;
            Monkey = monkey;
        }

        public void ChargeToDoTricks()
        {
            Monkey.ExecuteOrder();
        }
    }
}