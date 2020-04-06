using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Encode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public static string codificar(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public static string decodificar(string base64EncodedData)
    {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }

    protected void buttonResultado_Click(object sender, EventArgs e)
    {
        String valorEvaluado = textBoxPrimerValor.Text;

        if (valorEvaluado == null || valorEvaluado.Length == 0)
        {
            labelResultado.Text = "Por favor ingrese una cadena para codificar o decodificar";
            return;
        }

        if(RadioButtonCodificar.Checked)
        {
            labelResultado.Text = codificar(valorEvaluado);
        }
        else if(RadioButtonDecodificar.Checked)
        {
            labelResultado.Text = decodificar(valorEvaluado);
        }
    }
}