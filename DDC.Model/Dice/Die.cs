using System.Collections.Generic;
using System.Linq;

namespace DDC.Model.Dice
{
    public class Die
    {
        public Type Type { get; private set; }
        public IList<Face> Faces { get; private set; }

        public bool CanMiss
        {
            get { return Faces.Any(f => f.IsMiss); }
        }

        public double MissProbabiliy
        {
            get { return CanMiss ? 1 / 6d : 0; }
        }

        public double AverageRange
        {
            get { return Faces.Sum(f => f.Range) / 6d; }
        }

        public double AverageHearts
        {
            get { return Faces.Sum(f => f.Hearts) / 6d; }
        }

        public double AverageSurges
        {
            get { return Faces.Sum(f => f.Surges) / 6d; }
        }

        public double AverageShields
        {
            get { return Faces.Sum(f => f.Shields) / 6d; }
        }

        internal Die(Type type, IList<Face> faces)
        {
            Type = type;
            Faces = faces;
        }
    }
}