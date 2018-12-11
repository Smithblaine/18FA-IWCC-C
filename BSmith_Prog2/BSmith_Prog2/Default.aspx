<!--
    Blaine Smith Project 2, Due Friday October 5, 2018
    NONE
    This program will print out your favorite lawn care service for you.
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Larry's Lawn Service</title>
</head>
<body>
    <script runat="server">
        string favoriteLawnService()
        {
            string companyName = "Larry's Lawn Service";
            return companyName;
        }
    </script>
    <%
        string BestLandScaper = favoriteLawnService();
        Response.Write("Who is your favorite land scaper? " + BestLandScaper);
    %>
    
</body>
</html>
