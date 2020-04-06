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
        int x1 = int.Parse(textBoxPrimerValor.Text);
        int x2 = int.Parse(textBoxSegundoValor.Text);
        labelResultado.Text = "";

        if (DropDownList1.Items[0].Selected)
        {
            int suma = x1 + x2;
            labelResultado.Text = "La suma de los dos valores es: " + suma;
        }
        else if (DropDownList1.Items[1].Selected)
        {
            int resta = x1 - x2;
            labelResultado.Text = "La diferencia de los dos valores es: " + resta;
        }
        else if (DropDownList1.Items[2].Selected)
        {
            int multi = x1 * x2;
            labelResultado.Text = "El producto de los dos valores es: " + multi;
        }
        else if (DropDownList1.Items[3].Selected)
        {
            int divi = x1 / x2;
            labelResultado.Text = "El cociente de los dos valores es: " + divi;
        }
    }
}