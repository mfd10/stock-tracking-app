using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop.products;
namespace oop
{
    public partial class AddUpdateForm : Form
    {
        public AddUpdateForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.Name = nameBox.Text;
            pro.Brand = brandBox.Text;
            pro.StokType = stockTypeBox.Text;
            pro.Item_Price = Convert.ToDouble(priceBox.Text);
            pro.Stock_Amount = Convert.ToDouble(stockAmountBox.Text);
            //TODO: combo box dairies not working 
            ExcelCRUD.InsertDataToExcel(comboBox1.Text, pro);
            MessageBox.Show(pro.Name + " succesfully added.");
        }
    }
}