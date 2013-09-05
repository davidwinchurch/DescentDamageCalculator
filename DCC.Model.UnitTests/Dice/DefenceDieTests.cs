using DDC.Model.Dice;
using NUnit.Framework;

namespace DCC.Model.UnitTests.Dice
{
    [TestFixture]
    public class BrownDefenceDieTests : DefenceDieTests
    {
        public BrownDefenceDieTests() : base(DieFactory.BrownDefence, 4/6d) { }
    }

    [TestFixture]
    public class GreyDefenceDieTests : DefenceDieTests
    {
        public GreyDefenceDieTests() : base(DieFactory.GreyDefence, 8 / 6d) { }
    }

    [TestFixture]
    public class BlackDefenceDieTests : DefenceDieTests
    {
        public BlackDefenceDieTests() : base(DieFactory.BlackDefence, 13 / 6d) { }
    }

    public abstract class DefenceDieTests
    {
        private readonly Die _testDie;
        private readonly double _averageShields;

        protected DefenceDieTests(Die testDie, double averageShields)
        {
            _testDie = testDie;
            _averageShields = averageShields;
        }

        [Test]
        public void AverageShields()
        {
            Assert.That(_testDie.AverageShields, Is.EqualTo(_averageShields));
        }
    }
}