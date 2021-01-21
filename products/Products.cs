using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.products
{
   public class Products
    {
        private string name, brand,stoktype;
     //   private bool stoktype;
        private double item_price, stock_amount;
        private static int product_ID;

        /*

        public Products(string name, string brand, string stoktype, double item_price, double stock_amount, long product_ID)
        {
            this.name = name;
            this.brand = brand;
            this.stoktype = stoktype;
            this.stock_amount = stock_amount;
            this.item_price = item_price;
            this.stock_amount = stock_amount;
            product_ID++;
        }*/
        public int ID
        {
            get => product_ID;
            set => product_ID = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Brand
        {
            get => brand;
            set => brand = value;
        }

        public string StokType
        {
            get => stoktype;
            set => stoktype = value;
        }

        public double Item_Price
        {
            get => item_price;
            set => item_price = value;
        }

        public double Stock_Amount
        {
            get => stock_amount;
            set => stock_amount = value;
        }
    }
}
