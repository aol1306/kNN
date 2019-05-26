using System;
using System.Collections.Generic;
using System.Text;

namespace kNN
{
    public class DistanceClass : IComparable<DistanceClass>
    {
        public char classification;
        public double distance;

        public DistanceClass(char classification, double distance)
        {
            this.classification = classification;
            this.distance = distance;
        }
        public int CompareTo(DistanceClass other)
        {
            if (this.distance > other.distance) return 1;
            if (this.distance == other.distance) return 0;
            return -1;
        }
    }
}
