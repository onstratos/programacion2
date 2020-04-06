<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Ingrese el valor a evaluar:" runat="server" /><asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Label Text="Operación" runat="server" />:
            <br/>
            <asp:RadioButton ID="RadioButtonCodificar" runat="server" Text="Codificar" GroupName="codificacion" Checked="true"/>  
            <br/>
            <asp:RadioButton ID="RadioButtonDecodificar" runat="server" Text="Decodificar" GroupName="codificacion"/>  
            <br />

            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server">0</asp:Label>
    </div>
    </form>
</body>
</html>
