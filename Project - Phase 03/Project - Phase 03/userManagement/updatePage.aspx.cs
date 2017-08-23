using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project___Phase_03
{
    public partial class updatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

                txtb_updatefirstName.Text = firstName;
                txtb_updatelastName.Text = lastName;
                txtb_updateusername.Text = username;
                txtb_updatepassword.Text = password;
                txtb_updateaddress.Text = address;
                txtb_updateemail.Text = email;
                txtb_updatephoneNumber.Text = phoneNumber;
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string id = Session["userID"].ToString();

            string updateFirstName = txtb_updatefirstName.Text;
            string updateLastName = txtb_updatelastName.Text;
            string updateUsername = txtb_updateusername.Text;
            string updatePassword = txtb_updatepassword.Text;
            string updateAddress = txtb_updateaddress.Text;
            string updateEmail = txtb_updateemail.Text;
            string updatePhoneNumber = txtb_updatephoneNumber.Text ;

            string updateConnectionString = "Server=DESKTOP-FR7N94E;Database=PROG117DB;User Id=PROG117_web_user; Password=abc123;";
            SqlConnection updateConn = new SqlConnection(updateConnectionString);
            updateConn.Open();

            string updateQuery= "UPDATE [dbo].[person] SET "
                + "[firstName]='"+ updateFirstName + "',"
                + "[lastName]='" + updateLastName + "',"
                + "[userName]='" + updateUsername + "',"
                + "[password]='" + updatePassword + "',"
                + "[address]='" + updateAddress + "',"
                + "[email]='" + updateEmail + "',"
                + "[phone]='" + updatePhoneNumber + "'"
                + "WHERE id=" + id;
            SqlCommand updateCmd = new SqlCommand(updateQuery);
            updateCmd.CommandType = System.Data.CommandType.Text;
            updateCmd.Connection = updateConn;

            updateCmd.ExecuteNonQuery();

            updateConn.Close();

            Response.Redirect("showInfoPage.aspx");
        }
    }
}