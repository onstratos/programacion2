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
            <asp:RadioButton ID="radioButtonSumar" runat="server" Text="sumar" GroupName="operacion" />
            <br />
            <asp:RadioButton ID="radioButtonRestar" runat="server" Text="restar" GroupName="operacion" />
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server" Text="0"></asp:Label>
        </div>
    </form>
</body>
</html>
