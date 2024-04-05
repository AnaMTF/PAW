using Seminar02.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02.Models
{
    public sealed class MixedExhibit : Exhibit, IAquaticExhibit, ITerrestrialExhibit
    {
        public MixedExhibit(int number) : base(number)
        {
        }

        public void ChangeWater()
        {
            Console.WriteLine("Changing water on mixed exhibit");
        }

        public void CutGrass()
        {
            Console.WriteLine("Cutting grass on mixed exhibit");
        }

        public override void RunMaintenance()
        {
            CutGrass();
            ChangeWater();
        }
    }
}
