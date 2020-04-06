<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Divisores.aspx.cs" Inherits="Divisores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
            Ingrese el valor a evaluar:<asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server"></asp:Label>
        </div>
</asp:Content>
