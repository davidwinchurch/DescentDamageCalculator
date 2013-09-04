using System.Collections.Generic;
using System.Linq;

namespace DDC.Model.Dice
{
    public class DieFactory
    {
        public static readonly Die BlueAttack = new Die(Type.BlueAttack, new[]
            {
                FaceFactory.GetAttackFace(3, 2, 0),
                FaceFactory.GetAttackFace(2, 2, 1),
                FaceFactory.GetAttackFace(4, 2, 0),
                FaceFactory.GetAttackFace(6, 1, 1),
                FaceFactory.GetMissFace(),
                FaceFactory.GetAttackFace(5, 1, 0)
            });

        public static readonly Die YellowAttack = new Die(Type.YellowAttack, new[]
            {
                FaceFactory.GetAttackFace(0, 1, 1),
                FaceFactory.GetAttackFace(0, 2, 1),
                FaceFactory.GetAttackFace(0, 2, 0),
                FaceFactory.GetAttackFace(1, 1, 0),
                FaceFactory.GetAttackFace(1, 0, 1),
                FaceFactory.GetAttackFace(2, 1, 0)
            });

        public static readonly Die RedAttack = new Die(Type.YellowAttack, new[]
            {
                FaceFactory.GetAttackFace(0, 3, 0),
                FaceFactory.GetAttackFace(0, 1, 0),
                FaceFactory.GetAttackFace(0, 2, 0),
                FaceFactory.GetAttackFace(0, 2, 0),
                FaceFactory.GetAttackFace(0, 3, 1),
                FaceFactory.GetAttackFace(0, 2, 0)
            });

        public static readonly Die BrownDefence = new Die(Type.BrownDefence, new[]
            {
                FaceFactory.GetDefenceFace(1),
                FaceFactory.GetDefenceFace(0),
                FaceFactory.GetDefenceFace(2),
                FaceFactory.GetDefenceFace(1),
                FaceFactory.GetDefenceFace(0),
                FaceFactory.GetDefenceFace(0)
            });

        public static readonly Die GreyDefence = new Die(Type.GreyDefence, new[]
            {
                FaceFactory.GetDefenceFace(1),
                FaceFactory.GetDefenceFace(0),
                FaceFactory.GetDefenceFace(3),
                FaceFactory.GetDefenceFace(1),
                FaceFactory.GetDefenceFace(2),
                FaceFactory.GetDefenceFace(1)
            });

        public static readonly Die BlackDefence = new Die(Type.BlackDefence, new[]
            {
                FaceFactory.GetDefenceFace(2),
                FaceFactory.GetDefenceFace(0),
                FaceFactory.GetDefenceFace(3),
                FaceFactory.GetDefenceFace(2),
                FaceFactory.GetDefenceFace(4),
                FaceFactory.GetDefenceFace(2)
            });

        private static readonly Dictionary<Type, Die> Dice = new Dictionary<Type, Die>
            {
                { Type.BlueAttack, BlueAttack },
                { Type.YellowAttack, YellowAttack },
                { Type.RedAttack, RedAttack },
                { Type.BrownDefence, BrownDefence },
                { Type.GreyDefence, GreyDefence },
                { Type.BlackDefence, BlackDefence },
            }; 

        public static IList<Die> CreateDice(params Type[] dieTypes)
        {
            return dieTypes.Select(dt => Dice[dt]).ToArray();
        }
    }
}