using Seminar02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var terrestrialExhibit = new TerrestrialExhibit(1);
            var mixedExhibit = new MixedExhibit(2);

            var zoo = new Zoo();
            zoo.AddExhibit(terrestrialExhibit);
            zoo.AddExhibit(mixedExhibit);

            zoo.Maintain();
            Console.ReadKey();

        }
    }
}
