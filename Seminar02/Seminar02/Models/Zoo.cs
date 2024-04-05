using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02.Models
{
    public sealed class Zoo
    {
        private List<Exhibit> _exhibits; //nu avem getter si setter ptc nu vrem sa putem modifica lista de la exterior
    
        public Zoo()
        {
            _exhibits = new List<Exhibit>();
        }
        
        public void AddExhibit(Exhibit exhibit)
        {
            if (_exhibits.Any(x => x.Number == exhibit.Number))//.Any() verifica daca lista are elemente
            {
                throw new ArgumentException("There is already an exhibit with that number");
            }

            _exhibits.Add(exhibit);
        }

        public void Maintain()
        {
            foreach (var exhibit in _exhibits)
            {
                Console.WriteLine($"=== EXHIBIT {exhibit.Number} ===");
                exhibit.RunMaintenance();
            }
        }
    }
}
