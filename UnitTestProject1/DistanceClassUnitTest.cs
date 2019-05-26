using Microsoft.VisualStudio.TestTools.UnitTesting;
using kNN;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class DistanceClassUnitTest
    {
        [TestMethod]
        public void DistanceClass_Sorting()
        {
            var l = new List<DistanceClass> {
                new DistanceClass('A', 15),
                new DistanceClass('B', 10),
                new DistanceClass('C', 1),
                new DistanceClass('D', 11)
            };

            l.Sort();

            Assert.AreEqual(1, l[0].distance);
            Assert.AreEqual(10, l[1].distance);
            Assert.AreEqual(11, l[2].distance);
            Assert.AreEqual(15, l[3].distance);
        }
    }
}