using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _03SearchResult : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        string SearchKey = Request.QueryString["searchword"];
        litSearched.Text = SearchKey;

        dt = objThema.Searchthema(SearchKey);
        foreach (DataRow thema in dt.Rows)
        {
            litResult.Text += "<div class='resultBox'><h2>" + thema["fldTitle"] + "</h2>";
            litResult.Text += "<a href='02Thema.aspx?ThemaID=" + thema["fldThemaID"] + "'>Read More</a></div>";
        }
        
    }
}