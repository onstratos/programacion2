<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrecuenciaCardiaca.aspx.cs" Inherits="FrecuenciaCardiaca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
</asp:Content>