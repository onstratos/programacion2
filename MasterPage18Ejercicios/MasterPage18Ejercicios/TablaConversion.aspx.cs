﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TablaConversion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        String valorEntrada = textBoxPrimerValor.Text;
        double valorEvaluado;

        limpiarCampos();

        try
        {
            valorEvaluado = Double.Parse(valorEntrada);
        }
        catch (FormatException)
        {
            labelResultado.Text = "Por favor ingrese un número válido.";
            return;
        }

        if (valorEvaluado <= 0)
        {
            labelResultado.Text = "El número a evaluar debe ser positivo";
            return;
        }

        int valorKg;
        double valorLibras; 

        for (int contador = 1; contador <= valorEvaluado; contador++)
        {
            valorKg = contador;
            valorLibras = valorKg / 0.45359237;

            labelResultado.Text += valorKg + " Kg. = " + valorLibras + " Lb.<br>";
        }
    }

    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}