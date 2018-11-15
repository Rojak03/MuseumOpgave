using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_13RetThemaConfirm : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            int ThemaID;

            if (int.TryParse(Request.QueryString["themaID"], out ThemaID))
            {
                dt = objThema.GetThemaFromID(ThemaID);

                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["fldThemaID"].ToString();
                    txtTitle.Text = dt.Rows[0]["fldTitle"].ToString();
                    txtDesc.Text = dt.Rows[0]["fldDescription"].ToString().Replace("<br />", Environment.NewLine);

                    if (!string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
                    {
                        imgThema.ImageUrl = "../img/" + dt.Rows[0]["fldImage"];
                    }
                    else
                    {
                        pnlImage.Visible = false;
                    }

                }
                else
                {
                    Response.Redirect("/ADMIN/10RetThema.aspx");
                }
            }
            else
            {
                Response.Redirect("/ADMIN/10RetThema.aspx");
            }
        }
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        objThema._VikingID = Convert.ToInt32(txtID.Text);
        objThema._Title = txtTitle.Text;
        objThema._description = txtDesc.Text;
        

        objThema._img = "";

        if (Path.GetFileName(imgThema.ImageUrl).Length > 0 && !chkDelImg.Checked)
        {
            objThema._img = Path.GetFileName(imgThema.ImageUrl);
        }
        if (fuImg.HasFile)
        {
            objThema._img = PictureSave.SavePicture(fuImg.PostedFile, "img/");
        }

        int totalThemaEdited = objThema.EditThema();

        if (totalThemaEdited > 0)
        {
            litMessage.Text = "<h2>Thema er nu Rettet</h2>";
        }
        else
        {
            litMessage.Text = "<h2>Noget gik gladet!</h2>";
        }
    }
}