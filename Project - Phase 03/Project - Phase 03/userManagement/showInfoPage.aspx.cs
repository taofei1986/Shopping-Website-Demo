using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project___Phase_03
{
    public partial class showInfoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["userID"].ToString();

            string connectionString = "Server=DESKTOP-FR7N94E;Database=PROG117DB;User Id=PROG117_web_user; Password=abc123;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM [dbo].[person] where id=" + id;
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            string firstName = reader["firstName"].ToString();
            string lastName = reader["lastName"].ToString();
            string username = reader["userName"].ToString();
            string password = reader["password"].ToString();
            string address = reader["address"].ToString();
            string email = reader["email"].ToString();
            string phoneNumber = reader["phone"].ToString();

            conn.Close();

            lb_firstName.Text = firstName;
            lb_lastName.Text = lastName;
            lb_username.Text = username;
            lb_password.Text = password;
            lb_address.Text = address;
            lb_email.Text = email;
            lb_phoneNumber.Text = phoneNumber;
            
        }
    }
}