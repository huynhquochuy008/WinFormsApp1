namespace WinFormsApp1
{
    partial class Register
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            label2 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            tbPhone = new TextBox();
            label1 = new Label();
            tbEmail = new TextBox();
            btnRegister = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            label5 = new Label();
            tbPass = new TextBox();
            label6 = new Label();
            tbUser = new TextBox();
            tbLocation = new TextBox();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.BackColor = Color.SeaShell;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox3, 0, 5);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.BackColor = SystemColors.HighlightText;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(31, 35);
            textBox3.Margin = new Padding(30, 3, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 34);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 5);
            label3.Margin = new Padding(30, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 4;
            label3.Text = "Địa chỉ Email";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.RosyBrown;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Location = new Point(0, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 100);
            tabPage2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 323);
            label2.Margin = new Padding(30, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 2;
            label2.Text = "Số ĐT";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(169, 9);
            label4.Name = "label4";
            label4.Size = new Size(139, 24);
            label4.TabIndex = 0;
            label4.Text = "Tạo tài khoản";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left;
            tbName.BackColor = SystemColors.HighlightText;
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(31, 90);
            tbName.Margin = new Padding(30, 3, 3, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(416, 34);
            tbName.TabIndex = 1;
            // 
            // tbPhone
            // 
            tbPhone.Anchor = AnchorStyles.Left;
            tbPhone.BackColor = SystemColors.HighlightText;
            tbPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhone.Location = new Point(31, 366);
            tbPhone.Margin = new Padding(30, 3, 3, 3);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(416, 34);
            tbPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 420);
            label1.Margin = new Padding(30, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Left;
            tbEmail.BackColor = SystemColors.HighlightText;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(31, 462);
            tbEmail.Margin = new Padding(30, 3, 3, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(416, 34);
            tbEmail.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.LightGray;
            btnRegister.Location = new Point(194, 599);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(90, 48);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng kí";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.BackColor = Color.SeaShell;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label8, 0, 11);
            tableLayoutPanel2.Controls.Add(tbName, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(tbEmail, 0, 10);
            tableLayoutPanel2.Controls.Add(tbPhone, 0, 8);
            tableLayoutPanel2.Controls.Add(label2, 0, 7);
            tableLayoutPanel2.Controls.Add(tbPass, 0, 6);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(tbUser, 0, 4);
            tableLayoutPanel2.Controls.Add(btnRegister, 0, 13);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(tbLocation, 0, 12);
            tableLayoutPanel2.Controls.Add(label1, 0, 9);
            tableLayoutPanel2.Location = new Point(477, 48);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(478, 654);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 138);
            label7.Margin = new Padding(30, 0, 3, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(103, 28);
            label7.TabIndex = 11;
            label7.Text = "Tài khoản";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 48);
            label5.Margin = new Padding(30, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 7;
            label5.Text = "Họ và tên";
            // 
            // tbPass
            // 
            tbPass.Anchor = AnchorStyles.Left;
            tbPass.BackColor = SystemColors.HighlightText;
            tbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPass.Location = new Point(31, 271);
            tbPass.Margin = new Padding(30, 3, 3, 3);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(416, 34);
            tbPass.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 225);
            label6.Margin = new Padding(30, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 8;
            label6.Text = "Mật khẩu";
            // 
            // tbUser
            // 
            tbUser.Anchor = AnchorStyles.Left;
            tbUser.BackColor = SystemColors.HighlightText;
            tbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(31, 179);
            tbUser.Margin = new Padding(30, 3, 3, 3);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(416, 34);
            tbUser.TabIndex = 10;
            // 
            // tbLocation
            // 
            tbLocation.Anchor = AnchorStyles.Left;
            tbLocation.BackColor = SystemColors.HighlightText;
            tbLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLocation.Location = new Point(31, 552);
            tbLocation.Margin = new Padding(30, 3, 3, 3);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(416, 34);
            tbLocation.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(31, 513);
            label8.Margin = new Padding(30, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 13;
            label8.Text = "Địa chỉ";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 729);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox3;
        private Label label3;
        private TabPage tabPage2;
        private Label label2;
        private Label label4;
        private TextBox tbName;
        private TextBox tbPhone;
        private Label label1;
        private TextBox tbEmail;
        private Button btnRegister;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label7;
        private TextBox tbPass;
        private Label label6;
        private TextBox tbUser;
        private Label label8;
        private TextBox tbLocation;
    }
}