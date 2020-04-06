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
        System.Diagnostics.Debug.Write(Server.MapPath(".") + "/");

        String fecha = CalendarActividades.TodaysDate.Day.ToString() +
                       CalendarActividades.TodaysDate.Month.ToString() +
                       CalendarActividades.TodaysDate.Year.ToString();

        if(File.Exists(Server.MapPath(".") + "/" + fecha))
        {
            StreamReader sr = new StreamReader(Server.MapPath(".") + "/" + fecha);
            TextBoxActividad.Text = sr.ReadToEnd();
            sr.Close();
        }
    }

    protected void CalendarActividades_SelectionChanged(object sender, EventArgs e)
    {
        String fecha = CalendarActividades.SelectedDate.Day.ToString() +
                       CalendarActividades.SelectedDate.Month.ToString() +
                       CalendarActividades.SelectedDate.Year.ToString();

        System.Diagnostics.Debug.Write("Seleccionando: " + fecha);

        if (File.Exists(Server.MapPath(".") + "/" + fecha))
        {
            StreamReader sr = new StreamReader(Server.MapPath(".") + "/" + fecha);
            TextBoxActividad.Text = sr.ReadToEnd();
            sr.Close();
        }
        else
        {
            TextBoxActividad.Text = "";
        }
    }

    protected void ButtonGuardar_Click(object sender, EventArgs e)
    {
        String fecha = CalendarActividades.SelectedDate.Day.ToString() +
                       CalendarActividades.SelectedDate.Month.ToString() +
                       CalendarActividades.SelectedDate.Year.ToString();

        StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/" + fecha, true);
        arch.WriteLine(TextBoxActividad.Text);
        arch.Close();

        System.Diagnostics.Debug.Write("Guardando: " + TextBoxActividad.Text);
    }
}