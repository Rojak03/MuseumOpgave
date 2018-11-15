using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    MuseumFac objAddress = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objAddress.GetKontakt();

        foreach (DataRow kontakt in dt.Rows)
        {
            litAdress.Text += "<ul><li><p>" + kontakt["fldAdress"] + "</p></li>";
            litAdress.Text += "<li><p>" + kontakt["fldBy"] + kontakt["fldPostnr"] + "</p></li>";
            litAdress.Text += "<li><p>" + kontakt["fldEmail"] + "</p></li>";
            litAdress.Text += "<li><p>" + kontakt["fldTelefone"] + "</p></li></ul>";
        }


        dt = objAddress.GetTider();

        foreach (DataRow tid in dt.Rows)
        {
            litTid.Text += "<ul><li><p>" + tid["fldAabningstid"] + "</p></li>";
            litTid.Text += "<li><p>" + tid["fldHverdage"] + "</p></li>";
            litTid.Text += "<li><p>" + tid["fldTorsdag"] + "</p></li>";
            litTid.Text += "<li><p>" + tid["fldWogH"] + "</p></li></ul>";
        }


    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string searchword = txtSearch.Text;

        Response.Redirect("03SearchResult.aspx?searchword=" + searchword);
    }
}
