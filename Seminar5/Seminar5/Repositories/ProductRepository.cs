using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar5.Entities;
using Seminar5.DataBase;
using System.ComponentModel;

namespace Seminar5.Repositories
{
    public class ProductRepository
    {
        public void AddProduct(Product product)
        {
            if(FakeDataBase.Products.Any(p => p.Name == product.Name))
            {
                throw new InvalidOperationException("Product with the same name already exists");
            }
            FakeDataBase.Products.Add(product);
        }

        public BindingList<Product> GetAllProducts()
        {
            return FakeDataBase.Products;
        }

        public void DeleteProduct(Product product)
        {
            FakeDataBase.Products.Remove(product);
        }
    }
}
