using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Program
    {

        //private static void OnValueChangedMethod(bool increased, int value)
        //{

        //} 
        static void Main(string[] args)
        {
            var processor = new Procesor(5);

            //primul mod
            //procesor.OnValueChanged = OnValueChangedMethod; //am asignat metoda OnValueChangedMethod la eventul OnValueChanged
            // al doilea mod cu fct anonima
            processor.OnValueChanged += (bool increased, int value) =>
            {
                var originalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(increased ? $"Increased\t\t {value}" : $"Decreased\t\t {value}");
                Console.ForegroundColor = originalColor;
            };

            processor.OnProcessingFinished += (int steps) =>
            {
                var originalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Processing finished in {steps} steps");
                Console.ForegroundColor = originalColor;
            };  //am asignat metoda OnProcessingFinished la eventul OnProcessingFinished

            processor.OnProcessingStarted += (int value, string message) =>
            {
                var originalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green; //e static si schimba pt toate 
                Console.WriteLine($"Processing started with value {value} and message {message}");
                Console.ForegroundColor = originalColor;
            };

            processor.Process();

            var processor2 = new Procesor(27);

            processor2.Process();

            Console.ReadKey();
        }
    }
}
