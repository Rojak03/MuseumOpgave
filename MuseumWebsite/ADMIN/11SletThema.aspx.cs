using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_11SletThema : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objThema.GetAllThema();

        foreach (DataRow thema in dt.Rows)
        {
            litResult.Text += "<div class='deleteBox'><h3>" + thema["fldTitle"] + "</h3>";
            litResult.Text += "<p><a onclick='return ConfirmDel();' href='14SletThemaConfirm.aspx?themaID=" + thema["fldThemaID"] + "'>Slet</a></p></div>    ";
        }
    }
}