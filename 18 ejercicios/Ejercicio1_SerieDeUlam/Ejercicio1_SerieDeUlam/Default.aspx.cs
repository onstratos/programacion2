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

        String resultado = "";

        int ultimoNumero = valorEvaluado;

        while (ultimoNumero > 1) {

            if (esPar(ultimoNumero)) {
                ultimoNumero = ultimoNumero / 2;
            } else {
                ultimoNumero = (ultimoNumero * 3) + 1;
            }
            resultado += "<br/> " + ultimoNumero.ToString();
        }
        labelResultado.Text = resultado;
    }

    private Boolean esPar(int valorEvaluado) {
        return (valorEvaluado % 2) == 0;
    }
}