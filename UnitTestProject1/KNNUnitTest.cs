using Microsoft.VisualStudio.TestTools.UnitTesting;
using kNN;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class KNNUnitTest
    {
        public KNN kNN;

        public KNNUnitTest()
        {
            var trainingData = new List<TrainingData>
            {
                new TrainingData(new List<double> {1.0, 0.0}, 'A'),
                new TrainingData(new List<double> {2.0, 0.0}, 'A'),
                new TrainingData(new List<double> {0.0, 1.0}, 'B'),
                new TrainingData(new List<double> {0.0, 2.0}, 'B')
            };

            kNN = new KNN(trainingData, 3);
        }

        [TestMethod]
        public void Distances_ForAllTraining()
        {
            var result = kNN.CalculateDistances(new List<double> { 0.0, 0.0 });
            var expected = new List<double> { 1.0, 2.0, 1.0, 2.0 };
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i].distance);
            }
        }

        [TestMethod]
        public void Classification_SimpleTestSet()
        {
            var classificationA = kNN.Classify(new List<double> { 3.0, 0.0 });
            Assert.AreEqual('A', classificationA);
            var classificationB = kNN.Classify(new List<double> { 0.5, 1.5 });
            Assert.AreEqual('B', classificationB);
        }

        /* STATIC METHODS TESTS */

        [TestMethod]
        public void VoteCheck()
        {
            var l = new List<DistanceClass>
            {
                new DistanceClass('A', 3),
                new DistanceClass('B', 10),
                new DistanceClass('C', 30),
                new DistanceClass('D', 6)
            };

            Assert.AreEqual('A', KNN.Vote(l));
        }

        [TestMethod]
        public void EuclideanDistance_2dim()
        {
            Assert.AreEqual(1, KNN.EuclideanDistance(new List<double> { 1.0, 1.0 }, new List<double> { 0.0, 1.0 }));
        }
    }
}
