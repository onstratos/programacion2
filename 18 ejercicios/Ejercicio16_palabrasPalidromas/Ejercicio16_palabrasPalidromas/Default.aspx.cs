using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        String valorEntrada = textBoxPrimerValor.Text;

        limpiarCampos();

        if (valorEntrada == null || valorEntrada.Length == 0)
        {
            labelResultado.Text = "Debe ingresar una palabra.";
            return;
        }

        string palabraInvertida;
        
        char[] ch = valorEntrada.ToCharArray();

        Array.Reverse(ch);

        palabraInvertida = new string(ch);

        bool b = valorEntrada.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);

        if (b == true)
        {
            labelResultado.Text = "Es palíndroma";
        }
        else
        {
            labelResultado.Text = "No es palíndroma";
        }
    }

    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}