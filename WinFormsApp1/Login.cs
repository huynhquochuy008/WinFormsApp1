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
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();

            string[] lines = File.ReadAllLines("C:\\Users\\Admin\\Desktop\\db.txt");
            foreach (string line in lines)
            {
                if (line.Contains("Save"))
                {
                    string[] array = line.Split(' ');

                    if (array[1] == "true")
                    {
                        cbSave.CheckState = CheckState.Checked;
                        foreach (string l in lines)
                        {
                            if (l.Contains("User"))
                            {
                                string[] arr = l.Split(' ');

                                tbUser.Text = arr[1];
                            }
                            if (l.Contains("Pass"))
                            {
                                string[] arr = l.Split(' ');
                                tbPass.Text = arr[1];
                            }
                        }
                    }
                    else
                    {
                        cbSave.CheckState = CheckState.Unchecked;
                        tbPass.Text = "";
                        tbUser.Text = "";
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Admin\\Desktop\\db.txt");
            int flag = 0;
            foreach (string line in lines)
            {
                if (line.Contains("User"))
                {
                    string[] array = line.Split(' ');

                    if (tbUser.Text.Equals(array[1]))
                    {
                        flag++;
                    }
                }
                if (line.Contains("Pass"))
                {
                    string[] array = line.Split(' ');

                    if (tbPass.Text.Equals(array[1]))
                    {
                        flag++;
                    }
                }
            }
            if (cbSave.Checked)
            {
                using (StreamWriter w = File.AppendText("C:\\Users\\Admin\\Desktop\\db.txt"))
                {
                    w.WriteLine("Save: " + "true");
                }
            }
            else
            {
                using (StreamWriter w = File.AppendText("C:\\Users\\Admin\\Desktop\\db.txt"))
                {
                    w.WriteLine("Save: " + "false");
                }
            }
            if (flag == 2)
            {
                MessageBox.Show("Đăng nhập thành công");
                Home home = new Home();
                this.Hide();
                home.Show();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
