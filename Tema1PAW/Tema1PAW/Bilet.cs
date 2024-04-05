using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1PAW
{
    internal class Bilet
    {
        public string categorie;
        public int stoc;
        
        public Bilet(string categorie, int stoc)
        {
            this.categorie = categorie;
            this.stoc = stoc;
        }

        public String Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public int Stoc
        {
            get { return stoc; }
            set { stoc = value; }
        }

    }
}
