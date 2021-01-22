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
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        private void crud_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddUpdateForm addUpdate = new AddUpdateForm();
            addUpdate.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AddUpdateForm addUpdate = new AddUpdateForm();
            addUpdate.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //delete product from excel
        }
    }
}
