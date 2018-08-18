<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddIngredient.aspx.cs" Inherits="ExoPizza.Web.Pages.AddIngredient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstIngredients" SelectionMode="Multiple" DataTextField="Nom" runat="server"></asp:ListBox>
    </form>
</body>
</html>
