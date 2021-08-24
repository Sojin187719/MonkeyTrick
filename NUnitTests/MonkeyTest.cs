using MonkeyTricks.MonkeyModel;
using MonkeyTricks.TrickModel;
using MonkeyTricks.Tricks;
using NUnit.Framework;
using System;

namespace NUnitTests
{
    public class MonkeyTest
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ToString_ReturnsMonkeyName()
        {
            Monkey newMonkey = new Monkey("John");
            Assert.AreEqual(newMonkey.Name, "John");
        }
        [Test]
        public void ExecuteOrder_WriteInConsole()
        {
            var currentConsoleOut = Console.Out;
            Monkey testMonkey = new Monkey("Singe test");
            testMonkey.Tricks.AddTrick(new MusicalTrick("Nothing else matters"));
            testMonkey.ExecuteOrder();
            Assert.AreEqual(currentConsoleOut.ToString(), "Le singe Singe test réalise le tour musical 'Nothing else matters'");
        }
    }
}