using DDC.Model.Dice;
using NUnit.Framework;

namespace DCC.Model.UnitTests.Dice
{
    [TestFixture]
    public class BlueDieTests
    {
        private readonly Die _testDie = DieFactory.BlueAttack; 
        
        [Test]
        public void HitChance()
        {
            Assert.That(_testDie.MissProbabiliy, Is.EqualTo(1/6d));
        }

        [Test]
        public void AverageRange()
        {
            Assert.That(_testDie.AverageRange, Is.EqualTo(20/6d));
        }

        [Test]
        public void AverageHearts()
        {
            Assert.That(_testDie.AverageHearts, Is.EqualTo(8/6d));
        }

        [Test]
        public void AverageSurges()
        {
            Assert.That(_testDie.AverageSurges, Is.EqualTo(2/6d));
        }

        [Test]
        public void AverageShields()
        {
            Assert.That(_testDie.AverageShields, Is.EqualTo(0));
        }
    }
}