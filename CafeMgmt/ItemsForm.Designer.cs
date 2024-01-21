namespace CafeMgmt
{
    partial class ItemsForm
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
            button4 = new Button();
            button3 = new Button();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            button2 = new Button();
            PriceCb = new Guna.UI2.WinForms.Guna2TextBox();
            ItemNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            ItemNumTb = new Guna.UI2.WinForms.Guna2TextBox();
            ItemsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            SuspendLayout();
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
            button4.TabIndex = 17;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            button3.TabIndex = 16;
            button3.Text = "Order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1058, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 31);
            label7.TabIndex = 14;
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
            label4.TabIndex = 15;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(PriceCb);
            panel1.Controls.Add(ItemNameTb);
            panel1.Controls.Add(ItemNumTb);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(122, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 617);
            panel1.TabIndex = 13;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Tomato;
            button5.Location = new Point(165, 350);
            button5.Name = "button5";
            button5.Size = new Size(74, 29);
            button5.TabIndex = 18;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Tomato;
            button1.Location = new Point(245, 350);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 17;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Tomato;
            label8.Location = new Point(628, 99);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 16;
            label8.Text = "Items List";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(37, 282);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 15;
            label6.Text = "ItemPrice";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(36, 188);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 14;
            label5.Text = "ItemName";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(36, 139);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 13;
            label3.Text = "ItemNum";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(36, 350);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 12;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PriceCb
            // 
            PriceCb.BorderColor = Color.FromArgb(255, 192, 128);
            PriceCb.BorderRadius = 2;
            PriceCb.CustomizableEdges = customizableEdges1;
            PriceCb.DefaultText = "";
            PriceCb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PriceCb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PriceCb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PriceCb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PriceCb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PriceCb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PriceCb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PriceCb.Location = new Point(145, 282);
            PriceCb.Name = "PriceCb";
            PriceCb.PasswordChar = '\0';
            PriceCb.PlaceholderText = "";
            PriceCb.SelectedText = "";
            PriceCb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PriceCb.Size = new Size(174, 30);
            PriceCb.TabIndex = 11;
            // 
            // ItemNameTb
            // 
            ItemNameTb.BorderColor = Color.FromArgb(255, 192, 128);
            ItemNameTb.BorderRadius = 2;
            ItemNameTb.CustomizableEdges = customizableEdges3;
            ItemNameTb.DefaultText = "";
            ItemNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ItemNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ItemNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ItemNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ItemNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ItemNameTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ItemNameTb.Location = new Point(145, 188);
            ItemNameTb.Name = "ItemNameTb";
            ItemNameTb.PasswordChar = '\0';
            ItemNameTb.PlaceholderText = "";
            ItemNameTb.SelectedText = "";
            ItemNameTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ItemNameTb.Size = new Size(174, 30);
            ItemNameTb.TabIndex = 10;
            // 
            // ItemNumTb
            // 
            ItemNumTb.BorderColor = Color.FromArgb(255, 192, 128);
            ItemNumTb.BorderRadius = 2;
            ItemNumTb.CustomizableEdges = customizableEdges5;
            ItemNumTb.DefaultText = "";
            ItemNumTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ItemNumTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ItemNumTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ItemNumTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ItemNumTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ItemNumTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNumTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ItemNumTb.Location = new Point(145, 139);
            ItemNumTb.Name = "ItemNumTb";
            ItemNumTb.PasswordChar = '\0';
            ItemNumTb.PlaceholderText = "";
            ItemNumTb.SelectedText = "";
            ItemNumTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ItemNumTb.Size = new Size(174, 30);
            ItemNumTb.TabIndex = 9;
            // 
            // ItemsGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ItemsGV.ColumnHeadersHeight = 30;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ItemsGV.DefaultCellStyle = dataGridViewCellStyle3;
            ItemsGV.GridColor = Color.FromArgb(231, 229, 255);
            ItemsGV.Location = new Point(424, 139);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowHeadersVisible = false;
            ItemsGV.RowHeadersWidth = 51;
            ItemsGV.RowTemplate.Height = 29;
            ItemsGV.Size = new Size(507, 425);
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
            ItemsGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ItemsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ItemsGV.ThemeStyle.HeaderStyle.Height = 30;
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
            // CatCb
            // 
            CatCb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Beverage" });
            CatCb.Location = new Point(145, 234);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(174, 31);
            CatCb.TabIndex = 3;
            CatCb.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(382, 12);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 2;
            label1.Text = "Manage Items";
            // 
            // ItemsForm
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
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += ItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Label label7;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox PriceCb;
        private Guna.UI2.WinForms.Guna2TextBox ItemNameTb;
        private Guna.UI2.WinForms.Guna2TextBox ItemNumTb;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGV;
        private ComboBox CatCb;
        private Label label1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Button button5;
        private Button button1;
    }
}