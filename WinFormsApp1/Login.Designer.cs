namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lb_username = new Label();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            tbUser = new TextBox();
            lb_pwd = new Label();
            tbPass = new TextBox();
            btnLogin = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            panel1 = new Panel();
            cbSave = new CheckBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_username
            // 
            lb_username.Anchor = AnchorStyles.Top;
            lb_username.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_username.Location = new Point(76, 15);
            lb_username.Margin = new Padding(0, 13, 11, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(343, 40);
            lb_username.TabIndex = 0;
            lb_username.Text = "Tài Khoản";
            lb_username.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(341, 24);
            button3.Name = "button3";
            button3.Size = new Size(60, 47);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(194, 407);
            linkLabel1.Margin = new Padding(11, 13, 11, 13);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // tbUser
            // 
            tbUser.Anchor = AnchorStyles.Top;
            tbUser.Location = new Point(79, 93);
            tbUser.Margin = new Padding(6, 13, 11, 27);
            tbUser.Multiline = true;
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(342, 33);
            tbUser.TabIndex = 3;
            tbUser.UseSystemPasswordChar = true;
            // 
            // lb_pwd
            // 
            lb_pwd.Anchor = AnchorStyles.Top;
            lb_pwd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pwd.Location = new Point(76, 168);
            lb_pwd.Margin = new Padding(0, 13, 11, 0);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(343, 32);
            lb_pwd.TabIndex = 1;
            lb_pwd.Text = "Mật khẩu";
            lb_pwd.TextAlign = ContentAlignment.MiddleLeft;
            lb_pwd.UseCompatibleTextRendering = true;
            // 
            // tbPass
            // 
            tbPass.Anchor = AnchorStyles.Top;
            tbPass.Location = new Point(79, 224);
            tbPass.Margin = new Padding(6, 13, 11, 13);
            tbPass.Multiline = true;
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(342, 37);
            tbPass.TabIndex = 2;
            tbPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = SystemColors.MenuBar;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(245, 27);
            btnLogin.Margin = new Padding(11, 27, 11, 27);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.SeaShell;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tbPass, 0, 3);
            tableLayoutPanel2.Controls.Add(lb_pwd, 0, 2);
            tableLayoutPanel2.Controls.Add(tbUser, 0, 1);
            tableLayoutPanel2.Controls.Add(lb_username, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 0, 8);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 7);
            tableLayoutPanel2.Controls.Add(linkLabel1, 0, 6);
            tableLayoutPanel2.Controls.Add(panel1, 0, 4);
            tableLayoutPanel2.Location = new Point(426, 28);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel2.Size = new Size(501, 683);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(186, 596);
            button2.Name = "button2";
            button2.Size = new Size(133, 47);
            button2.TabIndex = 9;
            button2.Text = "Đăng kí";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5967751F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4032249F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 1, 0);
            tableLayoutPanel1.Location = new Point(5, 458);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(496, 96);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(93, 24);
            button1.Name = "button1";
            button1.Size = new Size(60, 47);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cbSave);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 80);
            panel1.TabIndex = 10;
            // 
            // cbSave
            // 
            cbSave.AutoSize = true;
            cbSave.Location = new Point(84, 35);
            cbSave.Name = "cbSave";
            cbSave.Size = new Size(130, 24);
            cbSave.TabIndex = 0;
            cbSave.Text = "Lưu đăng nhập";
            cbSave.UseVisualStyleBackColor = true;
            cbSave.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 724);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb_username;
        private Button button3;
        private LinkLabel linkLabel1;
        private TextBox tbUser;
        private Label lb_pwd;
        private TextBox tbPass;
        private Button btnLogin;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private CheckBox cbSave;
    }
}