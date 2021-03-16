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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            productsLstbx.DisplayMember = "Name";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                productsLstbx.Items.Add(form2.product);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var obj = productsLstbx.SelectedItem as Product;
            Form2 form2 = new Form2();
            if (form2.ShowDialog()==DialogResult.OK)
            {
                productsLstbx.Items.Remove(obj);
                productsLstbx.Items.Add(form2.editProduct);
            }
        }

        private void productsLstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = productsLstbx.SelectedItem;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var obj = productsLstbx.SelectedItem as Product;
            productsLstbx.Items.Remove(obj);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            productsLstbx.Items.Clear();
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
