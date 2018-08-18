<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjoutPersonne.aspx.cs" Inherits="ASPWebformConnect.Pages.AjoutPersonne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ajout</title>
    <style type="text/css">
        .auto-style1 {
            width: 33%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ajout de Personne" Font-Size="X-Large" Font-Underline="True"></asp:Label>
        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nom "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Un nom est obligatoire" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Prénom "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="L'Email est obligatoire" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="E-Mail "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="L'Email est obligatoire" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Genre"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Civilite"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sauver" OnClick="Button1_Click" />
        <asp:Label ID="Label4" runat="server" Visible="false"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/Default.aspx">Retour à l'accueil</asp:HyperLink>

    </form>
</body>
</html>
