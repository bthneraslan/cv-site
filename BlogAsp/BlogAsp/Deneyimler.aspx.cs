using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Deneyimler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMLERTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMLERTableAdapter();
        Repeater1.DataSource= dt.DeneyimListele();
        Repeater1.DataBind();
    }
}