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
        int x1 = int.Parse(textBoxPrimerValor.Text);
        int x2 = int.Parse(textBoxSegundoValor.Text);
        int resultado;

        if (radioButtonSumar.Checked)
        {
            resultado = x1 + x2;
            labelResultado.Text = "La suma de los dos valores es: " + resultado;
        }
        else if (radioButtonRestar.Checked)
        {
            resultado = x1 - x2;
            labelResultado.Text = "La diferencia de los dos valores es: " + resultado;
        }
    }
}