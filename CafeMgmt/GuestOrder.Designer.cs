namespace CafeMgmt
{
    partial class GuestOrder
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            Datelbl = new Label();
            label2 = new Label();
            button2 = new Button();
            QtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            SellerNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            OrderNumTb = new Guna.UI2.WinForms.Guna2TextBox();
            OrdersGv = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            button1 = new Button();
            OrderAmt = new Label();
            ItemsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            categorycb = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(SellerNameTb);
            panel1.Controls.Add(OrderNumTb);
            panel1.Controls.Add(OrdersGv);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(OrderAmt);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(categorycb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(120, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 617);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(735, 569);
            label5.Name = "label5";
            label5.Size = new Size(32, 28);
            label5.TabIndex = 15;
            label5.Text = "Rs";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Datelbl.ForeColor = Color.Tomato;
            Datelbl.Location = new Point(48, 565);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(53, 28);
            Datelbl.TabIndex = 14;
            Datelbl.Text = "Date";
            Datelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(576, 54);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 13;
            label2.Text = "Place Order";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(638, 271);
            button2.Name = "button2";
            button2.Size = new Size(174, 29);
            button2.TabIndex = 12;
            button2.Text = "Add To Cart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // QtyTb
            // 
            QtyTb.BorderColor = Color.FromArgb(255, 192, 128);
            QtyTb.BorderRadius = 2;
            QtyTb.CustomizableEdges = customizableEdges7;
            QtyTb.DefaultText = "Quantity";
            QtyTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            QtyTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            QtyTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            QtyTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            QtyTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            QtyTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            QtyTb.Location = new Point(442, 271);
            QtyTb.Name = "QtyTb";
            QtyTb.PasswordChar = '\0';
            QtyTb.PlaceholderText = "";
            QtyTb.SelectedText = "";
            QtyTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            QtyTb.Size = new Size(174, 30);
            QtyTb.TabIndex = 11;
            // 
            // SellerNameTb
            // 
            SellerNameTb.BorderColor = Color.FromArgb(255, 192, 128);
            SellerNameTb.BorderRadius = 2;
            SellerNameTb.CustomizableEdges = customizableEdges9;
            SellerNameTb.DefaultText = "Guest";
            SellerNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SellerNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SellerNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SellerNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SellerNameTb.Enabled = false;
            SellerNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SellerNameTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SellerNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SellerNameTb.Location = new Point(48, 341);
            SellerNameTb.Name = "SellerNameTb";
            SellerNameTb.PasswordChar = '\0';
            SellerNameTb.PlaceholderText = "";
            SellerNameTb.SelectedText = "";
            SellerNameTb.ShadowDecoration.CustomizableEdges = customizableEdges10;
            SellerNameTb.Size = new Size(174, 30);
            SellerNameTb.TabIndex = 10;
            // 
            // OrderNumTb
            // 
            OrderNumTb.BorderColor = Color.FromArgb(255, 192, 128);
            OrderNumTb.BorderRadius = 2;
            OrderNumTb.CustomizableEdges = customizableEdges11;
            OrderNumTb.DefaultText = "OrderNum";
            OrderNumTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            OrderNumTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            OrderNumTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            OrderNumTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            OrderNumTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            OrderNumTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrderNumTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            OrderNumTb.Location = new Point(48, 292);
            OrderNumTb.Name = "OrderNumTb";
            OrderNumTb.PasswordChar = '\0';
            OrderNumTb.PlaceholderText = "";
            OrderNumTb.SelectedText = "";
            OrderNumTb.ShadowDecoration.CustomizableEdges = customizableEdges12;
            OrderNumTb.Size = new Size(174, 30);
            OrderNumTb.TabIndex = 9;
            // 
            // OrdersGv
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            OrdersGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            OrdersGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            OrdersGv.ColumnHeadersHeight = 25;
            OrdersGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            OrdersGv.DefaultCellStyle = dataGridViewCellStyle9;
            OrdersGv.GridColor = Color.FromArgb(231, 229, 255);
            OrdersGv.Location = new Point(323, 362);
            OrdersGv.Name = "OrdersGv";
            OrdersGv.RowHeadersVisible = false;
            OrdersGv.RowHeadersWidth = 51;
            OrdersGv.RowTemplate.Height = 29;
            OrdersGv.Size = new Size(601, 175);
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
            label3.Location = new Point(576, 322);
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
            button1.Location = new Point(581, 569);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 6;
            button1.Text = "Place The Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderAmt
            // 
            OrderAmt.AutoSize = true;
            OrderAmt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderAmt.ForeColor = Color.Tomato;
            OrderAmt.Location = new Point(773, 569);
            OrderAmt.Name = "OrderAmt";
            OrderAmt.Size = new Size(134, 28);
            OrderAmt.TabIndex = 5;
            OrderAmt.Text = "OrderAmount";
            OrderAmt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ItemsGV
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            ItemsGV.ColumnHeadersHeight = 25;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            ItemsGV.DefaultCellStyle = dataGridViewCellStyle12;
            ItemsGV.GridColor = Color.FromArgb(231, 229, 255);
            ItemsGV.Location = new Point(327, 94);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowHeadersVisible = false;
            ItemsGV.RowHeadersWidth = 51;
            ItemsGV.RowTemplate.Height = 29;
            ItemsGV.Size = new Size(601, 155);
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
            categorycb.Location = new Point(48, 241);
            categorycb.Name = "categorycb";
            categorycb.Size = new Size(174, 31);
            categorycb.TabIndex = 3;
            categorycb.Text = "Category";
            categorycb.SelectionChangeCommitted += categorycb_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 2;
            label1.Text = "Place Order";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 630);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1056, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 31);
            label7.TabIndex = 5;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // GuestOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(1102, 672);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestOrder";
            Text = "ItemForm";
            Load += GuestOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label7;
        private ComboBox categorycb;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGV;
        private Button button1;
        private Label OrderAmt;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGv;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox OrderNumTb;
        private Guna.UI2.WinForms.Guna2TextBox SellerNameTb;
        private Guna.UI2.WinForms.Guna2TextBox QtyTb;
        private Button button2;
        private Label label2;
        private Label Datelbl;
        private Label label5;
    }
}