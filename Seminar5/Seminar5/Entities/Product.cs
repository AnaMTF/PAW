using System;

namespace Seminar5.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFoodItem { get; set; }
        public double NetPrice { get; set; }
        public int VAT
        {
            get
            {
                //if (IsFoodItem)
                //{
                //    return 5;
                //}
                //else
                //{
                //    return 19;
                //}
                return IsFoodItem ? 5 : 19;
            }
        }
        public double GrossPrice
        {
            get
            {
                return NetPrice * (1 + VAT / 100);
            }
        }

    }
}
