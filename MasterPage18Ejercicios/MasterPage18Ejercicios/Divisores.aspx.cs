using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Divisores : System.Web.UI.Page
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
            labelResultado.Text = "El número a evaluar debe ser distinto a cero";
            return;
        }

        for (int contador = 1; contador <= valorEvaluado; contador++) 
        {
            if (esDivisor(valorEvaluado, contador)) {
                labelResultado.Text += contador + " <br/>";
            }
        }
        
    }

    private bool esDivisor(int valorEvaluado, int contador) {
        if ((valorEvaluado % contador) == 0)
        {
            return true;
        }
        else {
            return false;
        }
    }

    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}