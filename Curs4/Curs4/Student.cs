using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
    [Serializable]
    class Student 
    {
        private int varsta;
        private string nume;
        private float media;

        public Student(int varsta, string nume, float media)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.media = media;
        }


    }
}
