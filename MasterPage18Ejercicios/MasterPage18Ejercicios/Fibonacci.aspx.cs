using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fibonacci : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        String valorEntrada = textBoxPrimerValor.Text;
        int valorEvaluado;

        limpiarCampos();

        try
        {
            valorEvaluado = int.Parse(valorEntrada);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido.";
            return;
        }

        if (valorEvaluado <= 0)
        {
            labelResultado.Text = "El número a evaluar debe ser distinto a cero.";
            return;
        }
        
        int a = 0, b = 1, c = 0;

        for (int i = 2; i < valorEvaluado; i++)
        {
            c = a + b;

            labelResultado.Text += c + "<br/>";

            a = b;
            b = c;
        }
    }


    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}