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

        internal Die(Type type, IList<Face> faces)
        {
            Type = type;
            Faces = faces;
        }
    }
}