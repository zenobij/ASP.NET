﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GrillePizza.aspx.cs" Inherits="ExoPizza.Web.Pages.GrillePizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="grvPizza" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:BoundField DataField="PizzaId" HeaderText="ID" />
                <asp:BoundField DataField="Code" HeaderText="Code" />
                <asp:BoundField DataField="Nom" HeaderText="Nom" />
                <asp:BoundField DataField="PizzaIngredients.Count" HeaderText="Nb I." />
                <asp:BoundField DataField="ListeIngredients" HeaderText="Liste des ingrédients" />
                <asp:BoundField DataField="Prix" DataFormatString="{0} €" HeaderText="Prix" />
                <asp:HyperLinkField DataNavigateUrlFields="PizzaId" DataNavigateUrlFormatString="AddIngredient.aspx?PizzaId={0}" HeaderText="Ajout I." Text="&amp;#10010">
                <ItemStyle ForeColor="#3366FF" HorizontalAlign="Center" />
                </asp:HyperLinkField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </form>
</body>
</html>
