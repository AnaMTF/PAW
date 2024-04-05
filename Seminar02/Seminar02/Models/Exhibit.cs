using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02.Models
{
    public abstract class Exhibit
    {
        public int Number { get; set; }
        public List<Animal> Animals { get; set; }

        public Exhibit(int number)
        {
            Number = number;
        }

        public abstract void RunMaintenance();
    }
}
