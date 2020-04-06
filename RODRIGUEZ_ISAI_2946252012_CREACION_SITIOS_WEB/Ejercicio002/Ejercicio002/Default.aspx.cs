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

    protected void btnSumar_Click(object sender, EventArgs e)
    {
        int x = int.Parse(lblResultado.Text);
        x++;
        lblResultado.Text = x.ToString();
    }
}