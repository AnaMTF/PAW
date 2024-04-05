using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1.Start
{
    internal class Program //e vizibil in mod public dar doar in assembly-ul respectiv
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var expression = Console.ReadLine();
            try
            {
                var result = calculator.Exectute(expression);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
