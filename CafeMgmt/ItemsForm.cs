using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CafeMgmt
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Melumatlar\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");
        void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder();
            order.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemNameTb.Text == "" || ItemNumTb.Text == "" || PriceCb.Text == "")
            {
                MessageBox.Show("Fill all the data");
            }
            else
            {
                Con.Open();
                string query = "insert into UsersTbl values('" + ItemNumTb.Text + "', '" + ItemNameTb.Text + "' ,  '" + CatCb.SelectedItem.ToString() + "', '" + PriceCb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Created");
                Con.Close();
                populate();
            }

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
