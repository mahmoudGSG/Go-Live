using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : DataAccess
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {

        string iname = "";
        iname = iname.Split('/')[iname.Split('/').Length - 1];

        if (LogoUpload.FileName != "")
        {
            string name = LogoUpload.FileName;
            string type = name.Split('.')[name.Split('.').Length - 1].ToLower();
            if (type != "jpg" && type != "jpeg" && type != "png" && type != "gif")
            {
                lblMsg.Text = "الرجاء اختيار نوع امتداد صحيح للشعار مثل jpg,gif,png";
                return;
            }
            iname = Guid.NewGuid() + "." + type;
            System.IO.File.Delete((MapPath("images/Site\\") + iname));
            iname = iname.ToString().Remove(iname.ToString().IndexOf(".")) + "." + type;
            LogoUpload.SaveAs(MapPath("images/Site\\") + iname);

        }

        string id = Guid.NewGuid().ToString();

        int x = New_SignUp_User(TxtName.Text, TxtEmail.Text, txtMobile.Text, txtPassword.Text, txtSite.Text,
         txtTitle.Text, txtDesc.Text, iname, txtFacebook.Text, txtTwitter.Text, txtGoogle.Text, txtLinkedIn.Text, id);

        Session["Guid"] = id;



        Response.Redirect("Sections.aspx");

    }


}