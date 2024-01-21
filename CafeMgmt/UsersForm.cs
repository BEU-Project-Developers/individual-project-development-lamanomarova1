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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        // Establishing a connection to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Melumatlar\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        // Method to populate the UsersGV (DataGridView) with data from the UsersTbl
        void populate()
        {
            Con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Button click event for navigating to the UserOrder form
        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();
        }

        // Button click event for navigating to the ItemsForm
        private void button4_Click(object sender, EventArgs e)
        {
            ItemsForm item = new ItemsForm();
            item.Show();
            this.Hide();
        }

        // Label click event for navigating back to the login form
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        // Button click event for adding a new user
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UsersTbl values('" + unameTb.Text + "', '" + UphoneTb.Text + "' ,  '" + UpassTb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Created");
            Con.Close();
            populate();

        }

        // Form load event to populate the UsersGV on form load
        private void UsersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        // Cell click event in the UsersGV (DataGridView) to fill the textboxes with selected user details
        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            UphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        // Button click event for deleting a user
        private void button1_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Select the user to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from UsersTbl where Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted");
                Con.Close();
                populate();
            }
        }

        // Button click event for updating user details
        private void button5_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "" || UpassTb.Text == "" || unameTb.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                Con.Open();
                string query = "update UsersTbl set Uname='" + unameTb.Text + "' , Upassword = '" + UpassTb.Text + "'where Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully updated");
                Con.Close();
                populate();
            }
        }

        // Label click event for exiting the application
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
