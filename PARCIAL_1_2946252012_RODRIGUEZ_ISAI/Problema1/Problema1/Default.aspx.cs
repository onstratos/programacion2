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

        if (valorEvaluado < 0 || (valorEvaluado % 2) != 0)
        {
            labelResultado.Text = "El número a evaluar debe ser entero y positivo.";
            return;
        }
        
        int suma = 0, n;
        n = valorEvaluado;

        for (int i = 1; i < valorEvaluado; i++)
        {
            if (valorEvaluado % i == 0)
            {
                suma = suma + i;
            }
        }
        if (suma == n)
        {
            labelResultado.Text = "El número ingresado es perfecto.";
        }
        else
        {
            labelResultado.Text = "El número ingresado no es perfecto.";
        }
    }

    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}