using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.UserControl
{
    public DataAccess DA = new DataAccess();
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


        DA.ContactUsAdd(TxtName.Text, "", "", TxtEmail.Text, TxtSubject.Text, TxtMessage.Text, Session["GID"].ToString(), "1");



        TxtName.Text = TxtEmail.Text = TxtSubject.Text = TxtMessage.Text = TxtCaptcha.Text = "";
        lblMsg.Text = "تم الإرسـال بنجـاح وسيتم الرد عليـك في أقرب فرصـة ممكنـة";
        lblMsg.CssClass = "success";

    }


}