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
        private Products currentProduct;
        public AddUpdateForm() 
        {
            InitializeComponent(); 
        }
        public AddUpdateForm(Products pro)
        {
            currentProduct = pro;
            InitializeComponent();

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                currentProduct.Name = nameBox.Text;
                currentProduct.Brand = brandBox.Text;
                if (packagedBtn.Checked)
                    currentProduct.StokType = "Packaged";
                else
                    currentProduct.StokType = "Unpackaged";
                currentProduct.Item_Price = Convert.ToDouble(priceBox.Text);
                currentProduct.Stock_Amount = Convert.ToDouble(stockAmountBox.Text);
                ExcelCRUD.UpdateData(comboBox1.Text, currentProduct);
                MessageBox.Show(currentProduct.Name + " succesfully updated.");
            }
            else
            {
                Products pro = new Products();
                pro.Name = nameBox.Text;
                pro.Brand = brandBox.Text;
                if (packagedBtn.Checked)
                    pro.StokType = "Packaged";
                else
                    pro.StokType = "Unpackaged";
                pro.Item_Price = Convert.ToDouble(priceBox.Text);
                pro.Stock_Amount = Convert.ToDouble(stockAmountBox.Text);
                pro.ID = 6;
                //TODO: combo box dairies not working 
                ExcelCRUD.InsertDataToExcel(comboBox1.Text, pro);
                MessageBox.Show(pro.Name + " succesfully added.");
            }
           
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetNameBox()
        {
            return nameBox.Text;
        }
        public void SetNameBox(string name)
        {
            currentProduct.Name=name;
        }
        public string GetBrandBox()
        {
            return brandBox.Text;
        }
        public void SetBrandBox(string brand)
        {
            brandBox.Text=brand;
        }
        public string GetPriceBox()
        {
            return priceBox.Text;
        }
        public void SetPriceBox(string price)
        {
            priceBox.Text = price; 
        }
       

        public string GetStockAmountBox()
        {
            return stockAmountBox.Text;
        }
        public void SetStockAmountBox(string amount)
        {
            stockAmountBox.Text=amount;
        }
        public string  GetStockTypeBox()
        {
            return stockAmountBox.Text;
        }
     
        public string GetCategori()
        {
            return comboBox1.Text;
        }
        public void SetCategori(string value)
        {
            comboBox1.Text=value;
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            if(currentProduct != null)
            {
                nameBox.Text = currentProduct.Name;
                brandBox.Text = currentProduct.Brand;
                priceBox.Text = currentProduct.Item_Price.ToString();
                stockAmountBox.Text = currentProduct.Stock_Amount.ToString();
               
            }
          
        }
    }
}