using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrecuenciaCardiaca : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        int edad;
        double peso;

        double frecuenciaCardiaca = 0;

        try
        {
            edad = int.Parse(textBoxSegundoValor.Text);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido para su edad.";  
            return;
        }

        if (edad < 0)
        {
            labelResultado.Text = "La edad debe ser un número positivo.";
            return;
        }

        try
        {
            peso = double.Parse(textBoxTercerValor.Text);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido para su peso.";
            return;
        }

        if (peso < 0)
        {
            labelResultado.Text = "El peso debe ser un número positivo.";
            return;
        }
   
        if (RadioButtonMasculino.Checked)
        {
            frecuenciaCardiaca = ((210) - (0.5 * edad)) - (peso * 0.20);
        }
        else if (RadioButtonFemenino.Checked)
        {
            frecuenciaCardiaca = ((210) - (0.5 * edad)) - (peso * 0.20) + 4;
        }

        labelResultado.Text = frecuenciaCardiaca.ToString();
    }
}