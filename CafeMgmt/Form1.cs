using Bunifu.Framework.UI;

namespace CafeMgmt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();
        }
    }
}
