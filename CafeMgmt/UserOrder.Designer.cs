namespace CafeMgmt
{
    partial class UserOrder
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            label2 = new Label();
            OrderAmt = new Label();
            Datelbl = new Label();
            button5 = new Button();
            label5 = new Label();
            button2 = new Button();
            QtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            SellerName = new Guna.UI2.WinForms.Guna2TextBox();
            OrderNum = new Guna.UI2.WinForms.Guna2TextBox();
            OrdersGv = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            button1 = new Button();
            ItemsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            categorycb = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1058, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 31);
            label7.TabIndex = 9;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 630);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 10;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OrderAmt);
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(SellerName);
            panel1.Controls.Add(OrderNum);
            panel1.Controls.Add(OrdersGv);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(categorycb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(122, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 617);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Tomato;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(795, 565);
            button6.Name = "button6";
            button6.Size = new Size(129, 29);
            button6.TabIndex = 18;
            button6.Text = "View Orders";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(605, 565);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 17;
            label2.Text = "Rs";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderAmt
            // 
            OrderAmt.AutoSize = true;
            OrderAmt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderAmt.ForeColor = Color.Tomato;
            OrderAmt.Location = new Point(643, 565);
            OrderAmt.Name = "OrderAmt";
            OrderAmt.Size = new Size(134, 28);
            OrderAmt.TabIndex = 16;
            OrderAmt.Text = "OrderAmount";
            OrderAmt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Datelbl.ForeColor = Color.Tomato;
            Datelbl.Location = new Point(63, 553);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(53, 28);
            Datelbl.TabIndex = 15;
            Datelbl.Text = "Date";
            Datelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.Tomato;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(63, 265);
            button5.Name = "button5";
            button5.Size = new Size(102, 29);
            button5.TabIndex = 14;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(566, 32);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 13;
            label5.Text = "Place Order";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(638, 262);
            button2.Name = "button2";
            button2.Size = new Size(173, 29);
            button2.TabIndex = 12;
            button2.Text = "Add To Cart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // QtyTb
            // 
            QtyTb.BorderColor = Color.FromArgb(255, 192, 128);
            QtyTb.BorderRadius = 2;
            QtyTb.CustomizableEdges = customizableEdges1;
            QtyTb.DefaultText = "Quantity";
            QtyTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            QtyTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            QtyTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            QtyTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            QtyTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            QtyTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            QtyTb.Location = new Point(444, 262);
            QtyTb.Name = "QtyTb";
            QtyTb.PasswordChar = '\0';
            QtyTb.PlaceholderText = "";
            QtyTb.SelectedText = "";
            QtyTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            QtyTb.Size = new Size(174, 30);
            QtyTb.TabIndex = 11;
            // 
            // SellerName
            // 
            SellerName.BorderColor = Color.FromArgb(255, 192, 128);
            SellerName.BorderRadius = 2;
            SellerName.CustomizableEdges = customizableEdges3;
            SellerName.DefaultText = "Seller";
            SellerName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SellerName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SellerName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SellerName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SellerName.Enabled = false;
            SellerName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SellerName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SellerName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SellerName.Location = new Point(63, 361);
            SellerName.Name = "SellerName";
            SellerName.PasswordChar = '\0';
            SellerName.PlaceholderText = "";
            SellerName.SelectedText = "";
            SellerName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SellerName.Size = new Size(174, 30);
            SellerName.TabIndex = 10;
            // 
            // OrderNum
            // 
            OrderNum.BorderColor = Color.FromArgb(255, 192, 128);
            OrderNum.BorderRadius = 2;
            OrderNum.CustomizableEdges = customizableEdges5;
            OrderNum.DefaultText = "OrderNum";
            OrderNum.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            OrderNum.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            OrderNum.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            OrderNum.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            OrderNum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            OrderNum.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrderNum.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            OrderNum.Location = new Point(63, 312);
            OrderNum.Name = "OrderNum";
            OrderNum.PasswordChar = '\0';
            OrderNum.PlaceholderText = "";
            OrderNum.SelectedText = "";
            OrderNum.ShadowDecoration.CustomizableEdges = customizableEdges6;
            OrderNum.Size = new Size(174, 30);
            OrderNum.TabIndex = 9;
            // 
            // OrdersGv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            OrdersGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OrdersGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OrdersGv.ColumnHeadersHeight = 25;
            OrdersGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OrdersGv.DefaultCellStyle = dataGridViewCellStyle3;
            OrdersGv.GridColor = Color.FromArgb(231, 229, 255);
            OrdersGv.Location = new Point(323, 361);
            OrdersGv.Name = "OrdersGv";
            OrdersGv.RowHeadersVisible = false;
            OrdersGv.RowHeadersWidth = 51;
            OrdersGv.RowTemplate.Height = 29;
            OrdersGv.Size = new Size(601, 198);
            OrdersGv.TabIndex = 8;
            OrdersGv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrdersGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrdersGv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrdersGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrdersGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrdersGv.ThemeStyle.BackColor = Color.White;
            OrdersGv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrdersGv.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            OrdersGv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrdersGv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersGv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrdersGv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OrdersGv.ThemeStyle.HeaderStyle.Height = 25;
            OrdersGv.ThemeStyle.ReadOnly = false;
            OrdersGv.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrdersGv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrdersGv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersGv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OrdersGv.ThemeStyle.RowsStyle.Height = 29;
            OrdersGv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrdersGv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(572, 312);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 7;
            label3.Text = "Your Order";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(444, 565);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 6;
            button1.Text = "Place The Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ItemsGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ItemsGV.ColumnHeadersHeight = 25;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ItemsGV.DefaultCellStyle = dataGridViewCellStyle6;
            ItemsGV.GridColor = Color.FromArgb(231, 229, 255);
            ItemsGV.Location = new Point(323, 72);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowHeadersVisible = false;
            ItemsGV.RowHeadersWidth = 51;
            ItemsGV.RowTemplate.Height = 29;
            ItemsGV.Size = new Size(601, 148);
            ItemsGV.TabIndex = 4;
            ItemsGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ItemsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ItemsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ItemsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ItemsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ItemsGV.ThemeStyle.BackColor = Color.White;
            ItemsGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ItemsGV.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            ItemsGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemsGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ItemsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ItemsGV.ThemeStyle.HeaderStyle.Height = 25;
            ItemsGV.ThemeStyle.ReadOnly = false;
            ItemsGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ItemsGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ItemsGV.ThemeStyle.RowsStyle.Height = 29;
            ItemsGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ItemsGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ItemsGV.CellContentClick += ItemsGV_CellContentClick;
            // 
            // categorycb
            // 
            categorycb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            categorycb.FormattingEnabled = true;
            categorycb.Items.AddRange(new object[] { "Food", "Beverage" });
            categorycb.Location = new Point(63, 215);
            categorycb.Name = "categorycb";
            categorycb.Size = new Size(174, 31);
            categorycb.TabIndex = 3;
            categorycb.Text = "Category";
            categorycb.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(63, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 2;
            label1.Text = "Place Order";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Tomato;
            button3.Location = new Point(12, 75);
            button3.Name = "button3";
            button3.Size = new Size(104, 35);
            button3.TabIndex = 11;
            button3.Text = "Items";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Tomato;
            button4.Location = new Point(12, 126);
            button4.Name = "button4";
            button4.Size = new Size(104, 35);
            button4.TabIndex = 12;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UserOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(1102, 672);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserOrder";
            Load += UserOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label4;
        private Panel panel1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox QtyTb;
        private Guna.UI2.WinForms.Guna2TextBox SellerName;
        private Guna.UI2.WinForms.Guna2TextBox OrderNum;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGv;
        private Label label3;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGV;
        private ComboBox categorycb;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label5;
        private Button button5;
        private Label Datelbl;
        private Label label2;
        private Label OrderAmt;
        private Button button6;
    }
}