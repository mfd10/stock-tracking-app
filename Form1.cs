using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Fruits");
        }
        private void button3_Click(object sender, EventArgs e)
        {

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
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Dried");
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Dairy");
        }

        private void meatBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Meat");
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            ExcelCRUD.ReadDataFromExcel(dataGridViewProducts, "Snacks");
        }
    }
}
