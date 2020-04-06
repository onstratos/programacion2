using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MinimoComunMultiplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        String valorEntrada1 = textBoxPrimerValor.Text;
        String valorEntrada2 = textBoxSegundoValor.Text;

        int valorEvaluado1, valorEvaluado2;

        limpiarCampos();

        try
        {
            valorEvaluado1 = int.Parse(valorEntrada1);
            valorEvaluado2 = int.Parse(valorEntrada2);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido.";
            return;
        }

        if (valorEvaluado1 <= 0 || valorEvaluado2 <= 0)
        {
            labelResultado.Text = "Los números a evaluar deben ser positivos.";
            return;
        }

        if (valorEvaluado1 == valorEvaluado2)
        {
            labelResultado.Text = "Los números a evaluar deben ser distintos entre sí.";
            return;
        }

        double resultado;

        for (int contador = 1; contador <= 10; contador++)
        {
            resultado = mcm(valorEvaluado1, valorEvaluado2);
            labelResultado.Text = resultado.ToString();
        }
    }

    int mcm(int a, int b)
    {
        return (a * b) / mcd(a, b);
    }

    int mcd(int a, int b)
    {
        if (b == 0) return a;
        else return mcd(b, a % b);
    }
    
    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}