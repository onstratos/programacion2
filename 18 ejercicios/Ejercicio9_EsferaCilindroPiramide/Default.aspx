<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label Text="Seleccione una figura geométrica:" runat="server" />
            <br />
            <asp:DropDownList id="figurasLista" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList_Changed">
                  <asp:ListItem Selected="True" Value="esfera">Esfera</asp:ListItem>
                  <asp:ListItem Value="cilindro">Cilindro</asp:ListItem>
                  <asp:ListItem Value="piramide">Pirámide</asp:ListItem>
                  <asp:ListItem Value="paralelepipedo">Paralelepípedo</asp:ListItem>
               </asp:DropDownList>
            <br/>
            <asp:Label ID="labelRadio" Text="Ingrese el radio de la figura:" runat="server" /><asp:TextBox ID="textBoxRadio" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="labelAltura" Text="Ingrese la altura de la figura:" runat="server" /><asp:TextBox ID="textBoxAltura" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="labelAristaCubo" Text="Ingrese una de las aristas de un cubo:" runat="server" /><asp:TextBox ID="textBoxAristaCubo" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server">0</asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
