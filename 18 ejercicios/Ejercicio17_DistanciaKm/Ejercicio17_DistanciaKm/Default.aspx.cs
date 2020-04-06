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
        double velocidadKm, tiempoTrayecto, distancia;

        try
        {
            velocidadKm = double.Parse(textBoxPrimerValor.Text);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido para la velocidad del vehículo.";
            return;
        }

        if (velocidadKm <= 0)
        {
            labelResultado.Text = "La velocidad del vehículo debe ser un número positivo.";
            return;
        }

        try
        {
            tiempoTrayecto = double.Parse(textBoxSegundoValor.Text);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido para la duración del trayecto.";
            return;
        }

        if (tiempoTrayecto <= 0)
        {
            labelResultado.Text = "La duración del trayecto del vehículo debe ser un número positivo.";
            return;
        }

        distancia = velocidadKm * (tiempoTrayecto / 60);

        labelResultado.Text = "La distancia recorrida es: " + distancia.ToString("0.00") + " kilómetros.";
    }
}