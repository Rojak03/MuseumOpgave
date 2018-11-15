using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _025Kategori : System.Web.UI.Page
{

    MuseumFac objThema = new MuseumFac();
    DataTable dt = new DataTable();
    KatFac objKat = new KatFac();

    protected void Page_Load(object sender, EventArgs e)
    {

        int katID;

        if (int.TryParse(Request.QueryString["KategoriID"], out katID))
        {
            dt = objThema.HentAltKat(katID);

            foreach (DataRow thema in dt.Rows)
            {
                litThemaResult.Text += "<div class='themaBox'><h2 class='name clear'>" + thema["fldTitle"];
                litThemaResult.Text += "</h2><p class='description'>" + thema["fldDescription"] + "</p>";
                if (thema["fldImage"] != "")
                {
                    litThemaResult.Text += "</p><img class='clear' src='Img/" + thema["fldImage"] + "'alt=" + thema["fldTitle"] + "Image>";
                }
                //else
                //{
                //    litThemaResult.Text += "</p><img class='clear' src='img/imgcoming.png'alt=Coming Soon></div>";
                //}
                litThemaResult.Text += "<a class='link' href='04SpecThema.aspx?themaID=" + thema["fldThemaID"] + "'>Læs mere</a>";
                litThemaResult.Text += "</div>";
            }

        }
    }
}