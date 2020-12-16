using System;
using System.Diagnostics;
using BeeldHerkenning1ML.Model;
namespace BeeldHerkening1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to analyse whether a wolf or car is in a picture?");
            String varAnswer = Console.ReadLine();
            while (varAnswer.ToLower() == "yes")
            {
                Debug.WriteLine(" Object is not valid for this category.");
                // Add input data
                var input = new ModelInput();
                Console.WriteLine("What image do you want to analyse? Please specify its path:");
                String imagePath = Console.ReadLine();
                input.ImageSource = imagePath;

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Debug.WriteLine(result.Prediction);
                Console.WriteLine(result.Prediction);

                Console.WriteLine("Do you want to analyse another picture?");
                varAnswer = Console.ReadLine();

            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
