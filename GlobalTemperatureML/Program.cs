using Microsoft.ML.Forecasting.GlobalTemperature.Samples;
using System;

namespace Microsoft.ML.Forecasting.GlobalTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo with known temperatures: ");
            Console.WriteLine();

            new DemoPrediction().Run();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Demo for unknown temperatures and dates: ");

            // Run a prediction for future global temperatures in April
            // Year, Month
            new CustomPrediction().Header().Run(2020, 4);
            new CustomPrediction().Run(2030, 4);
            new CustomPrediction().Run(2040, 4);
            new CustomPrediction().Run(2050, 4);

            // Only close the console when pressing a key
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }

}