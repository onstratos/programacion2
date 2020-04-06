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
        <asp:Label ID="LabelPais" runat="server" Text="País:"></asp:Label>
        <asp:TextBox ID="TextBoxPais" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelComentarios" runat="server" Text="Comentarios:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxComentarios" runat="server" Height="100px" TextMode="MultiLine" Width="500px"></asp:TextBox>
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
