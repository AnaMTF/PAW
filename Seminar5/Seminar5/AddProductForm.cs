using Seminar5.DataBase;
using Seminar5.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class productNameForm : Form
    {
        private ProductRepository _productRepository = new ProductRepository();
        public productNameForm()
        {
            InitializeComponent();
     
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var product = new Entities.Product();
            product.Id = Guid.NewGuid();
            product.Name = nameTextBox.Text;
            product.Description = descriptionRichTextBox.Text;
            product.IsFoodItem = isFoodItemCheckBox.Checked;
            //product.NetPrice = Convert.ToDouble(netPriceTextBox.Text);
            //product.NetPrice = double.Parse(netPriceTextBox.Text);

            if(double.TryParse(netPriceTextBox.Text, out var netPrice))
            {
                product.NetPrice = netPrice;
            }
            else
            {
                throw new FormatException("Net price is not a valid number");
            }

            _productRepository.AddProduct(product);

       
            //nameTextBox.Text = string.Empty;
            //descriptionRichTextBox.Text = string.Empty;
            //isFoodItemCheckBox.Checked = false;
            //netPriceTextBox.Text = string.Empty;
            //nu ne mai trebuie pentru ca acum facem o instanta noua de form de fiecare data

            Close();  //inchidem form-ul

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
