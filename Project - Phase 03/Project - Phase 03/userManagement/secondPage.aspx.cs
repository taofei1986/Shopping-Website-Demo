using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project___Phase_03
{
    public partial class secondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstName = Request.Form["txtb_firstName"];
            string lastName = Request.Form["txtb_lastName"];
            string username = Request.Form["txtb_username"];
            string password = Request.Form["txtb_password"];
            string address = Request.Form["txtb_address"];
            string email = Request.Form["txtb_email"];
            string phoneNumber = Request.Form["txtb_phoneNumber"];
            lb_firstName.Text = firstName;
            lb_lastName.Text = lastName;
            lb_username.Text = username;
            lb_password.Text = password;
            lb_address.Text = address;
            lb_email.Text = email;
            lb_phoneNumber.Text = phoneNumber;

            string connectionString = "Server=DESKTOP-FR7N94E;Database=PROG117DB;User Id=PROG117_web_user; Password=abc123;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "INSERT INTO [dbo].[person]([firstName],[lastName],[userName],[password],[address],[email],[phone]) VALUES"
                 + "('"+firstName+"','"+lastName + "','" + username + "','" + password + "','" + address + "','" + email + "','" + phoneNumber + "') SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(query);

            //cmd.Parameters.AddWithValue("@firstName", firstName);
            //cmd.Parameters.AddWithValue("@lastName", lastName);
            //cmd.Parameters.AddWithValue("@username", username);
            //cmd.Parameters.AddWithValue("@password", password);
            //cmd.Parameters.AddWithValue("@address", address);
            //cmd.Parameters.AddWithValue("@email", email);
            //cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Connection = conn;

            SqlDataReader reader= cmd.ExecuteReader();
            reader.Read();
            string id = reader[0].ToString();
            
            conn.Close();

            Session["userID"] = id;
        }
    }
}