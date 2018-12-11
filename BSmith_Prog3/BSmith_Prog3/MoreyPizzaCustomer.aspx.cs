 //Blaine Smith
 //Prog 3 Due Sunday, November 25th 2018
 //NONE
 //This program will allow the user to enter their name and select toppings to add to a pizza,
 //It will then output the toppings that have been selected.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MoreyPizzaCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            form1.Visible = false;

            int NumTops = 0;
            String FinalOrder = "You have chosen a pizza with the following toppings";
            StringBuilder OutPut = new StringBuilder();

            if (Name.Text == "" || Name.Text == null)
            {
                Response.Write("<p>Please enter your name.</p>");
            }

            if (Pepperoni.Checked)
            {
                if (NumTops < 3)
                {
                    OutPut.AppendFormat(", {0} ", Pepperoni.Text);
                }
                NumTops++;
            }

            if (MeatLover.Checked)
            {
                if (NumTops < 3)
                {
                    OutPut.AppendFormat(", {0} ", MeatLover.Text);
                }
                NumTops++;
            }

            if (Pineapple.Checked)
            {
                if (NumTops < 3)
                {
                    OutPut.AppendFormat(", {0} ", Pineapple.Text);
                }
                NumTops++;
            }

            if (Italian.Checked)
            {
                if (NumTops < 3)
                {
                    OutPut.AppendFormat(", {0} ", Italian.Text);
                }
                NumTops++;
            }

            if (NumTops < 3 || NumTops > 3)
            {
                Response.Write("<p>You must have three toppings</p>");
            }

            if (NumTops == 3 && Name.Text != "" && Name.Text != null)
            {
                Response.Write(String.Format("<p>{0} {1}<br/> Thank you for your business</p>", FinalOrder, OutPut));
            }

            NumTops = 0;
            OutPut.Length = 0;
        }
    }
}