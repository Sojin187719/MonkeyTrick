using MonkeyTricks.MonkeyModel;
using MonkeyTricks.Exceptions;
using NUnit.Framework;

namespace NUnitTests
{
    public class MonkeyTest
    {
        [Test]
        public void ToString_ReturnsMonkeyName()
        {
            Monkey newMonkey = new Monkey("John");
            Assert.AreEqual(newMonkey.Name, "John");
        }
        [Test]
        public void CheckIfTrickListIsEmpty_ExceptionExpected()
        {
            Monkey newMonkey = new Monkey("John");
            Assert.Throws<TrickListEmptyException>(() => newMonkey.CheckIfTrickListIsEmpty());
        }

    }
}