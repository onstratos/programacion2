<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SerieUlam.aspx.cs" Inherits="SerieUlam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        Ingrese el valor a evaluar:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" class="foxholder" />
        <br />
        <asp:Label ID="labelResultado" runat="server">0</asp:Label>
    </div>
</asp:Content>

