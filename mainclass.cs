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
using System.Globalization;
using System.Text;
using System.IO;
/// <summary>
/// Summary description for mainclass
/// </summary>
public class mainclass
{

    MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
    //MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=timedb;UID=root;PWD=svplchennai;Convert Zero Datetime=True");

    MySqlCommand cmd = new MySqlCommand();
    MySqlDataAdapter dapp = new MySqlDataAdapter();
    MySqlDataReader reader;
    public HiddenField teamuserid = new HiddenField();
    public string nullmessage = "<script> swal(\"Sorry!\", \"You can't leave this empty. !\", \"error\");</script>";
    public string savemessage = "<script> swal(\"Good job!\", \"Record Saved Successfully!\", \"success\");</script>";
    public string activemessage = "<script> swal(\"Good job!\", \"User Status Modified!\", \"success\");</script>";
    public string deletemessage = "<script> swal(\"Good job!\", \"Record Deleted Successfully!\", \"success\");</script>";
    public string deletemessages = "<script> swal({   title: \"Are you sure?\",   text: \"You will not be able to recover this imaginary file!\",   type: \"warning\",   showCancelButton: true,   confirmButtonColor: \"#DD6B55\",   confirmButtonText: \"Yes, delete it!\",   closeOnConfirm: false }, function(){   swal(\"Deleted!\", \"Your imaginary file has been deleted.\", \"success\"); });</script>";
    public string message = "<script> swal({   title: \"Hai Friend!\",   text: \"This User have no Jobs\",   imageUrl: \"img/no-record-found.jpg\" });</script>";
    public string Errormessage = "<script> swal(\"Sorry!\", \"Error Occured During  Save Operation!\", \"error\");</script>";
    public string updatemessage = "<script> swal(\"Good job!\", \"Record Update Successfully!\", \"success\");</script>";
    public string Valid = "<script> swal(\"Sorry!\", \"Error Occured During  Time Operation!\", \"error\");</script>";

    DataSet ds = new DataSet();
    public mainclass()
    {
        //
        // TODO: Add constructor logic here
        //


    }
    public object GetSession(string teamuserid)
    {
        if (HttpContext.Current.Session[teamuserid] != null)
        {
            return HttpContext.Current.Session[teamuserid];
        }
        else
        {
            return string.Empty;
        }
    }
    public string trycatch(string Message)
    {
        string trycatchError = "<script> swal(\"Sorry!\", \"" + Message.ToString() + "\", \"error\");</script>";
        return trycatchError;
    }
    public string DateConvert(string date)
    {
        try
        {
            string[] datesplit = date.Split('/');
            string newdate = datesplit[2] + "-" + datesplit[1] + "-" + datesplit[0];
            return newdate;
        }
        catch
        {
            return "";

        }
    }
    public void loadddllist(string query, DropDownList ddlDrop)
    {
        conn.Open();
        ds = new DataSet();
        dapp = new MySqlDataAdapter(query, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        ddlDrop.DataSource = ds;
        ddlDrop.DataTextField = "name";
        ddlDrop.DataValueField = "code";
        ddlDrop.DataBind();
        ddlDrop.Items.Insert(0, new ListItem("Select", "0"));
        ds.Dispose();
        conn.Close();
    }
    public void loadddllists(string query, ListBox ddlDrop)
    {
        conn.Open();
        ds = new DataSet();
        dapp = new MySqlDataAdapter(query, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        ddlDrop.DataSource = ds;
        ddlDrop.DataTextField = "name";
        ddlDrop.DataValueField = "code";
        ddlDrop.DataBind();
        //  ddlDrop.Items.Insert(0, new ListItem("Select", "0"));
        ds.Dispose();
        conn.Close();
    }
    public void loadddllistss(string query, DropDownList ddlDrop)
    {
        conn.Open();
        ds = new DataSet();
        dapp = new MySqlDataAdapter(query, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        ddlDrop.DataSource = ds;
        ddlDrop.DataTextField = "name";
        ddlDrop.DataValueField = "code";
        ddlDrop.DataBind();
        //  ddlDrop.Items.Insert(0, new ListItem("Select", "0"));
        ds.Dispose();
        conn.Close();
    }
    public void loadddllistid(string query, DropDownList ddlDrop)
    {
        conn.Open();
        ds = new DataSet();
        dapp = new MySqlDataAdapter(query, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        ddlDrop.DataSource = ds;
        ddlDrop.DataTextField = "name";
        ddlDrop.DataValueField = "code";
        ddlDrop.DataBind();
        ddlDrop.Items.Insert(0, new ListItem("Select", ""));
        ds.Dispose();
        conn.Close();
    }
    public string CountofPromocodeTod(int PromoCode, int count, int userid)
    {
        string promocode = "";
        string str = "SELECT count(*) as Counts FROM promoissuetable  where PromoCode =" + PromoCode + " and date=curdate()";
        MySqlCommand cmd = new MySqlCommand(str, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        ds = new DataSet();
        dapp = new MySqlDataAdapter(str, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);

        Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0]["Counts"].ToString());

        conn.Close();
        if (First <= count)
        {
            if (validuser(userid, PromoCode))
            {
                promocode = PromocodeGenaration();
            }
        }
        return promocode;
    }
    protected string PromocodeGenaration()
    {
        string possibles = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
        string passwords = "";
        Random rd = new Random();

        for (int i = 0; i < 10; i++)
        {
            passwords += possibles[rd.Next(0, possibles.Length)].ToString();
        }
        return passwords.ToString();
    }
    public DataSet GetLoginTime(int uid)
    {
        string str = "SELECT distinct daid, uid, ddate, LoginTime, LogoutTime FROM dailytime where ddate=curdate() and uid='" + uid.ToString() + "' order by daid desc";
        MySqlCommand cmd = new MySqlCommand(str, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        ds = new DataSet();
        dapp = new MySqlDataAdapter(str, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        ds.Dispose();
        conn.Close();
        return ds;

    }
    protected bool validuser(int usercode, int PromoCode)
    {
        string str = "SELECT count(*) as Counts FROM promoissuetable  where PromoCode =" + PromoCode + " and date=curdate() and uid=" + usercode + "";
        MySqlCommand cmd = new MySqlCommand(str, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        ds = new DataSet();
        dapp = new MySqlDataAdapter(str, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0]["Counts"].ToString());
        if (First > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void IssuePromo(int usercode, int PromoCode)
    {
        Label labstatus = new Label();
        //string str = "insert into promoissuetable(PromoIssueId, UId, Date, PromoCode)";

        MySqlCommand cmd = new MySqlCommand("SPN_IssuePromo", conn);//sp_inserttimernew
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("Uids", usercode);
        cmd.Parameters.Add("PromoCode", PromoCode);
        MySqlParameter parm2 = new MySqlParameter("output", MySqlDbType.VarChar);
        parm2.Size = 50;
        parm2.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(parm2);
        cmd.ExecuteNonQuery();
        //labstatus.Text = cmd.Parameters["output"].Value.ToString();
        conn.Close();
    }
    public DataSet GetClientID(int uid)
    {
        string str = "SELECT DISTINCT if(uwc.pid is null,'' ,uwc.pid) as pids FROM userwiseclient as uwc where uwc.uid ='" + uid.ToString() + "' ";
        MySqlCommand cmd = new MySqlCommand(str, conn);
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        ds = new DataSet();
        dapp = new MySqlDataAdapter(str, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(ds);
        string pidstr = ds.Tables[0].Rows[0]["pids"].ToString();
        string cmdstr = "select pid as code ,clientname as name from project where pid in (" + pidstr.ToString() + ") and access!=0 Order By Name ";
        MySqlCommand cmdsearch = new MySqlCommand(cmdstr, conn);
        DataSet dss = new DataSet();
        dapp = new MySqlDataAdapter(cmdstr, conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(dss);
        dss.Dispose();
        ds.Dispose();
        conn.Close();
        return dss;

    }
    public DataSet GetAssignTo(string assignto)
    {

        MySqlCommand cmdsearch = new MySqlCommand("SPN_CountOfJobHistory", conn);
        DataSet dss = new DataSet();
        dapp = new MySqlDataAdapter("SPN_CountOfJobHistory", conn);
        dapp.SelectCommand.CommandTimeout = 90;
        dapp.Fill(dss);
        dss.Dispose();
        conn.Close();
        return dss;

    }   
    public string GetGridviewData(GridView gv)
    {
        StringBuilder strBuilder = new StringBuilder();
        StringWriter strWriter = new StringWriter(strBuilder);
        HtmlTextWriter htw = new HtmlTextWriter(strWriter);
        gv.RenderControl(htw);
        return strBuilder.ToString();
    }
    public void LogStatus()
    {
        try
        {
            DateTime Stime = DateTime.Parse(HttpContext.Current.Session["StartTime"].ToString());
            HttpContext.Current.Session["EndTime"] = DateTime.Now.ToString("hh:mm:ss");
            HttpContext.Current.Session["LogOutTime"] = DateTime.Now.ToString("hh:mm:ss tt");
            DateTime Etime = DateTime.Parse(HttpContext.Current.Session["EndTime"].ToString());
            TimeSpan CDur = Etime - Stime;
            HttpContext.Current.Session["WorkTime"] = CDur.ToString();
            UpdateWorkTimerEstimation();
            HttpContext.Current.Session["Etime"] = DateTime.Now.ToString("hh:mm:ss");
            InsertUser.Logout(Convert.ToInt32(HttpContext.Current.Session["Uid"].ToString()));
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Session.RemoveAll();
            HttpContext.Current.Response.Redirect("Index.aspx");
        }
        catch (Exception ex)
        {          
            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + ex.Message + "')", true);
            // var page = HttpContext.Current.CurrentHandler as Page;

            //  ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('Success');window.location ='Home.aspx';", true);
        }
    }
    public void UpdateWorkTimerEstimation()
    {
        try
        {
            int uids = 0;
            string LogoutTime = "00:00:00";
            string curdate = DateTime.Now.ToString("yyyy-MM-dd");
            uids = Convert.ToInt16(HttpContext.Current.Session["uid"].ToString());
            LogoutTime = HttpContext.Current.Session["LogOutTime"].ToString();
            MySqlCommand cmd = new MySqlCommand("spn_LogoutStatuss", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("uids", HttpContext.Current.Session["uid"].ToString());
            cmd.Parameters.Add("dates", curdate.ToString());
            cmd.Parameters.Add("worktimes", HttpContext.Current.Session["WorkTime"].ToString());
            cmd.Parameters.Add("Logintimes", HttpContext.Current.Session["LoginTime"].ToString());
            cmd.Parameters.Add("LogoutTimes", LogoutTime.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception ex)
        {
            var page = HttpContext.Current.CurrentHandler as Page;

            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + ex.Message + "')", true);
        }
    }

}