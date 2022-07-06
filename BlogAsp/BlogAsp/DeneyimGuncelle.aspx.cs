using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeneyimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;
        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLDENEYIMLERTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMLERTableAdapter();
            TxtBaslık.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
            TxtAltBaslık.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
            TxtAcıklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
            TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;


        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMLERTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMLERTableAdapter();
        dt.DeneyimGuncelleme(TxtBaslık.Text, TxtAltBaslık.Text, TxtAcıklama.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
        Response.Redirect("Deneyimler.aspx");
    }
}