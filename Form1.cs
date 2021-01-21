using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private ArrayList list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            resultBox.Text = "0";
            list = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Fruits");
        }
        private void button3_Click(object sender, EventArgs e)
        {

            double res = Convert.ToDouble(resultBox.Text);

            if (res > 20)
            {
                MessageBox.Show("Insufficent Fund!");
            }
            else
            {
                reminderBox.Text = (20 - res).ToString();
            }
        }

        private void crudBtn_Click(object sender, EventArgs e)
        {
            Crud crudForm = new Crud();
            crudForm.ShowDialog();
        }

        private void vegetableBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Vegetables");
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Dried Fruits and Coffee");
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Dairies and Cereal");
            
        }

        private void meatBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Meat Products");
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Snack Food");
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            AddUpdateForm addUpdate = new AddUpdateForm();
            addUpdate.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow row = dataGridViewProducts.CurrentRow;
            Products pro = new Products();
            pro.Name = row.Cells["name"].Value.ToString();
            pro.Brand = row.Cells["brand"].Value.ToString();
            pro.Item_Price = Convert.ToDouble(row.Cells["item_price"].Value.ToString());
            pro.StokType = row.Cells["stock_type"].Value.ToString();
            pro.Stock_Amount = Convert.ToDouble(row.Cells["stock_amount"].Value.ToString());
            pro.ID = row.Index+1;
                  AddUpdateForm addUpdate = new AddUpdateForm(pro);
            addUpdate.ShowDialog();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
            DataGridViewRow row = dataGridViewProducts.CurrentRow;
            Products pro = new Products();
          
            pro.Name = row.Cells["name"].Value.ToString();
          
            pro.StokType = row.Cells["stock_type"].Value.ToString();
            if (pro.StokType.Equals("Unpackaged"))
            {
                var res= Convert.ToDouble(Prompt.ShowDialog("Enter the amount:", "Price"));
                if (res > Convert.ToDouble(row.Cells["stock_amount"].Value.ToString()))
                {
                    MessageBox.Show("The stock amount is not sufficient!");
                    
                }
                else
                {
                    pro.Item_Price = Convert.ToDouble(row.Cells["item_price"].Value.ToString()) * res;
                }
                
            }
               
            if (pro.StokType.Equals("Packaged"))
            {

             pro.Item_Price = Convert.ToDouble(row.Cells["item_price"].Value.ToString());
            }
   
            list.Add(pro);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
               
            }
            dataGridViewResult.DataSource = list;
            dataGridViewResult.Columns[0].Visible = false;
            dataGridViewResult.Columns[5].Visible = false;
            dataGridViewResult.Columns[2].Visible = false;
            dataGridViewResult.Columns[3].Visible = false;

            resultBox.Text = (Convert.ToDouble( resultBox.Text)+Convert.ToDouble( pro.Item_Price.ToString())).ToString();
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(resultBox.Text);
           
            if (res > 200)
            {
                MessageBox.Show("Insufficent Fund!");
            }
            else
            {
                reminderBox.Text = (200 - res).ToString();
            }  
        }

        private void hundredBtn_Click(object sender, EventArgs e)
        {

            double res = Convert.ToDouble(resultBox.Text);

            if (res > 100)
            {
                MessageBox.Show("Insufficent Fund!");
            }
            else
            {
                reminderBox.Text = (100 - res).ToString();
            }
        }

        private void fiftyBtn_Click(object sender, EventArgs e)
        {

            double res = Convert.ToDouble(resultBox.Text);

            if (res > 50)
            {
                MessageBox.Show("Insufficent Fund!");
            }
            else
            {
                reminderBox.Text = (50 - res).ToString();
            }
        }

        private void tenBtn_Click(object sender, EventArgs e)
        {

            double res = Convert.ToDouble(resultBox.Text);

            if (res > 10)
            {
                MessageBox.Show("Insufficent Fund!");
            }
            else
            {
                reminderBox.Text = (10 - res).ToString();
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {

            double res = Convert.ToDouble(resultBox.Text);

            if (res > 5)
            {
                MessageBox.Show("Insufficent Fund!");
            }
            else
            {
                reminderBox.Text = (5 - res).ToString();
            }
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
