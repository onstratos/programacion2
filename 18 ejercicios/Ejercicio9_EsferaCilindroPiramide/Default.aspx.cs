using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * area de una esfera: A = 4 * pi * radio ^ 2
 * area de un cilindro: A = 2 * pi * radio * (radio * altura)
 * area de un paralelepipedo (cubo): A = 6 * arista^2
 * */
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        refrescarCampos();
    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {

    }

    protected void DropDownList_Changed(object sender, EventArgs e)
    {
        refrescarCampos();
    }

    protected void refrescarCampos()
    {
        ocultarCampos();

        if (figurasLista.SelectedItem.Value == "esfera")
        {
            labelRadio.Visible = true;
            textBoxRadio.Visible = true;
        }

        else if (figurasLista.SelectedItem.Value == "cilindro")
        {
            labelRadio.Visible = true;
            textBoxRadio.Visible = true;

            labelAltura.Visible = true;
            textBoxAltura.Visible = true;
        }

        else if (figurasLista.SelectedItem.Value == "piramide")
        {

        }

        else if (figurasLista.SelectedItem.Value == "paralelepipedo") //cubo
        {
            labelAristaCubo.Visible = true;
            textBoxAristaCubo.Visible = true;
        }
    }

    protected void ocultarCampos()
    {
        labelRadio.Visible = false;
        textBoxRadio.Visible = false;

        labelAltura.Visible = false;
        textBoxAltura.Visible = false;

        labelAristaCubo.Visible = false;
        textBoxAristaCubo.Visible = false;
    }
}