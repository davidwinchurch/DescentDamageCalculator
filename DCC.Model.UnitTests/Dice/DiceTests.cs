using DDC.Model.Dice;
using NUnit.Framework;

namespace DCC.Model.UnitTests.Dice
{
    [TestFixture]
    public class AttackBlueYellowDiceTests
    {
        private readonly DiceCalculator _dice = DieFactory.AttackBlueYellow;

        [TestCase(0, 5/6d)]
        [TestCase(1, 5/6d)]
        [TestCase(2, 5/6d)]
        [TestCase(3, 4/6d)]
        [TestCase(4, 3/6d)]
        [TestCase(5, 2/6d)]
        [TestCase(6, 1/6d)]
        public void HitProbability(int range, double expectedProbability)
        {
            Assert.That(_dice.GetHitProbability(range), Is.EqualTo(expectedProbability));
        }
    }
}