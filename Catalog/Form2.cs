using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Product product { get; set; }
        public Product editProduct { get; set; }

        public DialogResult ShowDialog(Product product)
        {

            return ShowDialog();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            product = new Product
            {
                Name = nameTxtb.Text,
                Country = countryTxtb.Text,
                Price = int.Parse(priceTxtb.Text)
            };
            FileHelper.JsonSerialize(nameTxtb.Text, product);
            editProduct = new Product
            {
                Name = nameTxtb.Text,
                Country = countryTxtb.Text,
                Price = int.Parse(priceTxtb.Text)
            };
            FileHelper.JsonSerialize(nameTxtb.Text, editProduct);
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
