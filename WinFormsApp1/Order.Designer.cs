namespace WinFormsApp1
{
    partial class Order
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            imageList1 = new ImageList(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "216242_home_icon.png");
            imageList1.Images.SetKeyName(1, "3209316_circuit_digital_hand_product_service_icon.png");
            imageList1.Images.SetKeyName(2, "5588499_communication_discussion_forum_network_reddit_icon.png");
            imageList1.Images.SetKeyName(3, "3586362_checklist_document_list_paper_icon.png");
            imageList1.Images.SetKeyName(4, "8324223_ui_essential_app_avatar_profile_icon.png");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.73171F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(5, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.06224F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9377594F));
            tableLayoutPanel1.Size = new Size(497, 241);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(489, 199);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 109, 150);
            label1.Location = new Point(3, 209);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 7;
            label1.Text = "Thông tin chi tiết";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 5);
            tableLayoutPanel2.Location = new Point(252, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 247F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.Size = new Size(507, 700);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(5, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 122);
            panel3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 87);
            label7.Name = "label7";
            label7.Size = new Size(249, 28);
            label7.TabIndex = 5;
            label7.Text = "Ngày bắt đầu: 13-5/14-5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 50);
            label8.Name = "label8";
            label8.Size = new Size(287, 28);
            label8.TabIndex = 4;
            label8.Text = "Thời gian hoàn thành: 30min";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 10);
            label9.Name = "label9";
            label9.Size = new Size(211, 28);
            label9.TabIndex = 3;
            label9.Text = "Địa chỉ: UIT, Thủ Đức";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 109, 150);
            label6.Location = new Point(5, 475);
            label6.Name = "label6";
            label6.Size = new Size(219, 28);
            label6.TabIndex = 8;
            label6.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(5, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 124);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 87);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 5;
            label4.Text = "Giá: 500$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 50);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 4;
            label3.Text = "Diện tích: 200-500m2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 10);
            label5.Name = "label5";
            label5.Size = new Size(243, 28);
            label5.TabIndex = 3;
            label5.Text = "Dịch vụ: Lau dọn vệ sinh";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 109, 150);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 73);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(138, 21);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 0;
            label2.Text = "Thông tin dịch vụ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(64, 109, 150);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(188, 652);
            button1.Name = "button1";
            button1.Size = new Size(130, 41);
            button1.TabIndex = 10;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 747);
            Controls.Add(tableLayoutPanel2);
            Name = "Order";
            Text = "Order";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}