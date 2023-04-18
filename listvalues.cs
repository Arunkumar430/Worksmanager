using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for listvalues
/// </summary>
public class listvalues
{

    MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
    //MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=timedb;UID=root;PWD=svplchennai;Convert Zero Datetime=True");
    MySqlCommand cmd = new MySqlCommand();
    MySqlDataAdapter dapp = new MySqlDataAdapter();
    MySqlDataReader reader;
    DataSet ds = new DataSet();
    string str = "";
    public listvalues()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public DataSet GetWorkStatus(int uid)
    {
        if ((uid == 61) || (uid == 90))
        {
            str = "SELECT wno as code  ,workstatus as name FROM workstatus where wno in (1,4,22,16,5,24,17,25,6,11,23) order by field(wno,1,4,23,22,16,5,24,17,25,6,11);";
        }
        else
        {
            str = "SELECT wno as code,workstatus as name FROM workstatus where wno in (1,4)  order by field(wno,1,4);";

        }

        MySqlCommand cmd = new MySqlCommand(str, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        DataSet dss = new DataSet();
        dapp = new MySqlDataAdapter(str, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(dss);
        dss.Dispose();
        ds.Dispose();
        conn.Close();
        return dss;
    }
}