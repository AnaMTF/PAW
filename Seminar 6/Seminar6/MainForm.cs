using Seminar6.Entities;
using Seminar6.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class MainForm : Form
    {
        private ProductRepository _productRepository = new ProductRepository();

        public MainForm()
        {
            InitializeComponent();

            productsDataGridView.DataSource = _productRepository.GetAllProducts();
            productsDataGridView.AutoGenerateColumns = true;

            CreateButtonColumn("Delete product", "Delete", "DeleteColumn");
            CreateButtonColumn("Edit product", "Edit", "EditColumn");            
        }

        private void CreateButtonColumn(string headerText, string buttonText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;

            productsDataGridView.Columns.Add(column);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            var product = (Product)grid.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "DeleteColumn")
            {
                var result = MessageBox.Show($"Are you sure you want to delete {product.Name}?",
                    "Please confirm your action",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    _productRepository.DeleteProduct(product);
                }

            }
            if (columnName == "EditColumn")
            {
                var updateProductForm = new UpdateProductForm(product);
                updateProductForm.ShowDialog();
            }
        }

        private void exportBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
            var result = saveFileDialog.ShowDialog();
            var fileName = saveFileDialog.FileName;
            var data = _productRepository.GetAllProducts().ToList();

            using(var fileStream = new FileStream(fileName, FileMode.OpenOrCreate)) //ca un try cu resurse in java
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, data);

                MessageBox.Show("Data serialized successfully");
            }
        }

        private void importBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin";
            var result = openFileDialog.ShowDialog();
            var fileName = openFileDialog.FileName;

            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                var data = (List<Product>)binaryFormatter.Deserialize(fileStream);

                _productRepository.RefreshDataSource(data); //pt deserializare
                MessageBox.Show("Data deserialized successfully");
            }
        }
    }
}
