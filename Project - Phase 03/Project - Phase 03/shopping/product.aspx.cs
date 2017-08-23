using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Project___Phase_03.productManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("/loginPage.aspx");
            }


            // step connect to the db
            string connStr = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            
            // step 2 - create the query returning only products that have more than zero in stock
            string cmdStr = @"SELECT *  FROM [dbo].[products] where currentAmount > 0";
            SqlCommand cmd = new SqlCommand(cmdStr);
            cmd.Connection = conn;
            
            //step 3 - run the query
            string prod, desc, price, pid;
            SqlDataReader reader = cmd.ExecuteReader();

            div_product.Controls.Add(new LiteralControl("<Table><tr><th>" + "Product" + "</th><th>" + "Description" + "</th><th>" + "Price" + "</th><th>" +"One Click Buy"+ "</th></tr><br/>"));

            while (reader.Read())
            {
                prod = reader["productName"].ToString();
                desc = reader["description"].ToString();
                price = reader["price"].ToString();
                pid = reader["pid"].ToString();
                //do whatever you want to do with the variables
                div_product.Controls.Add(new LiteralControl("<tr><td>"+ prod + "</td><td>" + desc + "</td><td>$"+ price + "</td><td>"));
                // create a link
                HtmlAnchor link = new HtmlAnchor();
                link.HRef = "buy.aspx?prodID=" + pid;
                link.InnerText ="buy this";
                div_product.Controls.Add(link);
                div_product.Controls.Add(new LiteralControl("</td></tr><br/>"));

            }
            div_product.Controls.Add(new LiteralControl("</Table>"));
            //step 4 - close the conn
            conn.Close();


        }
    }
}