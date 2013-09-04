using System.Collections.Generic;
using System.Linq;

namespace DDC.Core.Model.Die
{
    public class Die
    {
        public static readonly Die BlueAttack = new Die(Type.BlueAttack, new[]
            {
                Face.GetAttackFace(3, 2, 0),
                Face.GetAttackFace(2, 2, 1),
                Face.GetAttackFace(4, 2, 0),
                Face.GetAttackFace(6, 1, 1),
                Face.GetMissFace(),
                Face.GetAttackFace(5, 1, 0)
            });

        public static readonly Die YellowAttack = new Die(Type.YellowAttack, new[]
            {
                Face.GetAttackFace(0, 1, 1),
                Face.GetAttackFace(0, 2, 1),
                Face.GetAttackFace(0, 2, 0),
                Face.GetAttackFace(1, 1, 0),
                Face.GetAttackFace(1, 0, 1),
                Face.GetAttackFace(2, 1, 0)
            });

        public static readonly Die RedAttack = new Die(Type.YellowAttack, new[]
            {
                Face.GetAttackFace(0, 3, 0),
                Face.GetAttackFace(0, 1, 0),
                Face.GetAttackFace(0, 2, 0),
                Face.GetAttackFace(0, 2, 0),
                Face.GetAttackFace(0, 3, 1),
                Face.GetAttackFace(0, 2, 0)
            });

        public static readonly Die BrownDefence = new Die(Type.BrownDefence, new[]
            {
                Face.GetDefenceFace(1),
                Face.GetDefenceFace(0),
                Face.GetDefenceFace(2),
                Face.GetDefenceFace(1),
                Face.GetDefenceFace(0),
                Face.GetDefenceFace(0)
            });

        public static readonly Die GreyDefence = new Die(Type.GreyDefence, new[]
            {
                Face.GetDefenceFace(1),
                Face.GetDefenceFace(0),
                Face.GetDefenceFace(3),
                Face.GetDefenceFace(1),
                Face.GetDefenceFace(2),
                Face.GetDefenceFace(1)
            });

        public static readonly Die BlackDefence = new Die(Type.BlackDefence, new[]
            {
                Face.GetDefenceFace(2),
                Face.GetDefenceFace(0),
                Face.GetDefenceFace(3),
                Face.GetDefenceFace(2),
                Face.GetDefenceFace(4),
                Face.GetDefenceFace(2)
            });

        public Type Type { get; private set; }
        public IList<Face> Faces { get; private set; }

        public bool CanMiss
        {
            get { return Faces.Any(f => f.IsMiss); }
        }

        public double MissProbabiliy
        {
            get { return CanMiss ? 1d/6 : 0; }
        }

        public double AverageRange
        {
            get { return 6d/Faces.Sum(f => f.Range); }
        }

        public double AverageHearts
        {
            get { return 6d/Faces.Sum(f => f.Hearts); }
        }

        public double AverageSurges
        {
            get { return 6d/Faces.Sum(f => f.Surges); }
        }

        public double AverageShields
        {
            get { return 6d/Faces.Sum(f => f.Shields); }
        }

        private Die(Type type, IList<Face> faces)
        {
            Type = type;
            Faces = faces;
        }
    }
}