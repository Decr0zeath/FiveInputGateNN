using System;

namespace FiveInputGateNN
{
    public class NeuralNetwork
    {
        private readonly double[] andWeights = new double[5];
        private readonly double[] orWeights = new double[5];
        private double andBias;
        private double orBias;
        private readonly double learningRate = 0.1;
        private readonly IGate andGate;
        private readonly IGate orGate;

        public NeuralNetwork(IGate andGate, IGate orGate)
        {
            this.andGate = andGate;
            this.orGate = orGate;
            InitializeWeights();
        }

        // Initialize weights randomly
        private void InitializeWeights()
        {
            Random rnd = new Random();
            for (int i = 0; i < andWeights.Length; i++)
            {
                andWeights[i] = rnd.NextDouble() - 0.5;
                orWeights[i] = rnd.NextDouble() - 0.5;
            }
            andBias = rnd.NextDouble() - 0.5;
            orBias = rnd.NextDouble() - 0.5;
        }

        // Sigmoid activation function
        private double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        // Predict the output based on inputs
        public (double, double) Predict(int[] input)
        {
            double andSum = andBias;
            double orSum = orBias;

            for (int i = 0; i < 5; i++)
            {
                andSum += andWeights[i] * input[i];
                orSum += orWeights[i] * input[i];
            }

            double andOutput = Sigmoid(andSum);
            double orOutput = Sigmoid(orSum);

            return (andOutput, orOutput);
        }

        // Train the model (gradient descent)
        public void Train(int[] input, int targetAnd, int targetOr)
        {
            var (andOutput, orOutput) = Predict(input);

            double errorAnd = targetAnd - andOutput;
            double errorOr = targetOr - orOutput;

            for (int j = 0; j < 5; j++)
            {
                andWeights[j] += learningRate * errorAnd * input[j];
                orWeights[j] += learningRate * errorOr * input[j];
            }

            andBias += learningRate * errorAnd;
            orBias += learningRate * errorOr;
        }
    }
}
