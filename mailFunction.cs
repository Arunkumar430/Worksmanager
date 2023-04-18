using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for mailFunction
/// </summary>
public class mailFunction
{
	public mailFunction()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string recruitEmail(string toEmailID, string ccEmailID, string mailSubject, string mailMessage)
    {
        string fromEmail = "recruit@carisma-solutions.com.au";
        MailMessage msg = new MailMessage();
        msg.To.Add(toEmailID);
        if (ccEmailID != "")
        {
            msg.CC.Add(ccEmailID);
        }        
        msg.From = new MailAddress(fromEmail, "HR Team");
        msg.Subject = mailSubject;
        msg.Body = mailMessage;
        msg.IsBodyHtml = true;

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        SmtpClient client = new SmtpClient();
        client.UseDefaultCredentials = false;
        client.Credentials = new System.Net.NetworkCredential(fromEmail, "Indian@1234");
        client.Port = 587;
        client.Host = "smtp.office365.com";
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.TargetName = "STARTTLS/smtp.office365.com";
        client.EnableSsl = true;
        try
        {
            client.Send(msg);
            return "Mail Send Successfully";
        }
        catch

        {
            return "Error Occured In Mail Function";
        }
    }

    public static string leaveMail(string toEmailID, string ccEmailID, string mailSubject, string mailMessage)
    {
        string fromEmail = "leave@carisma-solutions.com.au";
        MailMessage msg = new MailMessage();
        msg.To.Add(toEmailID);
        if (ccEmailID != "")
        {
            msg.CC.Add(ccEmailID);
        }
        msg.From = new MailAddress(fromEmail, "HR Team");
        msg.Subject = mailSubject;
        msg.Body = mailMessage;
        msg.IsBodyHtml = true;

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        SmtpClient client = new SmtpClient();
        client.UseDefaultCredentials = false;
        client.Credentials = new System.Net.NetworkCredential(fromEmail, "Indian@1234");
        client.Port = 587;
        client.Host = "smtp.office365.com";
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.TargetName = "STARTTLS/smtp.office365.com";
        client.EnableSsl = true;
        try
        {
            client.Send(msg);
            return "Mail Send Successfully";
        }
        catch
        {
            return "Error Occured In Mail Function";
        }
    }

    public static string complianceReport(string toEmailID, string ccEmailID, string mailSubject, string mailMessage)
    {
        string fromEmail = "projects@carisma-solutions.com.au";
        MailMessage msg = new MailMessage();
        msg.To.Add(toEmailID);
        if (ccEmailID != "")
        {
            msg.CC.Add(ccEmailID);
        }
        msg.Bcc.Add("mugesh.chandrasekar@purplequay.com.au");
        msg.From = new MailAddress(fromEmail, "Project Team");
        msg.Subject = mailSubject;
        msg.Body = mailMessage;
        msg.IsBodyHtml = true;

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        SmtpClient client = new SmtpClient();
        client.UseDefaultCredentials = false;
        client.Credentials = new System.Net.NetworkCredential(fromEmail, "Wox68472");
        client.Port = 587;
        client.Host = "smtp-mail.outlook.com";
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.TargetName = "STARTTLS/smtp-mail.outlook.com";
        client.EnableSsl = true;
        try
        {
            client.Send(msg);
            return "Mail Send Successfully";
        }
        catch
        {
            return "Error Occured In Mail Function";
        }
    }
}