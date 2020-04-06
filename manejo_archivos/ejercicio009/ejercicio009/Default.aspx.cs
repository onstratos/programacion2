using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String direccionArchivo = (Server.MapPath(".") + "/contador.txt");

        if (File.Exists(direccionArchivo))
        {
            StreamReader arch1 = new StreamReader(direccionArchivo);
            String valor = arch1.ReadToEnd();
            int contador = int.Parse(valor);
            contador++;
            arch1.Close();

            StreamWriter arch2 = new StreamWriter(direccionArchivo);
            arch2.WriteLine(contador.ToString());
            arch2.Close();
            LabelContador.Text = contador.ToString();
        }   
        else
        {
            StreamWriter arch = new StreamWriter(direccionArchivo);
            arch.WriteLine("1");
            arch.Close();
            LabelContador.Text = "1";
        }
    }
}