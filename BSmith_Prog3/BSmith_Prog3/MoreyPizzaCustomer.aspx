<%--
 Blaine Smith
 Prog 3 Due Sunday, November 25th 2018
 NONE
 This program will allow the user to enter their name and select toppings to add to a pizza,
 It will then output the toppings that have been selected.
 --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MoreyPizzaCustomer.aspx.cs" Inherits="MoreyPizzaCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Parlor Tailor</title>
<style>
    #pageTitle{
        text-align: center;
        height: 65px;
        margin-top: 102px;
        color:white;
    }

    #wrapper{
        display: block;
        text-align: center;
    }

    #alignment{
        display: inline-block;
        text-align: left;
        padding: 3%;
        background-color:antiquewhite;
    }
    body {
        background-image: url('https://cdn.hipwallpaper.com/i/3/66/AbfRa6.jpg');
    }
    p{
        color:white;
        font-size: 25px;
        text-align: center;
        margin-top: 100px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            
            <h1 id="pageTitle">Welcome to the Pizza Parlor Tailor</h1>
            <br />
            <div id="alignment">
                Enter your name:  <asp:TextBox ID="Name" runat="server"></asp:TextBox><br /><br />
                Select three toppings:  <br />
                <asp:CheckBox ID="Pepperoni" text="Pepperoni" runat="server" /><br />
                <asp:CheckBox ID="MeatLover" text="Meat lover" runat="server" /><br />
                <asp:CheckBox ID="Pineapple" text="Pineapple" runat="server" /><br />
                <asp:CheckBox ID="Italian" text="Italian" runat="server" /><br />
                <br />
                <br />
                <input id="Submit" type="submit" value="Submit Order" />
            </div>
        </div>
    </form>
</body>
</html>