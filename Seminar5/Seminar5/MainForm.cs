using Seminar5.Entities;
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

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProductForm = new productNameForm(); //initializam o instanta de form
            addProductForm.ShowDialog(); //afisam form-ul (blocheaza executia codului urmator)
            //addProductForm.Show(); nu blocheaza executia codului urmator

            MessageBox.Show("Am inchis formul"); //apare dupa showdialog si simultan cu show
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

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name; //asociem indexul coloanei cu numele ei

            var product = (Product)grid.Rows[e.RowIndex].DataBoundItem;
            if(columnName=="DeleteColumn")
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
            if(columnName == "EditColumn")
            {
                //edit
            }
        }
    }
}
