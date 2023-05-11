using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TextWriter txt = new StreamWriter("C:\\Users\\Admin\\Desktop\\db.txt");
            txt.Write("Name: " + tbName.Text + '\n');
            txt.Write("User: " + tbUser.Text + '\n');
            txt.Write("Pass: " + tbPass.Text + '\n');
            txt.Write("Phone: " + tbPhone.Text + '\n');
            txt.Write("Email: " + tbEmail.Text + '\n');
            txt.Write("Location: " + tbLocation.Text + "\n");
            txt.Close();

            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
