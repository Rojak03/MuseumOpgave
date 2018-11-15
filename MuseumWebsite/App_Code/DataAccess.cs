using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    string conn = ConfigurationManager.ConnectionStrings["ConnViking"].ConnectionString;
    public DataTable GetData(SqlCommand CMD)
    {


        //How to connect to DB
        SqlConnection objConn = new SqlConnection(conn);
        CMD.Connection = objConn;


        SqlDataAdapter objDA = new SqlDataAdapter();
        objDA.SelectCommand = CMD;


        //DataTable Show the Result
        DataTable dt = new DataTable();
        objDA.Fill(dt);

        //Show Result
        return dt;
    }
    public int ModiftyData(SqlCommand CMD)
    {

        SqlConnection objConn = new SqlConnection(conn);
        CMD.Connection = objConn;
        objConn.Open();
        int rowsaffected = CMD.ExecuteNonQuery();
        objConn.Close();
        return rowsaffected;





    }
}