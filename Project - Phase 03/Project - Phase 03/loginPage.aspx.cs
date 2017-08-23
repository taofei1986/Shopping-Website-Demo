using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project___Phase_03
{
    public partial class loginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                login.Visible = false;
                loginMenu.Visible = true;
            }
            else {
                loginMenu.Visible = false;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string uName = txtb_username.Text;
            string pWord = txtb_password.Text;

            string connString= "Server=DESKTOP-FR7N94E;Database=PROG117DB;User Id=PROG117_web_user; Password=abc123;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //   [firstName],[lastName],[userName],[password],[address],[email],[phone],[id]
            string queryString = "SELECT [firstName],[id] FROM[dbo].[person] WHERE userName='"+ uName+ "' AND password='"+ pWord+"'";
            SqlCommand cmd = new SqlCommand(queryString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string strFirstName = reader["firstName"].ToString();
                string strID = reader["id"].ToString();

                Session["ID"] = strID;
                Session["userFirstName"] = strFirstName;

                login.Visible = false;
                loginMenu.Visible = true;
                lb_message.ForeColor = System.Drawing.Color.Blue;
                lb_message.Text = "Welcome " + strFirstName;
            }
            else
            {
                lb_loginNotice.ForeColor = System.Drawing.Color.Red;
                lb_loginNotice.Text = "Login failed.";

            }
        }
    }
}