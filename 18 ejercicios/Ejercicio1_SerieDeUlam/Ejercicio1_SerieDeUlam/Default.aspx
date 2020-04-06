<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 1 | Serie de Ulam</title>

    <style type="text/css">
        body {
            background-color: #85073b;
            color: white;
            font-size: 1em;
            font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
            padding:1%;
        }

        input {
            border-radius: 0.3em;
            padding: 0.5%;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese el valor a evaluar:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" class="foxholder"/>
            <br />
            <asp:Label ID="labelResultado" runat="server">0</asp:Label>
        </div>
    </form>
</body>
</html>
