<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="ASPWebformConnect.Pages.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <asp:Label ID="Label1" runat="server" Text="Suppression de Personne" Font-Size="X-Large" Font-Underline="True"></asp:Label>
        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nom "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="txtNom" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Prénom "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="txtPrenom" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="E-Mail "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="txtEmail" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Genre"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="txtGenre" runat="server"> </asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Supprimer" OnClick="btnDelete_Click" />
        <asp:Label ID="lblStatut" runat="server" Visible="false"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/Default.aspx">Retour à l'accueil</asp:HyperLink>
    </form>
</body>
</html>
