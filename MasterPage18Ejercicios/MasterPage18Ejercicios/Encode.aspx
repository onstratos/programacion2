<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Encode.aspx.cs" Inherits="Encode" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        <asp:Label Text="Ingrese el valor a evaluar:" runat="server" /><asp:TextBox ID="textBoxPrimerValor" runat="server"></asp:TextBox>
            <br />
            <asp:Label Text="Operación" runat="server" />:
            <br/>
            <asp:RadioButton ID="RadioButtonCodificar" runat="server" Text="Codificar" GroupName="codificacion" Checked="true"/>  
            <br/>
            <asp:RadioButton ID="RadioButtonDecodificar" runat="server" Text="Decodificar" GroupName="codificacion"/>  
            <br />

            <asp:Button ID="buttonResultado" runat="server" Text="Resultado" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server">0</asp:Label>
    </div>
</asp:Content>