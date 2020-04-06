<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labelPrimerValor" runat="server" Text="Ingrese el primer valor:"></asp:Label><asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="labelSegundoValor" runat="server" Text="Ingrese el segundo valor:"></asp:Label><asp:TextBox ID="textBoxSegundoValor" runat="server"></asp:TextBox>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                <asp:ListItem Selected="True">sumar</asp:ListItem>
                <asp:ListItem>restar</asp:ListItem>
                <asp:ListItem>multiplicar</asp:ListItem>
                <asp:ListItem>dividir</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Calcular" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server" Text="0"></asp:Label>
        </div>
    </form>
</body>
</html>
