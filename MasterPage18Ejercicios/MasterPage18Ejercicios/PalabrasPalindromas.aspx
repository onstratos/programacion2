<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PalabrasPalindromas.aspx.cs" Inherits="PalabrasPalindromas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        Ingrese el valor a evaluar:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="button1" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
        <br />
        <asp:Label ID="labelResultado" runat="server"></asp:Label>
    </div>
</asp:Content>
