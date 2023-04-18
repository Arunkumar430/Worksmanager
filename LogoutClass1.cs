using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Text;
/// <summary>
/// Summary description for LogoutClass1
/// </summary>
public class LogoutClass1
{
    MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
    //MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=timedb;UID=root;PWD=svplchennai;Convert Zero Datetime=True");

    MySqlCommand cmd = new MySqlCommand();
    MySqlDataAdapter dapp = new MySqlDataAdapter();
    MySqlDataReader reader;
    public LogoutClass1()
    {
        //
        // TODO: Add constructor logic here
        //
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
            // UpdateDailyTime();
            UpdateWorkTimerEstimation();
            HttpContext.Current.Session["Etime"] = DateTime.Now.ToString("hh:mm:ss");
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Session.RemoveAll();
            HttpContext.Current.Response.Redirect("Index.aspx");
        }
        catch (Exception ex)
        {
            // Page p = (Page)HttpContext.Current.CurrentHandler;
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message + "')", true);
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