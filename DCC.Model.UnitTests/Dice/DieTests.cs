using DDC.Model.Dice;
using NUnit.Framework;

namespace DCC.Model.UnitTests.Dice
{
    [TestFixture]
    public class BlueAttackDieTests : DieTests
    {
        public BlueAttackDieTests() : base(DieFactory.BlueAttack, 1/6d, 20/6d, 8/6d, 2/6d, 0) { }
    }

    [TestFixture]
    public class YellowAttackDieTests : DieTests
    {
        public YellowAttackDieTests() : base(DieFactory.YellowAttack, 0, 4/6d, 7/6d, 3/6d, 0) { }
    }

    [TestFixture]
    public class RedAttackDieTests : DieTests
    {
        public RedAttackDieTests() : base(DieFactory.RedAttack, 0, 0, 13/6d, 1/6d, 0) { }
    }

    [TestFixture]
    public class BrownDefenceDieTests : DieTests
    {
        public BrownDefenceDieTests() : base(DieFactory.BrownDefence, 0, 0, 0, 0, 4/6d) { }
    }

    [TestFixture]
    public class GreyDefenceDieTests : DieTests
    {
        public GreyDefenceDieTests() : base(DieFactory.GreyDefence, 0, 0, 0, 0, 8 / 6d) { }
    }

    [TestFixture]
    public class BlackDefenceDieTests : DieTests
    {
        public BlackDefenceDieTests() : base(DieFactory.BlackDefence, 0, 0, 0, 0, 13 / 6d) { }
    }

    public abstract class DieTests
    {
        private readonly Die _testDie;
        private readonly double _missProbability;
        private readonly double _averageRange;
        private readonly double _averageHearts;
        private readonly double _averageSurges;
        private readonly double _averageShields;

        protected DieTests(Die testDie, double missProbability, double averageRange, double averageHearts, double averageSurges, double averageShields)
        {
            _testDie = testDie;
            _missProbability = missProbability;
            _averageRange = averageRange;
            _averageHearts = averageHearts;
            _averageSurges = averageSurges;
            _averageShields = averageShields;
        }

        [Test]
        public void MissProbabiliy()
        {
            Assert.That(_testDie.MissProbabiliy, Is.EqualTo(_missProbability));
        }

        [Test]
        public void AverageRange()
        {
            Assert.That(_testDie.AverageRange, Is.EqualTo(_averageRange));
        }

        [Test]
        public void AverageHearts()
        {
            Assert.That(_testDie.AverageHearts, Is.EqualTo(_averageHearts));
        }

        [Test]
        public void AverageSurges()
        {
            Assert.That(_testDie.AverageSurges, Is.EqualTo(_averageSurges));
        }

        [Test]
        public void AverageShields()
        {
            Assert.That(_testDie.AverageShields, Is.EqualTo(_averageShields));
        }
    }
}