using DDC.Model.Monsters;
using DDC.Model.Weapons;
using NUnit.Framework;

namespace DDC.Core.UnitTests
{
    [TestFixture]
    public class IronLongswordZombieTests
    {
        [Test]
        public void ActOneNoReroll()
        {
            //Arrange
            var monster = MonsterFactory.Zombie;
            var weapon = WeaponFactory.IronLongsword;
        }
    }
}