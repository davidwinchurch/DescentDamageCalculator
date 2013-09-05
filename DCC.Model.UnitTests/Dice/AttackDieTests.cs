using DDC.Model.Dice;
using NUnit.Framework;

namespace DCC.Model.UnitTests.Dice
{
    [TestFixture]
    public class BlueAttackDieTests : AttackDieTests
    {
        public BlueAttackDieTests() : base(DieFactory.BlueAttack, 1/6d, 20/6d, 8/6d, 2/6d) { }
    }

    [TestFixture]
    public class YellowAttackDieTests : AttackDieTests
    {
        public YellowAttackDieTests() : base(DieFactory.YellowAttack, 0, 4/6d, 7/6d, 3/6d) { }
    }

    [TestFixture]
    public class RedAttackDieTests : AttackDieTests
    {
        public RedAttackDieTests() : base(DieFactory.RedAttack, 0, 0, 13/6d, 1/6d) { }
    }

    public abstract class AttackDieTests
    {
        private readonly Die _testDie;
        private readonly double _missProbability;
        private readonly double _averageRange;
        private readonly double _averageHearts;
        private readonly double _averageSurges;

        protected AttackDieTests(Die testDie, double missProbability, double averageRange, double averageHearts, double averageSurges)
        {
            _testDie = testDie;
            _missProbability = missProbability;
            _averageRange = averageRange;
            _averageHearts = averageHearts;
            _averageSurges = averageSurges;
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
    }
}