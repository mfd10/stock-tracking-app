using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using oop.products;
using System.Windows.Forms;

namespace oop
{
    class ExcelCRUD
    {
      
        public static void ReadDataFromExcel(System.Windows.Forms.DataGridView dataGridView, string sheetName)
        {
            try
            {
                OleDbConnection oledConn; 
                DataSet dataSet =  new DataSet();
                OleDbDataAdapter adapter; //ACE
                string filePath = @"C:\Users\demir\source\repos\oop\oop\products.xlsx";
                oledConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0"); //;HDR=YES;IMEX=1;';
                adapter = new OleDbDataAdapter("select * from [" + sheetName+"$]",oledConn);
                adapter.TableMappings.Add("Table", "TestTable");
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                oledConn.Close();
                
            }
            catch(Exception e){
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public static void InsertDataToExcel(string sheetName,Products products )
        {
            try
            {
                OleDbConnection oledConn;
               
                //
                string filePath = @"C:\Users\demir\source\repos\oop\oop\products.xlsx";
                oledConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0"); //;HDR=YES;IMEX=1;';
                oledConn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = oledConn;
                String query = "Insert into ["+sheetName+ "$] (name,brand,stock_type,item_price,stock_amount) values(" + 
                    "'" +products.Name+ "'," +
                    "'" + products.Brand + "'," +
                    "'" + products.StokType + "',"+
                    "'" + products.Item_Price + "',"+
                    "'" + products.Stock_Amount + "')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                oledConn.Close();
                Console.WriteLine(products.Name);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }
    }
}
