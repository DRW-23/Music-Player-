using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new LoginModel
            {
                Username = txtUser.Text,
                Password = txtPass.Text
            };
            var controller = new LoginController();
            if (controller.Authenticate(model))
            {
                MessageBox.Show("Login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MusicPlayer musicplayer = new MusicPlayer();
                musicplayer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in login");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = !checkBox1.Checked ? '\0' : '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
