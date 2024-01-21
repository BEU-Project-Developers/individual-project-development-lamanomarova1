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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        // Establishing a connection to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Melumatlar\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;");

        // Button click event for closing the ViewOrders form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Method to populate the OrdersGV (DataGridView) with data from the OrdersTbl
        void populate()
        {
            Con.Open();
            string query = "select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Form load event to populate the OrdersGV on form load
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        // Cell click event in the OrdersGV (DataGridView) to show print preview and trigger printing
        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        // Print document event for printing the order summary
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====MyCafe SoftWare=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(200, 40));

            e.Graphics.DrawString("=====Order Summary=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208, 100));

            e.Graphics.DrawString("Number:" + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 140));

            e.Graphics.DrawString("Date:" + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 180));

            e.Graphics.DrawString("Seller:" + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 220));

            e.Graphics.DrawString("Amount:" + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 260));

            e.Graphics.DrawString("=====Copyright2024=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208, 300));

        }
    }
}
