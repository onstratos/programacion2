﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="linkCargar" runat="server" NavigateUrl="~/carga.aspx">Cargar comentarios en el libro de visitas</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="linkListado" runat="server" NavigateUrl="~/listado.aspx">Listado del libro</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
