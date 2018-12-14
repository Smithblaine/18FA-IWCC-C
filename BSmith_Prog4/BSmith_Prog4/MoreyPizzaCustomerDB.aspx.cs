using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BSmith_Prog4
{
    public partial class MoreyPizzaCustomerDB : System.Web.UI.Page
    {
        public static void testConnection()
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection test = new SqlConnection("Data Source = path-todatabase; Integrated Security = true");
            try
            {
                test.Open();
                test.ChangeDatabase("pizza_choice");
                Response.Write("<p>Connected successfully</p>");
            }
            catch (SqlException sqle)
            {
                Response.Write("<p>" +sqle.Number +", "+sqle.Message+"</p>");
            }
            
            if (Page.IsPostBack)
            {
                form1.Visible = false;

                if (nameSearch.Text == null || nameSearch.Text =="")
                {

                }
                else
                {
                    //Search database by the users name
                    string searchByName = "SELECT * FROM pizza_choice WHERE " + nameSearch.Text + " = name";
                    SqlCommand execute = new SqlCommand(searchByName,test);

                    SqlDataReader read = execute.ExecuteReader();
                    if (read.Read())
                    {
                        do
                        {
                            Response.Write(read["name"] + ", Pizza size: " + read["pizzaSize"] + " The toppings are: " + read["twoToppings"]);
                        } while (read.Read());
                    }
                }

                if (Name.Text != null && Name.Text !="" && 
                    toppings.Text != null && toppings.Text != "" && 
                    doc != null && doc.Text != "")
                {
                    //send data
                    string sendOrder = "SELECT * FROM pizza_choice WHERE " + nameSearch.Text + " = name";
                    SqlCommand execute = new SqlCommand(searchByName, test);
                }

                if (Name.Text == null || Name.Text == "")
                {
                    //require the name
                }

                if (toppings.Text == null && toppings.Text == "")
                {
                    //require toppings
                }

                if (doc == null && doc.Text == "")
                {
                    //require shipping method
                }
            }
            test.Close();
        }
    }
}