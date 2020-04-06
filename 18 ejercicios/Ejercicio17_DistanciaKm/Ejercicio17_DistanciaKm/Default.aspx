<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            Ingrese la velocidad del vehículo en kilómetros por hora:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            Ingrese el tiempo del trayecto del vehículo en minutos:<asp:TextBox ID="textBoxSegundoValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server">0</asp:Label>
    </div>
    </form>
</body>
</html>
