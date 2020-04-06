<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DistanciaKmMillas.aspx.cs" Inherits="DistanciaKmMillas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        Ingrese la velocidad del vehículo en millas por hora:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
        <br />
        Ingrese el tiempo del trayecto del vehículo en minutos:<asp:TextBox ID="textBoxSegundoValor" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
        <br />
        <asp:Label ID="labelResultado" runat="server">0</asp:Label>
    </div>
</asp:Content>
