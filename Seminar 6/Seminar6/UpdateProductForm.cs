using Seminar6.Entities;
using Seminar6.Repositories;
using System;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class UpdateProductForm : Form
    {
        private ProductRepository _productRepository;
        private Product _product;

        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            //instantiate repository
            _productRepository = new ProductRepository(); 
            _product = product; //ca sa retinem val parametrului
            
            //populate form with product data
            nameTextBox.Text = product.Name;
            descriptionRichTextBox.Text = product.Description;
            netPriceTextBox.Text = product.NetPrice.ToString();
            isFoodItemCheckBox.Checked = product.IsFoodItem;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //construct product based on input values
            
            
            _product.Name = nameTextBox.Text;
            _product.Description = descriptionRichTextBox.Text;
            _product.IsFoodItem = isFoodItemCheckBox.Checked;

            if (!double.TryParse(netPriceTextBox.Text, out var netPrice))
                throw new FormatException("Net price is not in a correct format");

            _product.NetPrice = netPrice;

            //save product
            _productRepository.UpdateProduct(_product);            

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
