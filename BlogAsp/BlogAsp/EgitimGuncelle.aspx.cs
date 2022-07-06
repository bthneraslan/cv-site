using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
            TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
            TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
            TxtGno.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNO;
            TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLEGITIMTableAdapter dt1 = new DataSetTableAdapters.TBLEGITIMTableAdapter();
        dt1.EgitimGuncelle(TxtBaslik.Text,TxtAltBaslik.Text,TxtAciklama.Text,TxtGno.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
        Response.Redirect("Egitimler.aspx");
    }
}