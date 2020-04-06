using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DistanciaKmMillas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        double velocidadKm, velocidadMillas, tiempoTrayecto, distancia;

        try
        {
            velocidadMillas = double.Parse(textBoxPrimerValor.Text);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido para la velocidad del vehículo.";
            return;
        }

        if (velocidadMillas <= 0)
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

        velocidadKm = velocidadMillas * 1.609;
        distancia = velocidadKm * (tiempoTrayecto / 60);

        labelResultado.Text = "La distancia recorrida es: " + distancia.ToString("0.00") + " kilómetros.";
    }
}