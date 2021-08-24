using MonkeyTricks.MonkeyModel;
using MonkeyTricks.Exceptions;
using NUnit.Framework;
using MonkeyTricks.SpectatorModel;

namespace NUnitTests
{
    class ObservableTest
    {
        [Test]
        public void Attach_AddObserverToList()
        {
            Observable obs = new Observable();
            Spectator spec = new Spectator("Test");

            obs.Attach(spec);
            Assert.AreEqual(1, obs.Spectators.Count);
            Assert.AreEqual(obs.Spectators[0], spec);
        }
        [Test]
        public void Detach_RemoveObserverFromList()
        {
            Observable obs = new Observable();
            Spectator numberOne = new Spectator("number 1");
            Spectator numberTwo = new Spectator("number 2");
            obs.Spectators.Add(numberOne);
            obs.Spectators.Add(numberTwo);

            obs.Detach(numberOne);
            Assert.AreEqual(1, obs.Spectators.Count);
            Assert.AreEqual(obs.Spectators[0], numberTwo);
        }
        [Test]
        public void CheckIfSpectatorExistsInList_ExceptionExpected()
        {
            Observable obs = new Observable();
            Spectator spec = new Spectator("Test");
            obs.Spectators.Add(spec);
            Assert.Throws<SpectatorAlreadyInList>(() => obs.CheckIfSpectatorExistsInList(spec));
        }
    }
}
