using System;
using System.Windows.Forms;

namespace FiveInputGateNN
{
    public partial class Form1 : Form
    {
        private NeuralNetwork neuralNetwork;

        public Form1()
        {
            InitializeComponent();
            neuralNetwork = new NeuralNetwork(new ANDGate(), new ORGate()); // Initialize with AND and OR gates
        }

        // Method to get input combination from the 5 textboxes
        private int[] GetInputCombination()
        {
            int[] input = new int[5];
            input[0] = Convert.ToInt32(cmbInput1.Text);
            input[1] = Convert.ToInt32(cmbInput2.Text);
            input[2] = Convert.ToInt32(cmbInput3.Text);
            input[3] = Convert.ToInt32(cmbInput4.Text);
            input[4] = Convert.ToInt32(cmbInput5.Text);
            return input;
        }

        // Button click to trigger the prediction
        private void btnPredict_Click(object sender, EventArgs e)
        {
            int[] input = GetInputCombination();
            var (andOutput, orOutput) = neuralNetwork.Predict(input);

            // Display the results on the labels
            lblANDResult.Text = $"AND Prediction: {(andOutput >= 0.5 ? 1 : 0)}";
            lblORResult.Text = $"OR Prediction: {(orOutput >= 0.5 ? 1 : 0)}";

            // Display thought process
            lblThoughtProcess.Text = $"AND Weighted Sum: {andOutput}\n" +
                                     $"OR Weighted Sum: {orOutput}";
        }

        // Button click to start training
        private void btnTrain_Click(object sender, EventArgs e)
        {
            int[] input = GetInputCombination();
            int targetAnd = new ANDGate().GetOutput(input);  // Target output based on AND gate
            int targetOr = new ORGate().GetOutput(input);    // Target output based on OR gate

            neuralNetwork.Train(input, targetAnd, targetOr);
            MessageBox.Show("Training completed!", "Neural Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
