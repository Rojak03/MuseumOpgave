using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Admin
/// </summary>
public class Adminfac
{
    DataAccess DA = new DataAccess();
    //Find the User _login

    public DataTable FindUser(string UserName, string Password)
    {
        string SQL = @"SELECT *
                            FROM tblAdmin
                                WHERE fldBrugerNavn = @user AND fldPassword = @pw";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@user", UserName);
        CMD.Parameters.AddWithValue("@pw", Password);

        return DA.GetData(CMD);
    }
}