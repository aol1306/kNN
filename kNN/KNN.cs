using System;
using System.Collections.Generic;
using System.Text;

namespace kNN
{
    public class KNN
    {
        private List<TrainingData> trainingData;
        private int k;

        /// <summary>
        /// K-NN constructor
        /// </summary>
        /// <param name="trainingData">Data used for classification</param>
        /// <param name="k">k parameter (how many nearest points take part in voting)</param>
        public KNN(List<TrainingData> trainingData, int k)
        {
            this.trainingData = trainingData;
            this.k = k;
        }

        public List<DistanceClass> CalculateDistances(List<double> sample)
        {
            var ret = new List<DistanceClass>(trainingData.Count);
            foreach (TrainingData training in trainingData)
            {
                ret.Add(new DistanceClass(training.classification, EuclideanDistance(training.inputs, sample)));
            }
            return ret;
        }

        public char Classify(List<double> sample)
        {
            // calculate distances to all training items
            var distances = CalculateDistances(sample);
            // sort distances from nearest to farthest
            distances.Sort();
            // scan k-nearest items, use a vote to determine the result
            var nearest = distances.GetRange(0, k);
            return Vote(nearest);
        }

        public static char Vote(List<DistanceClass> distances)
        {
            var voteCount = new Dictionary<char, int>();
            foreach (DistanceClass distance in distances)
            {
                if(voteCount.ContainsKey(distance.classification))
                {
                    voteCount[distance.classification]++;
                } else
                {
                    voteCount.Add(distance.classification, 1);
                }
            }

            char maxClassification = 'M';
            int maxVotes = 0;
            foreach (KeyValuePair<char, int> entry in voteCount)
            {
                if (entry.Value > maxVotes)
                {
                    maxVotes = entry.Value;
                    maxClassification = entry.Key;
                }
            }
            return maxClassification;
        }

        public static double EuclideanDistance(List<double> a, List<double> b)
        {
            if (a.Count != b.Count)
            {
                throw new ArgumentException("Cannot calculate distance - dimentions do not match");
            }
            var distance = 0.0;
            for (int i = 0; i < a.Count; i++)
            {
                distance += Math.Pow(a[i] - b[i], 2);
            }
            return Math.Sqrt(distance);
        }
    }
}
