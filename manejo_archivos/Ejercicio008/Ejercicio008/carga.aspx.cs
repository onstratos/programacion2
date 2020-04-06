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
        StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/visitas.txt", true);
        arch.WriteLine("Nombre: " + TextBoxNombre.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("País: " + TextBoxPais.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Comentarios<br>");
        arch.WriteLine(TextBoxComentarios.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<hr>");
        arch.Close();

        LabelEstado.Text = "Datos registrados";
    }
}