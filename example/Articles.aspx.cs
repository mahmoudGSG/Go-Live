using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Articles : DataAccess
{
    public DataAccess DA = new DataAccess();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Cat"] != null)
        {
            DataTable DT = GetNewsCategory(Request.QueryString["Cat"]);
            if (DT.Rows.Count > 0)
            {
                Title += DT.Rows[0]["AName"].ToString();
                LblTitle.Text = DT.Rows[0]["AName"].ToString();
            }
            else
                Response.Redirect("~/example");

        }
        else
            Response.Redirect("~/example");



        if (!IsPostBack)
        {
           // BindGrid();

            ViewState["CurrentPage"] = 1;
            NewsPaggingDone();

        }

    }




    protected void btnNewPagesNumber_Click(object sender, EventArgs e)
    {
        Button btnNewPagesNumber = (Button)sender;
        ViewState["CurrentPage"] = Convert.ToInt32(btnNewPagesNumber.Text);
        NewsPaggingDone();
    }

    void NewsPaggingDone()
    {
        int RowsPerPage = 15;
         
        int Total = DA.GetAllNewsCount(Request.QueryString["Cat"], DataAccess.LanguageID);

        int PageCount = Convert.ToInt32(Math.Ceiling((float)Total / RowsPerPage));

        int PageCountSize = 2;

        int StartPage = Convert.ToInt32(ViewState["CurrentPage"]) > PageCountSize ? Convert.ToInt32(ViewState["CurrentPage"]) - PageCountSize : 1;
        int EndPage = PageCount;
        if (Convert.ToInt32(ViewState["CurrentPage"]) + PageCountSize < PageCount)
            EndPage = Convert.ToInt32(ViewState["CurrentPage"]) + PageCountSize;
        else
            EndPage = PageCount;

        DataTable DT = new DataTable();
        DT.Columns.Add("PageNumber");
        DT.Columns.Add("PageCssClass");
        for (int i = StartPage; i <= EndPage; i++)
        {
            DataRow R = DT.NewRow();

            R["PageNumber"] = i;
            R["PageCssClass"] = Convert.ToInt32(ViewState["CurrentPage"]) == i ? "CurrentP" : "pointer";
            DT.Rows.Add(R);


        }
        RpNewPagesNumber.DataSource = DT;
        RpNewPagesNumber.DataBind();


        RpNews.DataSource = DA.NewsPagging(RowsPerPage, Convert.ToInt32(ViewState["CurrentPage"]), Request.QueryString["Cat"], DataAccess.LanguageID);
        RpNews.DataBind();
        UPanelNewsPager.Visible = Total > RowsPerPage;
        if (RpNews.Items.Count == 0)
            lblNoResults.Visible = true;
    }



}


