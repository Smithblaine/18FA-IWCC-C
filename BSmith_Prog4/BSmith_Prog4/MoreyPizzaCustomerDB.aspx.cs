﻿using System;
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
            
            if (Page.IsPostBack)
            {
                form1.Visible = false;
                
                try
                {
 
                    SqlConnection test = new SqlConnection(@"Data Source=(http://localhost/phpmyadmin/index.php);Initial Catalog=test\pizzaChoice;Integrated Security=false;User Id=root;Password=pass");
                    test.Open();
              
                }
                catch (SqlException sqle)
                {
                    Response.Write("<p>" +sqle.Number +", "+sqle.Message+"</p>");
                }

                if (nameSearch.Text == null || nameSearch.Text =="")
                {

                }
                else
                {
                    //Search database by the users name
                }

                if (Name.Text != null && Name.Text !="" && 
                    toppings.Text != null && toppings.Text != "" && 
                    doc != null && doc.Text != "")
                {
                    //send data
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
        }
    }
}