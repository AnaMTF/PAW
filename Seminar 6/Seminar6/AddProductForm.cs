using Seminar6.Entities;
using Seminar6.Repositories;
using System;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class AddProductForm : Form
    {
        private ProductRepository _productRepository;

        public AddProductForm()
        {
            InitializeComponent();
            //instantiate repository
            _productRepository = new ProductRepository();            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //construct product based on input values
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = nameTextBox.Text;
            product.Description = descriptionRichTextBox.Text;
            product.IsFoodItem = isFoodItemCheckBox.Checked;

            if (!double.TryParse(netPriceTextBox.Text, out var netPrice))
                throw new FormatException("Net price is not in a correct format");

            product.NetPrice = netPrice;

            //save product
            _productRepository.AddProduct(product);            

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
