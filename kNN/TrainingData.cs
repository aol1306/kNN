using System;
using System.Collections.Generic;
using System.Text;

namespace kNN
{
    public class TrainingData
    {
        public List<double> inputs;
        public char classification;

        public TrainingData(List<double> inputs, char classification)
        {
            this.inputs = inputs;
            this.classification = classification;
        }

        public static List<TrainingData> GenerateForNumbers()
        {
            var ret = new List<TrainingData>();
            ret.Add(new TrainingData(new List<double> {
                    0.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 1.0, 0.0}, '0'));
            ret.Add(new TrainingData(new List<double> {0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0 }, '1'));
            ret.Add(new TrainingData(new List<double> {  0.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 1.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 1.0}, '2'));
            ret.Add(new TrainingData(new List<double> { 1.0, 1.0, 1.0, 0.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 1.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 1.0, 1.0 }, '3'));
            ret.Add(new TrainingData(new List<double> {  1.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 1.0, 0.0,
                    1.0, 1.0, 1.0, 1.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0}, '4'));
            ret.Add(new TrainingData(new List<double> { 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 0.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 1.0, 0.0}, '5'));
            ret.Add(new TrainingData(new List<double> { 0.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 1.0, 1.0}, '6'));
            ret.Add(new TrainingData(new List<double> { 1.0, 1.0, 1.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 1.0, 0.0,
                    0.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0}, '7'));
            ret.Add(new TrainingData(new List<double>
            {
                    0.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 1.0, 0.0 }, '8'));
            ret.Add(new TrainingData(new List<double> { 0.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 1.0, 1.0,
                    0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 1.0, 0.0,
                    1.0, 1.0, 0.0, 0.0 }, '9'));

            return ret;
        }
    }

}
