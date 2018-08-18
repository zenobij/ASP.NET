<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ASPWebformConnect.Pages.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
               <div>
            <asp:Label ID="Label1" runat="server" Text="Modification de Personne" Font-Size="X-Large" Font-Underline="True"></asp:Label>
        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nom "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Un nom est obligatoire" ControlToValidate="txtNom" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Prénom "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="L'Email est obligatoire" ControlToValidate="txtPrenom" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="E-Mail "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="L'Email est obligatoire" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Genre"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlGenre" runat="server" DataTextField="Civilite"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="btnValider" runat="server" Text="Sauver" OnClick="btnValider_Click" />
        <asp:Label ID="lblStatut" runat="server" Visible="false"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/Default.aspx">Retour à l'accueil</asp:HyperLink>
    </form>
</body>
</html>
