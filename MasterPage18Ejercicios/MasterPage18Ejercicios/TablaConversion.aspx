<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TablaConversion.aspx.cs" Inherits="TablaConversion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            Ingrese el valor máximo para la tabla de conversión (En kilogramos):<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server"></asp:Label>
        </div>
</asp:Content>