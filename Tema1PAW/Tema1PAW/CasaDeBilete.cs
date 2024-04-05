using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1PAW
{
    internal class CasaDeBilete
    {
        private Bilet[] bilete;


        public void SuplimentareBilete(string categorieBilete, int numarBilete)
        {
            if(categorieBilete == "Categorie1")
            {
                bilete[0].Stoc += numarBilete;
            }
            else if(categorieBilete == "Categorie2")
            {
                bilete[1].Stoc += numarBilete;
            }
            else if(categorieBilete == "Categorie3")
            {
                bilete[2].Stoc += numarBilete;
            }
            else
            {
                Console.WriteLine("Categorie inexistenta");
            }
        }

    }
}
