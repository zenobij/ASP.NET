<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPWebformConnect.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Liste des Personnes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/AjoutPersonne.aspx">Insérer une personne</asp:HyperLink>
            <br />
            <asp:Repeater ID="ModelRepeater" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <th>ID</th>
                            <th>Nom</th>
                            <th>Prenom</th>
                            <th>Genre</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate> 
                    <tr>
                        <td style="background-color:aqua"><%# Eval("PersonneId") %> </td>
                        <td style="background-color:aqua"><%# Eval("Nom") %> </td>
                        <td style="background-color:aqua"><%# Eval("Prenom") %> </td>
                                                <td style="background-color:aqua"><%# Eval("Genre.Civilite") %> </td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr>
                        <td><%# Eval("PersonneId") %> </td>
                        <td><%# Eval("Nom") %> </td>
                        <td><%# Eval("Prenom") %> </td>
                        <td><%# Eval("Genre.Civilite") %> </td>
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>   
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
