using MonkeyTricks.Tricks;
using MonkeyTricks.MonkeyModel;
using MonkeyTricks.TamerModel;
using MonkeyTricks.SpectatorModel;
using MonkeyTricks.TrickModel;

namespace MonkeyTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            ITrick playMetallica  = new MusicalTrick("jouer Nothing Else Matters de Metallica");
            ITrick playGNR = new MusicalTrick("jouer Sweet Child of mine de Guns'n'Roses");
            ITrick salto = new AcrobaticTrick("faire un salto");
            ITrick pirouette = new AcrobaticTrick("marcher sur les mainns");


            Monkey monkeyOne = new Monkey("Ronnnie");
            Monkey monkeyTwo = new Monkey("Radke");

            monkeyOne.Tricks.AddTrick(playMetallica);
            monkeyOne.Tricks.AddTrick(salto);
            monkeyTwo.Tricks.AddTrick(pirouette);
            monkeyTwo.Tricks.AddTrick(playGNR);

            Spectator spectator = new Spectator("Johny Cash");
            Tamer tamerOne = new Tamer("Dresseur 1", monkeyOne);
            Tamer tamerTwo = new Tamer("Dresseur 2", monkeyTwo);
            
            monkeyOne.Attach(spectator);
            tamerOne.ChargeToDoTricks();
        }
    }
}
