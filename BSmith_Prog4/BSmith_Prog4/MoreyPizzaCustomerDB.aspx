<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MoreyPizzaCustomerDB.aspx.cs" Inherits="BSmith_Prog4.MoreyPizzaCustomerDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                Enter your name:  <asp:TextBox ID="Name" runat="server"></asp:TextBox><br /><br />
                Search by name:  <asp:TextBox ID="nameSearch" runat="server"></asp:TextBox>  Enter name then Submit<br /><br />
                Select two toppings:  <asp:TextBox ID="toppings" runat="server">first topping, second topping</asp:TextBox><br />
                Select size:  <asp:TextBox ID="size" runat="server">small</asp:TextBox><br />
                Will this be delivery or carry out? <asp:TextBox ID="doc" runat="server"></asp:TextBox>
                <br />
                <br />
                <input id="Submit" type="submit" value="Submit Order" />
        </div>
    </form>
</body>
</html>
