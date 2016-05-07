using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.UserControl
{
    public DBAccess DA = new DBAccess();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["MSCaptchaAddNo"] = "0";

        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        Session["MSCaptchaAddNo"] = Convert.ToInt32(Session["MSCaptchaAddNo"]) + 1;
        if (Convert.ToInt32(Session["MSCaptchaAddNo"]) >= DA.MSCaptchaAddNo)
            CaptchaDiv.Visible = false;

        if (CaptchaDiv.Visible)
        {
            captcha.ValidateCaptcha(TxtCaptcha.Text);
            if (!captcha.UserValidated)
            {
                if (TxtCaptcha.Text != "")
                {
                    lblMsg.Text = "رمز التحقق خاطيء";
                    TxtCaptcha.Text = "";
                    lblMsg.CssClass = "error";
                }
                return;

            }
        }

       
            DA.ContactUsAdd(TxtName.Text, "", "", TxtEmail.Text, TxtSubject.Text, TxtMessage.Text, "", "1");

            try
            {
            string messageContent = " الاسم : " + TxtName.Text + "<br / > البريد الالكتروني : " + TxtEmail.Text + "<br / > عنوان الرسالة : " + TxtSubject.Text + "<br / > الرسالة : " + TxtMessage.Text;
            MailAddress fromAddress = new MailAddress("site@golive.ps", "golive - contactus", System.Text.Encoding.UTF8);
            MailMessage msg = new MailMessage();
            SmtpClient SmtpMail = new SmtpClient();
            msg.From = fromAddress;
            //  msg.To.Add("support@visitulaconn.com");

            msg.To.Add("engranaahmad@gmail.com");
            msg.Bcc.Add("info@golive.org");

            msg.Subject = "مراسلة الموقع - GoLive";
            msg.IsBodyHtml = true;
            System.Net.Mail.AlternateView htmlView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(messageContent, null, "text/html");
            msg.AlternateViews.Add(htmlView);
            //msg.Body = TextBox1.Text;
            msg.Priority = MailPriority.Normal;

            SmtpMail.Host = "127.0.0.1";
            SmtpMail.Send(msg);

            

            }
            catch (Exception ex) { }

            TxtName.Text = TxtEmail.Text = TxtSubject.Text = TxtMessage.Text = TxtCaptcha.Text = "";
            lblMsg.Text = "تم الإرسـال بنجـاح وسيتم الرد عليـك في أقرب فرصـة ممكنـة";
            lblMsg.CssClass = "success";
       
    }


}
