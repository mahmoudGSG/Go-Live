using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_update_page : DataAccess
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["Cat"] != null)
        {

            DataTable Dt = GetPagesCategory(Request.QueryString["Cat"]);
            if (Dt.Rows.Count > 0)
            {
                lblTitle.Text = "تحديث " + Dt.Rows[0]["AName"];
                Page.Title += Dt.Rows[0]["AName"];

             


               
                {
                    TitleDiv.Visible = SummaryDiv.Visible = ImgDiv.Visible = SummaryDivEN.Visible = false;
                }

                DataTable DtCheck = GetUserContentByID(Request.QueryString["ID"]);
                if (DtCheck.Rows[0]["IsMain"].ToString() == "True")
                {
                    SummaryDiv.Visible = true;
                    EditorDiv.Visible = false;
                }
                else
                {

                    SummaryDiv.Visible = false;
                    EditorDiv.Visible = true;
                
                }


            }
            else
                Response.Redirect("~/Admin/");
        }
        else
            Response.Redirect("~/Admin/");

        if (!Page.IsPostBack)
        {
            ViewState["Image"] = "";
            DataTable DT = GetPages(Request.QueryString["Cat"], "1");
            if (DT.Rows.Count != 0)
            {
                DataTable DTEN = GetPages(Request.QueryString["Cat"], "2");
                if (DTEN.Rows.Count > 0)
                {
                    EditorEN.Text = DTEN.Rows[0]["Details"].ToString();
                }


                TxtTitle.Text = DT.Rows[0]["Title"].ToString();
                TxtSummary.Text = DT.Rows[0]["Summary"].ToString();
                TxtSummaryEN.Text = DT.Rows[0]["FileName"].ToString();
                Editor.Text = TextBox1.Text = DT.Rows[0]["Details"].ToString();

                if (DT.Rows[0]["FileName"].ToString() != "")
                {
                    Img.ImageUrl = "../images/Pages/" + DT.Rows[0]["FileName"];
                    Img.Visible = true;
                    ViewState["Image"] = DT.Rows[0]["FileName"];
                }
                else
                    Img.Visible = false;

            }
            else
            {

                lblMsg.Text = "لا يوجد بيانات";

            }
        }



    }


    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        string iname = "";
        iname = iname.Split('/')[iname.Split('/').Length - 1];

        if (FUImg.FileName != "")
        {
            string name = FUImg.FileName;
            string type = name.Split('.')[name.Split('.').Length - 1].ToLower();
            if (type != "jpg" && type != "jpeg" && type != "png" && type != "gif")
            {
                lblMsg.Text = "الرجاء اختيار نوع امتداد صحيح للصور مثل jpg,gif,png";
                return;
            }
            else
            {
                iname = ViewState["Image"].ToString();
                if (System.IO.File.Exists(MapPath("../images/Pages\\" + iname)))
                    System.IO.File.Delete((MapPath("../images/Pages\\") + iname));

                iname = Guid.NewGuid() + "." + type;
                FUImg.SaveAs(MapPath("../images/Pages\\") + iname);
            }


        }
        else
            iname = ViewState["Image"].ToString();

        if (Request.QueryString["Cat"] == "23")
        {
            UpdatePages(TxtTitle.Text, TxtSummary.Text, TextBox1.Text, iname, Request.QueryString["Cat"], "1");
            UpdatePages(TxtTitle.Text, TxtSummaryEN.Text, TextBox1.Text, iname, Request.QueryString["Cat"], "2");
        }
        else
        {
            UpdatePages(TxtTitle.Text, TxtSummary.Text, Editor.Text, iname, Request.QueryString["Cat"], "1");
            UpdatePages(TxtTitle.Text, TxtSummaryEN.Text, EditorEN.Text, iname, Request.QueryString["Cat"], "2");
        
        }

        lblMsg.Text = "تم التحديث بنجاح";



    }

}