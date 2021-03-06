﻿using System;
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

        if (esBisiesto(valorEvaluado))
        {
            labelResultado.Text = "Es bisiesto";
        }
        else {
            labelResultado.Text = "No es bisiesto";
        }
    }

    public bool esBisiesto(int y)
    {
        if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void limpiarCampos()
    {
        labelResultado.Text = "";
    }
}