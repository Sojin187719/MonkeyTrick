using MonkeyTricks.MonkeyModel;
using MonkeyTricks.SpectatorModel;
using MonkeyTricks.TamerModel;
using MonkeyTricks.TrickModel;
using MonkeyTricks.Tricks;
using System;

namespace MonkeyTricks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Setting up requierments for the main scenario
            ITrick playMetallica = new MusicalTrick("jouer Nothing Else Matters de Metallica");
            ITrick playGNR = new MusicalTrick("jouer Sweet Child of mine de Guns'n'Roses");
            ITrick salto = new AcrobaticTrick("faire un salto");
            ITrick pirouette = new AcrobaticTrick("marcher sur les mainns");

            Monkey monkeyOne = new Monkey("Singe 1");
            Monkey monkeyTwo = new Monkey("Singe 2");

            monkeyOne.Tricks.AddTrick(playMetallica);
            monkeyOne.Tricks.AddTrick(salto);
            monkeyTwo.Tricks.AddTrick(pirouette);
            monkeyTwo.Tricks.AddTrick(playGNR);

            Spectator spectator = new Spectator("Johny Cash");
            Tamer tamerOne = new Tamer("Dresseur 1", monkeyOne);
            Tamer tamerTwo = new Tamer("Dresseur 2", monkeyTwo);

            //Scenario
            Console.WriteLine(spectator.ToString() + " croise deux dresseurs de singes et s'arrête pour regarder le spectacle.\n");
            monkeyOne.Attach(spectator);
            monkeyTwo.Attach(spectator);
            tamerOne.ChargeToDoTricks();
            tamerTwo.ChargeToDoTricks();
            monkeyOne.Detach(spectator);
            monkeyTwo.Detach(spectator);
        }
    }
}