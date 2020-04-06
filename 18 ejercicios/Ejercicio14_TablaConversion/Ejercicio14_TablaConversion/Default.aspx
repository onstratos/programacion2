<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese el valor máximo para la tabla de conversión (En kilogramos):<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
