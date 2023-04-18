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

public class InsertUser
{
    MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
    MySqlCommand cmd = new MySqlCommand();
    MySqlDataAdapter dapp = new MySqlDataAdapter();
    MySqlDataReader reader;

    public string UID { get; set; }
    public string Username { get; set; }
    public string Passwords { get; set; }
    public string Firstnames { get; set; }
    public string Lastnames { get; set; }
    public string fathernames { get; set; }
    public string gender { get; set; }
    public string Useremailids { get; set; }
    public string EmployeeId { get; set; }
    public string UserDOB { get; set; }
    public string UserDOJ { get; set; }
    public string UserDesc { get; set; }
    public string Qualify { get; set; }
    public string UserStatus { get; set; }
    public string TeamLeaderId { get; set; }
    public string TeamLeaderName { get; set; }
    public string TeamLeaderColor { get; set; }
    public string Sweid { get; set; }
    public string Smeid { get; set; }
    public string ProjectDirecterName { get; set; }
    public string Accessstatuss { get; set; }
    public string Accessstatusss { get; set; }
    public string createbys { get; set; }
    public string Usertypes { get; set; }
    public string MobileNo { get; set; }
    public string AMobileNo { get; set; }
    public string PanNo { get; set; }
    public string BloodGroups { get; set; }
    public string FacebookId { get; set; }
    public string PersionalEmailId { get; set; }
    public string floatnoR { get; set; }
    public string aprtmentR { get; set; }
    public string locationR { get; set; }
    public string CityR { get; set; }
    public string StateR { get; set; }
    public string CountryR { get; set; }
    public string lanmarkR { get; set; }
    public string PincodeR { get; set; }
    public string floatnoP { get; set; }
    public string aprtmentP { get; set; }
    public string locationP { get; set; }
    public string CityP { get; set; }
    public string StateP { get; set; }
    public string CountryP { get; set; }
    public string lanmarkP { get; set; }
    public string PincodeP { get; set; }
    public string ContactPersonName { get; set; }
    public string contactmobileno { get; set; }
    public string contactRelationship { get; set; }
    public string contactmailid { get; set; }
    public string MaritalStatus { get; set; }
    public string DependantName1 { get; set; }
    public string Insurenceage1 { get; set; }
    public string InsurenceDOB1 { get; set; }
    public string InsurenceGender1 { get; set; }
    public string DependantName2 { get; set; }
    public string Insurenceage2 { get; set; }
    public string InsurenceDOB2 { get; set; }
    public string InsurenceGender2 { get; set; }
    public string Relationship { get; set; }
    public string AssetPCName { get; set; }
    public string PCFdate { get; set; }
    public string PCTdate { get; set; }
    public string Monitordetails { get; set; }
    public string MonitorFdate { get; set; }
    public string MonitorTdate { get; set; }
    public string AssetMobile { get; set; }
    public string AssetMobileFdate { get; set; }
    public string AssetMobileTdate { get; set; }
    public string AssetDongle { get; set; }
    public string AssetDongleFdate { get; set; }
    public string AssetDongleTdate { get; set; }
    public string AssetOthers { get; set; }
    public string AssetOthersFdate { get; set; }
    public string AssetOthersTdate { get; set; }
    public string UserPhotofilename { get; set; }
    public string UserPhotofilepath { get; set; }
    public string MartialStatus { get; set; }
    public string MarriedDate { get; set; }
    public string WorkLocation { get; set; }
    public string FloorLocation { get; set; }
    public string outputdata = "";
    public string UserInsert()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("SPNN_InsertUserProfiles", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("Username", MySqlDbType.VarChar, 100).Value = Username; //Username Passwords Firstnames Lastnames Useremailids EmployeeId UserBOD UserDOJ UserDesc UserStatus TeamLeaderId TeamLeaderName TeamLeaderColor Sweid Smeid ProjectDirecterName Usertypes  BloodGroups FacebookId PersionalEmailId ContactPersonName contactmobileno contactmailid contactmailid MaritalStatus DependantName AssetMobile AssetDongle AssetOthers AssetSDate  AssetEDate UserPhotofilename UserPhotofilepath
        cmd.Parameters.Add("Passwords", MySqlDbType.VarChar, 100).Value = Passwords;
        cmd.Parameters.Add("Firstnames", MySqlDbType.VarChar, 100).Value = Firstnames;
        cmd.Parameters.Add("Lastnames", MySqlDbType.VarChar, 100).Value = Lastnames;
        cmd.Parameters.Add("Useremailids", MySqlDbType.VarChar, 100).Value = Useremailids;
        cmd.Parameters.Add("EmployeeId", MySqlDbType.VarChar, 100).Value = EmployeeId;
        cmd.Parameters.Add("UserBOD", MySqlDbType.Date, 100).Value = UserDOB;
        cmd.Parameters.Add("UserDOJ", MySqlDbType.VarChar, 100).Value = UserDOJ;
        cmd.Parameters.Add("UserDesc", MySqlDbType.VarChar, 100).Value = UserDesc;
        cmd.Parameters.Add("UserStatus", MySqlDbType.VarChar, 100).Value = UserStatus;
        cmd.Parameters.Add("TeamLeaderId", MySqlDbType.VarChar, 100).Value = TeamLeaderId;//
        cmd.Parameters.Add("TeamLeaderName", MySqlDbType.VarChar, 100).Value = TeamLeaderName;
        cmd.Parameters.Add("TeamLeaderColor", MySqlDbType.VarChar, 100).Value = TeamLeaderColor;
        cmd.Parameters.Add("Sweid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("Smeid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("ProjectDirecterName", MySqlDbType.VarChar, 100).Value = ProjectDirecterName; //
        cmd.Parameters.Add("Accessstatus", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Usertypes", MySqlDbType.VarChar, 100).Value = Usertypes;
        cmd.Parameters.Add("BloodGroups", MySqlDbType.VarChar, 100).Value = BloodGroups;
        cmd.Parameters.Add("FacebookId", MySqlDbType.VarChar, 100).Value = FacebookId;
        cmd.Parameters.Add("PersionalEmailId", MySqlDbType.VarChar, 100).Value = PersionalEmailId;
        cmd.Parameters.Add("ContactPersonName", MySqlDbType.VarChar, 100).Value = ContactPersonName;
        cmd.Parameters.Add("contactmobileno", MySqlDbType.VarChar, 100).Value = contactmobileno;
        cmd.Parameters.Add("contactmailid", MySqlDbType.VarChar, 100).Value = contactmailid;
        cmd.Parameters.Add("MaritalStatus", MySqlDbType.VarChar, 100).Value = MaritalStatus;// DPTName1, DPTAge1, DPTDBO1, DPTDGender1, DPTName2, DPTAge2, DPTDBO2, DPTDGender2
        cmd.Parameters.Add("DPTName1", MySqlDbType.VarChar, 100).Value = DependantName1;
        cmd.Parameters.Add("DPTAge1", MySqlDbType.VarChar, 100).Value = Insurenceage1;
        cmd.Parameters.Add("DPTDOB1", MySqlDbType.Date, 100).Value = InsurenceDOB1;
        cmd.Parameters.Add("DPTDGender1", MySqlDbType.VarChar, 100).Value = InsurenceGender1;
        cmd.Parameters.Add("DPTName2", MySqlDbType.VarChar, 100).Value = DependantName2;
        cmd.Parameters.Add("DPTAge2", MySqlDbType.Int32, 100).Value = Insurenceage2;
        cmd.Parameters.Add("DPTDOB2", MySqlDbType.Date, 100).Value = InsurenceDOB2;
        cmd.Parameters.Add("DPTDGender2", MySqlDbType.VarChar, 100).Value = InsurenceGender2;
        cmd.Parameters.Add("AssetPCNames", MySqlDbType.VarChar, 100).Value = AssetPCName;
        cmd.Parameters.Add("AssetMobiles", MySqlDbType.VarChar, 100).Value = AssetMobile;
        cmd.Parameters.Add("AssetDongles", MySqlDbType.VarChar, 100).Value = AssetDongle;
        cmd.Parameters.Add("AssetOtherss", MySqlDbType.VarChar, 100).Value = AssetOthers;
        //cmd.Parameters.Add("AssetSDates", MySqlDbType.Date, 100).Value = AssetSDate;
        //cmd.Parameters.Add("AssetEDates", MySqlDbType.Date, 100).Value = AssetEDate;
        cmd.Parameters.Add("UserPhotofilename", MySqlDbType.VarChar, 100).Value = UserPhotofilename;
        cmd.Parameters.Add("UserPhotofilepath", MySqlDbType.VarChar, 100).Value = UserPhotofilepath;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;

    }
    public string UpdateUserMasterInsert()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("Sp_UpdateProfile", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;
        cmd.Parameters.Add("Username", MySqlDbType.VarChar, 100).Value = Username; //Username Passwords Firstnames Lastnames Useremailids EmployeeId UserBOD UserDOJ UserDesc UserStatus TeamLeaderId TeamLeaderName TeamLeaderColor Sweid Smeid ProjectDirecterName Usertypes  BloodGroups FacebookId PersionalEmailId ContactPersonName contactmobileno contactmailid contactmailid MaritalStatus DependantName AssetMobile AssetDongle AssetOthers AssetSDate  AssetEDate UserPhotofilename UserPhotofilepath
        cmd.Parameters.Add("Passwords", MySqlDbType.VarChar, 100).Value = Passwords;
        cmd.Parameters.Add("Firstnames", MySqlDbType.VarChar, 100).Value = Firstnames;
        cmd.Parameters.Add("Lastnames", MySqlDbType.VarChar, 100).Value = Lastnames;
        cmd.Parameters.Add("fathernames", MySqlDbType.VarChar, 100).Value = fathernames;
        cmd.Parameters.Add("Useremailids", MySqlDbType.VarChar, 100).Value = Useremailids;
        cmd.Parameters.Add("EmployeeId", MySqlDbType.VarChar, 100).Value = EmployeeId;
        cmd.Parameters.Add("UserBOD", MySqlDbType.VarChar, 100).Value = UserDOB;
        cmd.Parameters.Add("UserDOJ", MySqlDbType.VarChar, 100).Value = UserDOJ;
        cmd.Parameters.Add("UserDesc", MySqlDbType.VarChar, 100).Value = UserDesc;
        cmd.Parameters.Add("Qualifys", MySqlDbType.VarChar, 100).Value = Qualify;
        cmd.Parameters.Add("UserStatus", MySqlDbType.VarChar, 100).Value = UserStatus;
        cmd.Parameters.Add("TeamLeaderId", MySqlDbType.VarChar, 100).Value = TeamLeaderId;//
        cmd.Parameters.Add("TeamLeaderName", MySqlDbType.VarChar, 100).Value = TeamLeaderName;
        cmd.Parameters.Add("TeamLeaderColor", MySqlDbType.VarChar, 100).Value = TeamLeaderColor;
        cmd.Parameters.Add("Sweid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("Smeid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("ProjectDirecterName", MySqlDbType.VarChar, 100).Value = ProjectDirecterName; //
        cmd.Parameters.Add("Accessstatus", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Usertypes", MySqlDbType.VarChar, 100).Value = Usertypes;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public string UserMasterInsert()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("Sp_InsertProfile", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("Username", MySqlDbType.VarChar, 100).Value = Username;
        cmd.Parameters.Add("Passwords", MySqlDbType.VarChar, 100).Value = Passwords;
        cmd.Parameters.Add("Firstnames", MySqlDbType.VarChar, 100).Value = Firstnames;
        cmd.Parameters.Add("Lastnames", MySqlDbType.VarChar, 100).Value = Lastnames;
        cmd.Parameters.Add("fathernames", MySqlDbType.VarChar, 100).Value = fathernames;
        cmd.Parameters.Add("Useremailids", MySqlDbType.VarChar, 100).Value = Useremailids;
        cmd.Parameters.Add("EmployeeId", MySqlDbType.VarChar, 100).Value = EmployeeId;
        cmd.Parameters.Add("UserBOD", MySqlDbType.VarChar, 100).Value = UserDOB;
        cmd.Parameters.Add("UserDOJ", MySqlDbType.VarChar, 100).Value = UserDOJ;
        cmd.Parameters.Add("UserDesc", MySqlDbType.VarChar, 100).Value = UserDesc;
        cmd.Parameters.Add("Qualifys", MySqlDbType.VarChar, 100).Value = Qualify;
        cmd.Parameters.Add("UserStatus", MySqlDbType.VarChar, 100).Value = UserStatus;
        cmd.Parameters.Add("TeamLeaderId", MySqlDbType.VarChar, 100).Value = TeamLeaderId;//
        cmd.Parameters.Add("TeamLeaderName", MySqlDbType.VarChar, 100).Value = TeamLeaderName;
        cmd.Parameters.Add("TeamLeaderColor", MySqlDbType.VarChar, 100).Value = TeamLeaderColor;
        cmd.Parameters.Add("Sweid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("Smeid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("ProjectDirecterName", MySqlDbType.VarChar, 100).Value = ProjectDirecterName; //
        cmd.Parameters.Add("Accessstatus", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Usertypes", MySqlDbType.VarChar, 100).Value = Usertypes;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;

    }
    public string insertUserContact()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("SPNU_InsertUserContact", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;
        cmd.Parameters.Add("ContactNames", MySqlDbType.VarChar, 100).Value = ContactPersonName;
        cmd.Parameters.Add("ContactNumbers", MySqlDbType.VarChar, 100).Value = contactmobileno;
        cmd.Parameters.Add("relationships", MySqlDbType.VarChar, 100).Value = contactRelationship;
        cmd.Parameters.Add("ContactEmails", MySqlDbType.VarChar, 100).Value = contactmailid;
        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Accesss", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public string insertPersonalDetails()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("Sp_InsertPersonal", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;
        cmd.Parameters.Add("MobileNos", MySqlDbType.VarChar, 100).Value = MobileNo;
        cmd.Parameters.Add("AmobileNos", MySqlDbType.VarChar, 200).Value = AMobileNo;
        cmd.Parameters.Add("PanNos", MySqlDbType.VarChar, 200).Value = PanNo;
        cmd.Parameters.Add("BloodGroups", MySqlDbType.VarChar, 100).Value = BloodGroups;
        cmd.Parameters.Add("FacebookIds", MySqlDbType.VarChar, 200).Value = FacebookId;
        cmd.Parameters.Add("PersionEmailIds", MySqlDbType.VarChar, 200).Value = PersionalEmailId;
        cmd.Parameters.Add("floatnoRs", MySqlDbType.VarChar, 200).Value = floatnoR;
        cmd.Parameters.Add("aprtmentRs", MySqlDbType.VarChar, 200).Value = aprtmentR;
        cmd.Parameters.Add("locationRs", MySqlDbType.VarChar, 200).Value = locationR;
        cmd.Parameters.Add("CityRs", MySqlDbType.VarChar, 10).Value = CityR;
        cmd.Parameters.Add("StateRs", MySqlDbType.Int16, 10).Value = StateR;
        cmd.Parameters.Add("CountryRs", MySqlDbType.Int16, 10).Value = CountryR;
        cmd.Parameters.Add("lanmarkRs", MySqlDbType.VarChar, 200).Value = lanmarkR;
        cmd.Parameters.Add("PincodeRs", MySqlDbType.VarChar, 10).Value = PincodeR;

        cmd.Parameters.Add("floatnoPs", MySqlDbType.VarChar, 200).Value = floatnoP;
        cmd.Parameters.Add("aprtmentPs", MySqlDbType.VarChar, 200).Value = aprtmentP;
        cmd.Parameters.Add("locationPs", MySqlDbType.VarChar, 200).Value = locationP;
        cmd.Parameters.Add("CityPs", MySqlDbType.VarChar, 10).Value = CityP;
        cmd.Parameters.Add("StatePs", MySqlDbType.Int16, 10).Value = StateP;
        cmd.Parameters.Add("CountryPs", MySqlDbType.Int16, 10).Value = CountryP;
        cmd.Parameters.Add("lanmarkPs", MySqlDbType.VarChar, 200).Value = lanmarkP;
        cmd.Parameters.Add("PincodePs", MySqlDbType.VarChar, 10).Value = PincodeP;



        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Accesss", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public string UpdatePersonalDetails()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("Sp_UpdatePersonal", conn);//SPNU_UpdateUserPersionalDetails
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;
        cmd.Parameters.Add("MobileNos", MySqlDbType.VarChar, 100).Value = MobileNo;
        cmd.Parameters.Add("AmobileNos", MySqlDbType.VarChar, 200).Value = AMobileNo;
        cmd.Parameters.Add("PanNos", MySqlDbType.VarChar, 200).Value = PanNo;
        cmd.Parameters.Add("BloodGroups", MySqlDbType.VarChar, 100).Value = BloodGroups;
        cmd.Parameters.Add("FacebookIds", MySqlDbType.VarChar, 200).Value = FacebookId;
        cmd.Parameters.Add("PersionEmailIds", MySqlDbType.VarChar, 200).Value = PersionalEmailId;

        cmd.Parameters.Add("floatnoRs", MySqlDbType.VarChar, 200).Value = floatnoR;
        cmd.Parameters.Add("aprtmentRs", MySqlDbType.VarChar, 200).Value = aprtmentR;
        cmd.Parameters.Add("locationRs", MySqlDbType.VarChar, 200).Value = locationR;
        cmd.Parameters.Add("CityRs", MySqlDbType.VarChar, 10).Value = CityR;
        cmd.Parameters.Add("StateRs", MySqlDbType.Int16, 10).Value = StateR;
        cmd.Parameters.Add("CountryRs", MySqlDbType.Int16, 10).Value = CountryR;
        cmd.Parameters.Add("lanmarkRs", MySqlDbType.VarChar, 200).Value = lanmarkR;
        cmd.Parameters.Add("PincodeRs", MySqlDbType.VarChar, 10).Value = PincodeR;

        cmd.Parameters.Add("floatnoPs", MySqlDbType.VarChar, 200).Value = floatnoP;
        cmd.Parameters.Add("aprtmentPs", MySqlDbType.VarChar, 200).Value = aprtmentP;
        cmd.Parameters.Add("locationPs", MySqlDbType.VarChar, 200).Value = locationP;
        cmd.Parameters.Add("CityPs", MySqlDbType.VarChar, 10).Value = CityP;
        cmd.Parameters.Add("StatePs", MySqlDbType.Int16, 10).Value = StateP;
        cmd.Parameters.Add("CountryPs", MySqlDbType.Int16, 10).Value = CountryP;
        cmd.Parameters.Add("lanmarkPs", MySqlDbType.VarChar, 200).Value = lanmarkP;
        cmd.Parameters.Add("PincodePs", MySqlDbType.VarChar, 10).Value = PincodeP;

        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Accesss", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public string insertAssertDetails()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("SPNU_InsertOfiiceAssetss", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;

        cmd.Parameters.Add("AssetPCNames", MySqlDbType.VarChar, 100).Value = AssetPCName; 
        cmd.Parameters.Add("PCFdates", MySqlDbType.VarChar, 100).Value = PCFdate;
        cmd.Parameters.Add("PCTdates", MySqlDbType.VarChar, 100).Value = PCTdate;

        cmd.Parameters.Add("Monitordetailss", MySqlDbType.VarChar, 100).Value = Monitordetails;
        cmd.Parameters.Add("MonitorFdates", MySqlDbType.VarChar, 100).Value = MonitorFdate;
        cmd.Parameters.Add("MonitorTdates", MySqlDbType.VarChar, 100).Value = MonitorTdate;

        cmd.Parameters.Add("AssetMobiles", MySqlDbType.VarChar, 100).Value = AssetMobile; 
        cmd.Parameters.Add("AssetMobileFdates", MySqlDbType.VarChar, 100).Value = AssetMobileFdate;
        cmd.Parameters.Add("AssetMobileTdates", MySqlDbType.VarChar, 100).Value = AssetMobileTdate;

        cmd.Parameters.Add("AssetDongles", MySqlDbType.VarChar, 100).Value = AssetDongle;
        cmd.Parameters.Add("AssetDongleFdates", MySqlDbType.VarChar, 100).Value = AssetDongleFdate;
        cmd.Parameters.Add("AssetDongleTdates", MySqlDbType.VarChar, 100).Value = AssetDongleTdate;

       
        cmd.Parameters.Add("AssetOtherss", MySqlDbType.VarChar, 100).Value = AssetOthers;
        cmd.Parameters.Add("AssetOthersFdate", MySqlDbType.VarChar, 100).Value = AssetOthersFdate; 
        cmd.Parameters.Add("AssetOthersTdate", MySqlDbType.VarChar, 100).Value = AssetOthersTdate;

        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Accesss", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;

    }
    public string InsertInsuranceDetails()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("SPNU_InsertIntoInsurance", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;
        cmd.Parameters.Add("MaritalStatus", MySqlDbType.VarChar, 100).Value = MaritalStatus;
        cmd.Parameters.Add("Relationship", MySqlDbType.VarChar, 100).Value = Relationship;  // UIDS MaritalStatus DependentName  dpendentage dependentdob dependentgender Createbys Accesss output
        cmd.Parameters.Add("DependentName", MySqlDbType.VarChar, 100).Value = DependantName1;
        cmd.Parameters.Add("dpendentage", MySqlDbType.VarChar, 100).Value = Insurenceage1;
        cmd.Parameters.Add("dependentdob", MySqlDbType.Date, 100).Value = InsurenceDOB1;
        cmd.Parameters.Add("dependentgender", MySqlDbType.VarChar, 100).Value = InsurenceGender1;
        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Accesss", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();

        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public string InsertEmployeeDetails()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("Sp_InsertEmployeeDetails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        //User Table Insert
        cmd.Parameters.Add("Username", MySqlDbType.VarChar, 100).Value = Username;
        cmd.Parameters.Add("Passwords", MySqlDbType.VarChar, 100).Value = Passwords;
        cmd.Parameters.Add("Firstnames", MySqlDbType.VarChar, 100).Value = Firstnames;
        cmd.Parameters.Add("Lastnames", MySqlDbType.VarChar, 100).Value = Lastnames;
        cmd.Parameters.Add("fathernames", MySqlDbType.VarChar, 100).Value = fathernames;
        cmd.Parameters.Add("Gender", MySqlDbType.VarChar, 100).Value = gender;
        cmd.Parameters.Add("Useremailids", MySqlDbType.VarChar, 100).Value = Useremailids;
        cmd.Parameters.Add("EmployeeId", MySqlDbType.VarChar, 100).Value = EmployeeId;
        cmd.Parameters.Add("UserBOD", MySqlDbType.VarChar, 100).Value = UserDOB;
        cmd.Parameters.Add("UserDOJ", MySqlDbType.VarChar, 100).Value = UserDOJ;
        cmd.Parameters.Add("UserDesc", MySqlDbType.VarChar, 100).Value = UserDesc;
        cmd.Parameters.Add("Qualifys", MySqlDbType.VarChar, 100).Value = Qualify;
        cmd.Parameters.Add("UserStatus", MySqlDbType.VarChar, 100).Value = UserStatus;
        cmd.Parameters.Add("TeamLeaderId", MySqlDbType.VarChar, 100).Value = TeamLeaderId;//
        cmd.Parameters.Add("TeamLeaderName", MySqlDbType.VarChar, 100).Value = TeamLeaderName;
        cmd.Parameters.Add("TeamLeaderColor", MySqlDbType.VarChar, 100).Value = TeamLeaderColor;
        cmd.Parameters.Add("Sweid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("Smeid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("ProjectDirecterName", MySqlDbType.VarChar, 100).Value = ProjectDirecterName; //
        cmd.Parameters.Add("Accessstatus", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Usertypes", MySqlDbType.VarChar, 100).Value = Usertypes;

        cmd.Parameters.Add("MobileNos", MySqlDbType.VarChar, 100).Value = MobileNo;
        cmd.Parameters.Add("AmobileNos", MySqlDbType.VarChar, 200).Value = AMobileNo;
        cmd.Parameters.Add("PanNos", MySqlDbType.VarChar, 200).Value = PanNo;
        cmd.Parameters.Add("BloodGroups", MySqlDbType.VarChar, 100).Value = BloodGroups;
        cmd.Parameters.Add("FacebookIds", MySqlDbType.VarChar, 200).Value = FacebookId;
        cmd.Parameters.Add("PersionEmailIds", MySqlDbType.VarChar, 200).Value = PersionalEmailId;
        cmd.Parameters.Add("floatnoRs", MySqlDbType.VarChar, 200).Value = floatnoR;
        cmd.Parameters.Add("aprtmentRs", MySqlDbType.VarChar, 200).Value = aprtmentR;
        cmd.Parameters.Add("locationRs", MySqlDbType.VarChar, 200).Value = locationR;
        cmd.Parameters.Add("CityRs", MySqlDbType.VarChar, 10).Value = CityR;
        cmd.Parameters.Add("StateRs", MySqlDbType.Int16, 10).Value = StateR;
        cmd.Parameters.Add("CountryRs", MySqlDbType.Int16, 10).Value = CountryR;
        cmd.Parameters.Add("lanmarkRs", MySqlDbType.VarChar, 200).Value = lanmarkR;
        cmd.Parameters.Add("PincodeRs", MySqlDbType.VarChar, 10).Value = PincodeR;
        cmd.Parameters.Add("floatnoPs", MySqlDbType.VarChar, 200).Value = floatnoP;
        cmd.Parameters.Add("aprtmentPs", MySqlDbType.VarChar, 200).Value = aprtmentP;
        cmd.Parameters.Add("locationPs", MySqlDbType.VarChar, 200).Value = locationP;
        cmd.Parameters.Add("CityPs", MySqlDbType.VarChar, 10).Value = CityP;
        cmd.Parameters.Add("StatePs", MySqlDbType.Int16, 10).Value = StateP;
        cmd.Parameters.Add("CountryPs", MySqlDbType.Int16, 10).Value = CountryP;
        cmd.Parameters.Add("lanmarkPs", MySqlDbType.VarChar, 200).Value = lanmarkP;
        cmd.Parameters.Add("PincodePs", MySqlDbType.VarChar, 10).Value = PincodeP;
        cmd.Parameters.Add("Accessss", MySqlDbType.VarChar, 100).Value = Accessstatusss;
        cmd.Parameters.Add("MaritalStatus", MySqlDbType.VarChar, 100).Value = MaritalStatus;
        cmd.Parameters.Add("MarriedDate", MySqlDbType.VarChar, 100).Value = MarriedDate;
        cmd.Parameters.Add("WorkLocation", MySqlDbType.VarChar, 100).Value = WorkLocation;
        cmd.Parameters.Add("FloorLocation", MySqlDbType.VarChar, 100).Value = FloorLocation;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public string UpdateEmployeeDetails()
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("Sp_UpdateEmployeeDetails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        //User Table Update
        cmd.Parameters.Add("UIDS", MySqlDbType.VarChar, 100).Value = UID;
        cmd.Parameters.Add("Username", MySqlDbType.VarChar, 100).Value = Username;
        cmd.Parameters.Add("Passwords", MySqlDbType.VarChar, 100).Value = Passwords;
        cmd.Parameters.Add("Firstnames", MySqlDbType.VarChar, 100).Value = Firstnames;
        cmd.Parameters.Add("Lastnames", MySqlDbType.VarChar, 100).Value = Lastnames;
        cmd.Parameters.Add("fathernames", MySqlDbType.VarChar, 100).Value = fathernames;
        cmd.Parameters.Add("Gender", MySqlDbType.VarChar, 100).Value = gender;
        cmd.Parameters.Add("Useremailids", MySqlDbType.VarChar, 100).Value = Useremailids;
        cmd.Parameters.Add("EmployeeId", MySqlDbType.VarChar, 100).Value = EmployeeId;
        cmd.Parameters.Add("UserBOD", MySqlDbType.VarChar, 100).Value = UserDOB;
        cmd.Parameters.Add("UserDOJ", MySqlDbType.VarChar, 100).Value = UserDOJ;
        cmd.Parameters.Add("UserDesc", MySqlDbType.VarChar, 100).Value = UserDesc;
        cmd.Parameters.Add("Qualifys", MySqlDbType.VarChar, 100).Value = Qualify;
        cmd.Parameters.Add("UserStatus", MySqlDbType.VarChar, 100).Value = UserStatus;
        cmd.Parameters.Add("TeamLeaderId", MySqlDbType.VarChar, 100).Value = TeamLeaderId;//
        cmd.Parameters.Add("TeamLeaderName", MySqlDbType.VarChar, 100).Value = TeamLeaderName;
        cmd.Parameters.Add("TeamLeaderColor", MySqlDbType.VarChar, 100).Value = TeamLeaderColor;
        cmd.Parameters.Add("Sweid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("Smeid", MySqlDbType.VarChar, 100).Value = Smeid;
        cmd.Parameters.Add("ProjectDirecterName", MySqlDbType.VarChar, 100).Value = ProjectDirecterName; //
        cmd.Parameters.Add("Accessstatus", MySqlDbType.VarChar, 100).Value = Accessstatuss;
        cmd.Parameters.Add("Createbys", MySqlDbType.VarChar, 100).Value = createbys;
        cmd.Parameters.Add("Usertypes", MySqlDbType.VarChar, 100).Value = Usertypes;

        cmd.Parameters.Add("MobileNos", MySqlDbType.VarChar, 100).Value = MobileNo;
        cmd.Parameters.Add("AmobileNos", MySqlDbType.VarChar, 200).Value = AMobileNo;
        cmd.Parameters.Add("PanNos", MySqlDbType.VarChar, 200).Value = PanNo;
        cmd.Parameters.Add("BloodGroups", MySqlDbType.VarChar, 100).Value = BloodGroups;
        cmd.Parameters.Add("FacebookIds", MySqlDbType.VarChar, 200).Value = FacebookId;
        cmd.Parameters.Add("PersionEmailIds", MySqlDbType.VarChar, 200).Value = PersionalEmailId;
        cmd.Parameters.Add("floatnoRs", MySqlDbType.VarChar, 200).Value = floatnoR;
        cmd.Parameters.Add("aprtmentRs", MySqlDbType.VarChar, 200).Value = aprtmentR;
        cmd.Parameters.Add("locationRs", MySqlDbType.VarChar, 200).Value = locationR;
        cmd.Parameters.Add("CityRs", MySqlDbType.VarChar, 10).Value = CityR;
        cmd.Parameters.Add("StateRs", MySqlDbType.Int16, 10).Value = StateR;
        cmd.Parameters.Add("CountryRs", MySqlDbType.Int16, 10).Value = CountryR;
        cmd.Parameters.Add("lanmarkRs", MySqlDbType.VarChar, 200).Value = lanmarkR;
        cmd.Parameters.Add("PincodeRs", MySqlDbType.VarChar, 10).Value = PincodeR;
        cmd.Parameters.Add("floatnoPs", MySqlDbType.VarChar, 200).Value = floatnoP;
        cmd.Parameters.Add("aprtmentPs", MySqlDbType.VarChar, 200).Value = aprtmentP;
        cmd.Parameters.Add("locationPs", MySqlDbType.VarChar, 200).Value = locationP;
        cmd.Parameters.Add("CityPs", MySqlDbType.VarChar, 10).Value = CityP;
        cmd.Parameters.Add("StatePs", MySqlDbType.Int16, 10).Value = StateP;
        cmd.Parameters.Add("CountryPs", MySqlDbType.Int16, 10).Value = CountryP;
        cmd.Parameters.Add("lanmarkPs", MySqlDbType.VarChar, 200).Value = lanmarkP;
        cmd.Parameters.Add("PincodePs", MySqlDbType.VarChar, 10).Value = PincodeP;
        cmd.Parameters.Add("Accessss", MySqlDbType.VarChar, 100).Value = Accessstatusss;
        cmd.Parameters.Add("MaritalStatus", MySqlDbType.VarChar, 100).Value = MaritalStatus;
        cmd.Parameters.Add("MarriedDate", MySqlDbType.VarChar, 100).Value = MarriedDate;
        cmd.Parameters.Add("WorkLocation", MySqlDbType.VarChar, 100).Value = WorkLocation;
        cmd.Parameters.Add("FloorLocation", MySqlDbType.VarChar, 100).Value = FloorLocation;
        cmd.Parameters.Add("output", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        cmd.ExecuteReader();
        outputdata = cmd.Parameters["output"].Value.ToString();
        return outputdata;
    }
    public static void Logout(int UID)
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            using (MySqlCommand cmd1 = new MySqlCommand("UPDATE loginstatus SET IsActive=0 WHERE UID = " + UID + " AND Date = CURDATE()"))
            {
                cmd1.Connection = con;
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
