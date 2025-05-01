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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {





            ////////////////////
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TJLBV3V\\SQLEXPRESS;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                con.Open();

                // Check if username exists
                SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM dbo.loginapp WHERE Username=@username", con);
                checkUser.Parameters.AddWithValue("@username", txt_username.Text);
                int userExists = (int)checkUser.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("Username already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert new user
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.loginapp (Username, Password) VALUES (@username, @password)", con);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    // Show login form here
                }
            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
