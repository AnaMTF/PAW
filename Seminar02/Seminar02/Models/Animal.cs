namespace Seminar02.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }  //daca e public e obligatoriu sa inceapa cu litera mare
                                          //private string _name; //private deci incepe cu _ si cu litera mica

        public Animal(string name) //ctor shortcut pt constructor
        {
            Name = name;
            //_name = name;
        }
    }
}
