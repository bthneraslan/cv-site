using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OdulGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;
        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();
            TxtOdul.Text = dt.OdulGetir(Convert.ToInt16(x))[0].ODUL;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();
        dt.OdulGuncelle(TxtOdul.Text, Convert.ToInt16(TxtID.Text));
        Response.Redirect("Oduller.aspx");
    }
}