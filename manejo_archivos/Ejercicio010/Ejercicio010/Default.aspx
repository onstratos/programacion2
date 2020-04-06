<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="CalendarActividades" runat="server" Width="498px" OnSelectionChanged="CalendarActividades_SelectionChanged"></asp:Calendar>
        <br />
        <asp:TextBox ID="TextBoxActividad" runat="server" Height="100px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
    
    </div>
    </form>
</body>
</html>
