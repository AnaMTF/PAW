using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar5.Entities;

namespace Seminar5.DataBase
{
    public static class FakeDataBase
    {
        public static BindingList<Product> Products = new BindingList<Product>()
        {
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Notebook",
                Description = "80 files notebook",
                IsFoodItem = false,
                NetPrice = 10
            }
        };

    }
}
