using Seminar6.Database;
using Seminar6.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Seminar6.Repositories
{
    public class ProductRepository
    {
        public void AddProduct(Product product)
        {
            FakeDatabase.Products.Add(product);
        }

        public BindingList<Product> GetAllProducts()
        {
            return FakeDatabase.Products;
        }

        public void DeleteProduct(Product product)
        {
            FakeDatabase.Products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = FakeDatabase.Products.FirstOrDefault(x=> x.Id == product.Id); //cautam produsul in lista
            //FirstOrDefault returneaza primul element care indeplineste conditia sau null daca nu exista
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.NetPrice = product.NetPrice;
                existingProduct.IsFoodItem = product.IsFoodItem;

                FakeDatabase.Products.ResetBindings(); //cand alteram colectia dar nu si dimensiunea ei
            }
        }

        public void RefreshDataSource(List<Product> products)
        {
            FakeDatabase.Products.Clear();
            foreach (var product in products)
            {
                FakeDatabase.Products.Add(product);
            }
        }   
    }
}
