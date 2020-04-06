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

        if (valorEvaluado <= 0)
        {
            labelResultado.Text = "El número a evaluar debe ser positivo.";
            return;
        }

        for (int contador = 1; contador <= valorEvaluado; contador++)
        {
            if (esPrimo(contador)) {
                labelResultado.Text += " - " + contador;
            }
        }
    }

    static bool esPrimo(int n)
    {
        if (n <= 1)
            return false;
        
        for (int i = 2; i < n; i++)
            if (n % i == 0)
                return false;

        return true;
    }

    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}