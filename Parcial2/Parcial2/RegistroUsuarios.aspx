<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistroUsuarios.aspx.cs" Inherits="RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">

        <div class="col-12">
            Nombre:<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br />
            Apellidos: <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
            <br />
            Correo electrónico: <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            Teléfono: <asp:TextBox ID="cel" runat="server"></asp:TextBox>
            <br />
            Género: <asp:RadioButton ID="RadioButtonMasculino" runat="server" Text="Masculino" GroupName="sexo"/> <asp:RadioButton ID="RadioButtonFemenino" runat="server" Text="Femenino" GroupName="sexo"/>  
            <br />
            Dirección: <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            <br />
            Departamento: <asp:DropDownList ID="cbdepartamentos" AppendDataBoundItems="true" runat="server">
                <asp:ListItem Text="San Salvador" Value="San Salvador" />
                <asp:ListItem Text="La Libertad" Value="La Libertad" />
                </asp:DropDownList>
            <br />
            Municipio: <asp:DropDownList ID="cbmunicipios" AppendDataBoundItems="true" runat="server">
                <asp:ListItem Text="Colón" Value="Colón" />
                <asp:ListItem Text="Ciudad Arce" Value="Ciudad Arce" />
                <asp:ListItem Text="Cuscatancingo" Value="Cuscatancingo" />
                <asp:ListItem Text="Apopa" Value="Apopa" />
                </asp:DropDownList>
            <br />
            Fecha de nacimiento: <asp:TextBox ID="txtfechanac" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="buttonResultado" runat="server" Text="Enviar" OnClick="buttonResultado_Click" />
            <br />
            <asp:Label ID="labelResultado" runat="server">_</asp:Label>
        </div>
    </div>

</asp:Content>

