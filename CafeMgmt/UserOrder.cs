using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMgmt
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
