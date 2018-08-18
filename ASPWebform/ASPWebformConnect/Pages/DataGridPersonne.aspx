<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridPersonne.aspx.cs" Inherits="ASPWebformConnect.Pages.DataGridPersonne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="PersonneId" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Genre.Civilite" HeaderText="Civilité" />
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Prenom" HeaderText="Prénom" />
                    <asp:HyperLinkField DataNavigateUrlFields="PersonneId" DataNavigateUrlFormatString="Edit.aspx?PersonneId={0}" HeaderText="Update" Text="&amp;#9998;" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:HyperLinkField>
                    <asp:HyperLinkField DataNavigateUrlFields="PersonneId" DataNavigateUrlFormatString="Delete.aspx?PersonneId={0}" HeaderText="Delete" Text="&amp;#10008">
                    <ControlStyle ForeColor="Red" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:HyperLinkField>
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
