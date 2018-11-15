using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class KatFac
{
    DataAccess DA = new DataAccess();

    public DataTable HentAllekat()
    {
        string SQL = @"SELECT * FROM tblkat";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }
}