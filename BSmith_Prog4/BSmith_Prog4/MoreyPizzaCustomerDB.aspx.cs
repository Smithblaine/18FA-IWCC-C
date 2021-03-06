﻿/*
 * Blaine Smith
 * Project 4 Due Friday, 12-14-2018
 * NONE
 * This program will send the users information to a database once entered by the user,
 * If the user desires to request data, the program will then access the database to then output data.
 */
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

                if (toppings.Text == null || toppings.Text == "" || toppings.Text.Equals("first topping, second topping"))
                {
                    //require toppings
                    Response.Write("<p>You must enter two toppings of your choice</p>");
                }

                if (doc == null || doc.Text == "")
                {
                    //require shipping method
                    Response.Write("<p>You must enter your prefered metohd of delivery</p>");
                }

                if (nameSearch.Text == null || nameSearch.Text =="")
                {
                    //require the name
                    Response.Write("<p>You must enter your name</p>");
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
                    doc != null && doc.Text != "" &&
                    size.Text != null && size.Text != "")
                {
                    //send data
                    string sendOrder = "INSERT INTO pizzaChoice" +
                                       "VALUES(null,"+size.Text+","+toppings.Text+","+doc.Text+","+Name.Text+")";
                    SqlCommand execute = new SqlCommand(sendOrder, test);
                }
                else
                {
                    Response.Write("<p>One or more fields have been left blank</p>");
                }
            }
            test.Close();
        }
    }
}