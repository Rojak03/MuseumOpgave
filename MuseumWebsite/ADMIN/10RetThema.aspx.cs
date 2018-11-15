using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_10RetThema : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objThema.GetAllThema();

        foreach (DataRow thema in dt.Rows)
        {
            litSelect.Text += "<div class='deleteBox'><h3>" + thema["fldTitle"] + "</h3>";
            litSelect.Text += "<p><a onclick='return ConfirmDel();' href='13RetThemaConfirm.aspx?themaID=" + thema["fldThemaID"] + "'>Ret</a></p></div>";
            
        }
    }
}