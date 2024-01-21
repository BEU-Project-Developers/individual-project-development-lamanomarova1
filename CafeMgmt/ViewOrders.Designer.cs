namespace CafeMgmt
{
    partial class ViewOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            panel1 = new Panel();
            OrdersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            button2 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(OrdersGV);
            panel1.Location = new Point(32, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 513);
            panel1.TabIndex = 0;
            // 
            // OrdersGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            OrdersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OrdersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OrdersGV.ColumnHeadersHeight = 25;
            OrdersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OrdersGV.DefaultCellStyle = dataGridViewCellStyle3;
            OrdersGV.GridColor = Color.FromArgb(231, 229, 255);
            OrdersGV.Location = new Point(29, 3);
            OrdersGV.Name = "OrdersGV";
            OrdersGV.RowHeadersVisible = false;
            OrdersGV.RowHeadersWidth = 51;
            OrdersGV.RowTemplate.Height = 29;
            OrdersGV.Size = new Size(442, 489);
            OrdersGV.TabIndex = 14;
            OrdersGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrdersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrdersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrdersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrdersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrdersGV.ThemeStyle.BackColor = Color.White;
            OrdersGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrdersGV.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            OrdersGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrdersGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrdersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OrdersGV.ThemeStyle.HeaderStyle.Height = 25;
            OrdersGV.ThemeStyle.ReadOnly = false;
            OrdersGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrdersGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrdersGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OrdersGV.ThemeStyle.RowsStyle.Height = 29;
            OrdersGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrdersGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            OrdersGV.CellContentClick += OrdersGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(206, 18);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 15;
            label5.Text = "LIST OF ORDERS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Tomato;
            button2.Location = new Point(206, 587);
            button2.Name = "button2";
            button2.Size = new Size(173, 29);
            button2.TabIndex = 16;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(574, 653);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGV;
        private Button button2;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}