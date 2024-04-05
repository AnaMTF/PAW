using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Procesor
    {
        private int _value;
        public int _steps;

        private delegate int Operation();

        public delegate void ValueChanged(bool increased, int value); //delegate 
        public event ValueChanged OnValueChanged; //event de tipul delegatului de mai sus

        public delegate void ProcessingFinished(int steps);
        public event ProcessingFinished OnProcessingFinished;

        //public event Action OnProcessingStarted; //event de tipul delegatului Action void fara parametri
        public event Action<int, string> OnProcessingStarted; //<int, string> generice => parametrii eventului
        public Procesor(int value)
        {
            _value = value;
            
        }

        private int Decrease()
        {
            var result = _value / 2;
            OnValueChanged?.Invoke(false, result); //result este variabila intermediara care va fi trimisa ca parametru la event
            //verifica daca e null -> ? , daca nu e invoca eventul
            return result;
        }

        private int Increase()
        {
            var result = _value * 3 +1;
            OnValueChanged?.Invoke(true, result);
            return result;
        }

        public void Process()
        {
            OnProcessingStarted?.Invoke(_value, "Starting processing");

            var initial = _value;
            Operation operation;

            while (_value > 1)
            {
                if (_value % 2 == 0)
                {
                    //_value = Decrease();
                    operation = Decrease; //am asignat adresa functiei Decrease
                }
                else
                {
                   // _value = Increase();
                   operation = Increase;  //am asignat adresa functiei Increase
                }

                _value = operation(); //am apelat functia din pointer prin intermediul delegatului

                _steps ++;

                if(_value == initial)
                {
                    break;
                    //you ve reached the impossible
                }
            }

            OnProcessingFinished?.Invoke(_steps);
        }
    }
}
