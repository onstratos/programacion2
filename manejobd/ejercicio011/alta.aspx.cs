using System;
using System.Data.SqlClient;

public partial class alta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonAlta_Click(object sender, EventArgs e)
    {
        //string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-S9LRNEN\\SQLEXPRESS;Initial Catalog=base1;Integrated Security=true;");

        conexion.Open();



        SqlCommand comando = new SqlCommand("insert into usuarios(nombre, clave, mail) values('" + this.TextBoxNombre.Text + "', '" + this.TextBoxClave.Text + "', '" + this.TextBoxMail.Text + "')", conexion);

        comando.ExecuteNonQuery();
        LabelEstado.Text = "Se registró el usuario.";
        conexion.Close();
    }
}