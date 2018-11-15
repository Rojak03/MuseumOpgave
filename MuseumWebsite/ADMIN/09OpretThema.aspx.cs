using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADMIN_09OpretThema : System.Web.UI.Page
{
    MuseumFac objThema = new MuseumFac();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnMake_Click(object sender, EventArgs e)
    {
        objThema._Title = txtName.Text;
        objThema._description = txtDesc.Text;

        if (FuImg.HasFile)
        {
            objThema._img = PictureSave.SavePicture(FuImg.PostedFile, "Ímg/");
        }
        else
        {
            objThema._img = "";
        }
        int totalThema = objThema.CreateThema();

        if (totalThema > 0)
        {
            pnlCreate.Visible = false;
            litCreated.Text = "Thema Oprette!";
            txtName.Text = "";
            txtDesc.Text = "";
        }
        else
        {
            litCreated.Text = "Something Went Wrong! Try Again";
        }

    }
}