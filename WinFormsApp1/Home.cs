using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text.ToString();
            lbMessage.Items.Add("You: " + message);
            tbMessage.Text = "";
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
