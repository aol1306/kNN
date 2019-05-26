using System;

namespace kNN
{
    class Program
    {
        static void Main(string[] args)
        {
            // This test does not make much sense, but at least it proves the code works
            var knn = new KNN(TrainingData.GenerateForNumbers(), 2);

            foreach (TrainingData training in TrainingData.GenerateForNumbers())
            {
                Console.WriteLine(String.Format("Expected: {0}, Got: {1}", training.classification, knn.Classify(training.inputs)));
            }
        }
    }
}
