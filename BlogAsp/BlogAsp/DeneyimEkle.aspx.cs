﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeneyimEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMLERTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMLERTableAdapter();
        dt.DeneyimEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
        Response.Redirect("Deneyimler.aspx");
    }
}