using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _06kontakt : System.Web.UI.Page
{
    MuseumFac objAddress = new MuseumFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objAddress.GetKontakt();

        foreach (DataRow kontakt in dt.Rows)
        {
            litAdress.Text += "<li><p>" + kontakt["fldAdress"] + "</p></li>";
            litAdress.Text += "<li><p>" + kontakt["fldBy"] + kontakt["fldPostnr"] + "</p></li>";
            litAdress.Text += "<li><p>" + kontakt["fldEmail"] + "</p></li>";
            litAdress.Text += "<li><p>" + kontakt["fldTelefone"] + "</p></li>";
        }
    }
}