<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label Text="Sexo" runat="server" />:
            <br/>
            <asp:RadioButton ID="RadioButtonMasculino" runat="server" Text="Masculino" GroupName="sexo"/>  
            <br/>
            <asp:RadioButton ID="RadioButtonFemenino" runat="server" Text="Femenino" GroupName="sexo"/>  
            <br />
            Edad:<asp:TextBox ID="textBoxSegundoValor" runat="server"></asp:TextBox>
            <br />
            Peso:<asp:TextBox ID="textBoxTercerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server">0</asp:Label>
        </div>
    </form>
</body>
</html>
