using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Project___Phase_03.productManagement
{
    public partial class newProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("/loginPage.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string productName = txtb_pdtName.Text;
            string productDescription = txtb_pdtDescription.Text;
            string productPrice = txtb_pdtPrice.Text;
            string productAmount = txtb_pdtAmount.Text;

            string connStr = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            string query = "INSERT INTO[dbo].[products]([productName],[description],[price],[currentAmount])"
                + "VALUES('"+productName+"','"+productDescription+ "','" + productPrice+ "','" + productAmount+"')";
            SqlCommand cmd = new SqlCommand(query);

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();


        }
    }
}