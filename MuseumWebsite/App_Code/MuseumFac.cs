using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MuseumFac
/// </summary>
public class MuseumFac
{
    //PROPERITES
    public int _VikingID { get; set; }//fldThemaID
    public string _Title { get; set; }//fldTitle
    public string _description { get; set; }//fldDescriptions
    public string _img { get; set; } //fldImage

    public string _KontaktID { get; set; } //fldKontaktID
    public string _Address { get; set; } //fldAddress
    public string _By { get; set; } //fldBy
    public string _Post { get; set; } //fldPostnr
    public string _Email { get; set; } //fldEmail
    public string _Telephone { get; set; } //fldTelefone

    //Udnyt - lav en instans af - DataAccess-klassen

    //Udnyt - lav en instans af - DataAccess-klassen
    DataAccess DA = new DataAccess();

    public DataTable GetAllThema()
    {
        string SQL = "SELECT * from tblThema";
        SqlCommand CMD = new SqlCommand(SQL);

        return DA.GetData(CMD);


    }
    public DataTable GetThemaFromID(int ID)
    {
        string SQL = @"SELECT * 
                        FROM tblThema 
                            WHERE fldThemaID = @id ";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", ID);
        return DA.GetData(CMD);
    }
    public DataTable RandomThemas()
    {
        string SQL = @"select top 3 *
                        from tblThema
                        order by newID()";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }
    public DataTable Searchthema(string searchword)
    {
        string SQL = @"SELECT * FROM tblThema
                            WHERE fldTitle LIKE @search
                                OR fldDescription LIKE @search";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@search", "%" + searchword + "%");
        return DA.GetData(CMD);
    }

    //    Kontakt Info
    public DataTable GetKontakt()
    {
        string SQL = @"SELECT * FROM tblKontakt";
        SqlCommand CMD = new SqlCommand(SQL);

        return DA.GetData(CMD);

    }


    //  Åbningstider

    public DataTable GetTider()
    {

        string SQL = @"SELECT * FROM tblTider";
        SqlCommand CMD = new SqlCommand(SQL);

        return DA.GetData(CMD);


    }


    public DataTable HentAltKat(int katID)
    {
        string SQL = @"SELECT * FROM tblThema
                    FULL JOIN tblkat
                    ON fldkatID_fk = fldKatID WHERE fldkatID_fk = @katID";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@katID", katID);

        return DA.GetData(CMD);
    }




    //Modifty
    public int CreateThema()
    {
        string SQL = @"INSERT INTO tblThema (fldTitle, fldDescription, fldImage)
                        VALUES (@title,@description,@img)";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@title", _Title);
        CMD.Parameters.AddWithValue("@description", _description);
        CMD.Parameters.AddWithValue("@img", _img);
        return DA.ModiftyData(CMD);

    }
    public int DeleteThema(int ID)
    {
        string SQL = @"DELETE FROM tblThema
                            WHERE fldThemaID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", ID);
        return DA.ModiftyData(CMD);
    }

    public int EditThema()
    {
        string SQL = @"UPDATE tblThema
                SET fldTitle = @title, fldDescription = @description,fldImage = @img
                    WHERE fldThemaID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _VikingID);
        CMD.Parameters.AddWithValue("@title", _Title);
        CMD.Parameters.AddWithValue("@description", _description);
        CMD.Parameters.AddWithValue("@img", _img);
        return DA.ModiftyData(CMD);
    }
    //Modify Kontakt
    public int EditKontakt(int ID)
    {
        string SQL = @"UPDATE tblKontakt
                SET fldKontaktID = @KontaktID, fldAddress = @Address,fldBy = @by, fldPostnr = @post, fldEmail = @email, fldTelefone = @phone
                    WHERE fldKontaktID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", ID);
        CMD.Parameters.AddWithValue("@KontaktID", _KontaktID);
        CMD.Parameters.AddWithValue("@address", _Address);
        CMD.Parameters.AddWithValue("@by", _By);
        CMD.Parameters.AddWithValue("@post", _Post);
        CMD.Parameters.AddWithValue("@email", _Email);
        CMD.Parameters.AddWithValue("@phone", _Telephone);
        return DA.ModiftyData(CMD);

    }
}