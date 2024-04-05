using System;

// atribut de namespace
namespace Seminar6.Entities
{
    [Serializable] //atribut de clasa
    public class Product 
    {
        //[Required] //atribut de proprietate
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double NetPrice { get; set; }
        public bool IsFoodItem { get; set; }
        public int VAT
        {
            get
            {
                return IsFoodItem ? 5 : 19;
            }
        }
        public double GrossPrice
        {
            get
            {
                return NetPrice + NetPrice * VAT / 100;
            }
        }
    }
}
