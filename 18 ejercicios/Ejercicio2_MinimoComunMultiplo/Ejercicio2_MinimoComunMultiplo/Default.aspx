<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 2 | MCM</title>
    <link href="../../resources/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese el primer valor a evaluar:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            Ingrese el segundo valor a evaluar:<asp:TextBox ID="textBoxSegundoValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
