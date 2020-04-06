<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alta.aspx.cs" Inherits="alta" %>

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
        <br />
        <asp:Label ID="LabelClave" runat="server" Text="Clave:"></asp:Label>
        <asp:TextBox ID="TextBoxClave" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelMail" runat="server" Text="Mail:"></asp:Label>
        <asp:TextBox ID="TextBoxMail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonAlta" runat="server" Text="Alta" OnClick="ButtonAlta_Click" />
        <asp:Label ID="LabelEstado" runat="server" Text="..."></asp:Label>
    
    </div>
    </form>
</body>
</html>
