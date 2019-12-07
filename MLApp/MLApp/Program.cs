using System;
using MLAppML.Model;

namespace MLApp
{
    class Program
    {
        static void Main()
        {
            // Add input data
            var input = new ModelInput();
            input.SentimentText = "That is rude.";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction} with score {result.Score}");
            Console.ReadKey();
        }
    }
}
