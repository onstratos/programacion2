using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class carga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonConfirmar_Click(object sender, EventArgs e)
    {
        StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/curriculums.txt", true);
        arch.WriteLine("INFORMACIÓN PERSONAL<br>");
        arch.WriteLine("Nombre: " + TextBoxNombre.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Apellido: " + TextBoxApellido.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Teléfono: " + TextBoxTelefono.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<br>");
        arch.WriteLine("ESTUDIOS<br>");
        arch.WriteLine(TextBoxEstudios.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<br>");
        arch.WriteLine("EXPERIENCIA LABORAL<br>");
        arch.WriteLine(TextBoxExpLaboral.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<br>");
        arch.WriteLine("REFERENCIAS<br>");
        arch.WriteLine(TextBoxReferencias.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<hr>");
        arch.Close();

        LabelEstado.Text = "Datos registrados";
    }
}