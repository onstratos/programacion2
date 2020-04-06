<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listado.aspx.cs" Inherits="listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelComentarios" runat="server" Text="Comentarios"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkRetornar" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
