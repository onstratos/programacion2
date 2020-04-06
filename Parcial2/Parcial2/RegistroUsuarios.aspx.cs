using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistroUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        String nombre = txtnombre.Text;
        String apellido = txtapellido.Text;
        String genero = (RadioButtonMasculino.Checked) ? "Masculino" : "Femenino";
        String email = txtemail.Text;
        String direccion = txtdireccion.Text;
        String departamento = cbdepartamentos.SelectedValue;
        String municipio = cbmunicipios.SelectedValue;
        String fechanac = txtfechanac.Text;

        labelResultado.Text = "Nombre: " + nombre + "<br>" +
            "Apellido: " + apellido + "<br>" +
            "Género: " + genero + "<br>" +
            "Email: " + email + "<br>" +
            "Dirección: " + direccion + "<br>" +
            "Departamento: " + departamento + "<br>" +
            "Municipio: " + municipio + "<br>" +
            "Fecha de nacimiento: " + fechanac + "<br>";
    }
}