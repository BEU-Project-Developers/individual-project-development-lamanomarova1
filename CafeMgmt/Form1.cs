using Bunifu.Framework.UI;
using System.Data;
using System.Data.SqlClient;

namespace CafeMgmt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // Establishing a connection to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Melumatlar\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        // Handling the application exit when label7 is clicked
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Hiding the current form and showing the GuestOrder form when label4 is clicked
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        // Variable to store the username
        public static string user;

        // Handling the login button click event
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Storing the entered username in the 'user' variable
            user = UnameTb.Text;

            // Checking if the username or password is empty
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter a username or password");
            }
            else
            {
                // Opening the database connection
                Con.Open();

                // Querying the database to check the username and password
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UsersTbl where Uname = '"+UnameTb.Text+"' and Upassword = '"+PasswordTb.Text+"'", Con); 
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Checking if the entered credentials are valid
                if (dt.Rows[0][0].ToString()=="1")
                {
                    // If valid, showing the UserOrder form and hiding the current form
                    UserOrder uorder = new UserOrder();
                    uorder.Show();
                    this.Hide();
                }
                else
                {
                    // If invalid, displaying an error message
                    MessageBox.Show("Wrong username or password");
                }

                // Closing the database connection
                Con.Close();
            }
        }
    }
}
