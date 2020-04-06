<%@ Page Language="C#" AutoEventWireup="true" CodeFile="carga.aspx.cs" Inherits="carga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelApellido" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelTelefono" runat="server" Text="Teléfono:"></asp:Label>
        <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelEstudios" runat="server" Text="Estudios:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxEstudios" runat="server" Height="500px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelExpLaboral" runat="server" Text="Experiencia laboral:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxExpLaboral" runat="server" Height="500px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelReferencias" runat="server" Text="Referencias:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxReferencias" runat="server" Height="500px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonConfirmar" runat="server" Text="Confirmar" OnClick="ButtonConfirmar_Click" /><asp:Label ID="LabelEstado" runat="server" Text="_"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkRetornar" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
    </div>
    </form>
</body>
</html>
