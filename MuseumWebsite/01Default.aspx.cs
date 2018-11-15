using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _01Default : System.Web.UI.Page
{
    MuseumFac objMuseum = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objMuseum.RandomThemas();

            foreach (DataRow thema in dt.Rows)
            {
                litRandom.Text += "<div class='random'>";
                litRandom.Text += "<h4 class='randomname'>";
                litRandom.Text += thema["fldTitle"];
                litRandom.Text += "</h4>";
                litRandom.Text += "<p>" + thema["fldDescription"] + "</p>";
                litRandom.Text += "<a href='02Thema.aspx?themaID=" + thema["fldThemaID"] + "'>" + " Læse Mere..." + "</a>";
                litRandom.Text += "</div>";
            }
        }
    }
}