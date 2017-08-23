using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Project___Phase_03.shopping
{
    public partial class buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("/loginPage.aspx");
            }

            string prdId = Request.QueryString["prodID"].ToString();

            // step connect to the db
            string connStr = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // step 2 - create a query
            string cmdStr = @"SELECT *  FROM [dbo].[products] where pid="+ prdId;
            SqlCommand cmd = new SqlCommand(cmdStr);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            //step 3 - run the query for product information
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string prdName = reader["productName"].ToString();
            string prdPrice = reader["price"].ToString();
            reader.Close();

            //step 4 - run the query for user information

            cmd.CommandText = "select * from person";
            reader = cmd.ExecuteReader();
            reader.Read();
            string customerName = reader["firstName"].ToString();
            string customerAdress = reader["address"].ToString();
            string userEmail = reader["email"].ToString();
            reader.Close();

            //decrease the product
            cmd.CommandText = "update products set currentAmount = currentAmount-1 where pid=" + prdId;
            cmd.ExecuteNonQuery();

            //close the connection
            conn.Close();

            //show the information to cutomer
            div_orderInformation.InnerHtml = "Hi " + customerName + " <br/>" +
                "Thanks for buying a <b>" + prdName + "</b>. Your credit card will be charged <b>$" + prdPrice + "</b>. And your purchase will be shipped to <b>" + customerAdress + "</b>.<br/>" +
                "Thanks for shopping with us. Come back soon.";

            //send email
            string textInEmail = "Hi " + customerName + " <br/>" +
                "Thanks for buying a <b>" + prdName + "</b>. Your credit card will be charged <b>$" + prdPrice + "</b>. And your purchase will be shipped to <b>" + customerAdress + "</b>.<br/>" +
                "Thanks for shopping with us. Come back soon.";
            string subjectEmail = "Test Email";

            string fromEmail = "@gmail.com";//your sending Email, it must be gmail.
            string password = "";//your sending email password.

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(fromEmail);
            mail.To.Add(userEmail);
            mail.Subject = subjectEmail;
            mail.Body = textInEmail;

            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(fromEmail, password);
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}