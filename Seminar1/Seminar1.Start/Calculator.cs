using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1.Start
{
    public class Calculator
    {
        public double Exectute(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                throw new ArgumentNullException("Expression is null or empty");

            if (!expression.Contains('+'))
                throw new ArgumentException("Expression does not contain +");

            var parts = expression.Split('+'); // ca la java. in js e independent de scop
            if (parts.Count() != 2)
                throw new ArgumentException("Expression is not valid");

            if (!(double.TryParse(parts[0].Trim(), out var operand1))) //out e un parametru trimis ca referinta nu ca valoare
                throw new ArgumentException("Operand 1 is invalid");

            if (!(double.TryParse(parts[1].Trim(), out var operand2))) //Trim() ne scapa de spatii
                throw new ArgumentException("Operand 2 is invalid");

            return operand1+ operand2;

        }
    }
}
