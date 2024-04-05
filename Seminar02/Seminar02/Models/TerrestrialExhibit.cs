using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar02.Contracts;

namespace Seminar02.Models
{
    public sealed class TerrestrialExhibit : Exhibit, ITerrestrialExhibit
    {
        public TerrestrialExhibit(int number) : base(number)
        {
            
        }

        public void CutGrass()
        {
            Console.WriteLine("Cutting grass on terrestrial exhibit");
        }

        public override void RunMaintenance()
        {
            CutGrass();
        }
    }
}
