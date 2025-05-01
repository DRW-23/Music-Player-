using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class LoginController
{
    private string connectionString = "Data Source=DESKTOP-TJLBV3V\\SQLEXPRESS;Initial Catalog=loginapp;Integrated Security=True";

    public bool Authenticate(LoginModel model)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", model.Username);
            cmd.Parameters.AddWithValue("@password", model.Password);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
