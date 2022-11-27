using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void GetProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            }) ;
            dgwProducts.DataSource= _productDal.GetAll();
            MessageBox.Show("Product Added!");
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitpriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),

            };
            _productDal.Update(product);
            GetProducts();
            tbxNameUpdate.Clear();
            tbxUnitpriceUpdate.Clear();
            tbxStockAmountUpdate.Clear();
            MessageBox.Show("Updated");

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitpriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
           var name= tbxSearch.Text.ToString();
            dgwProducts.DataSource = _productDal.Search(name);
                     
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            GetProducts();
        }
    }
}
