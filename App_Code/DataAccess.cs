using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ComponentModel;
using System.Drawing;
using System.Web.SessionState;
using System.IO;
using System.Net;
using System.Text;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Net.Mail;
/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess : System.Web.UI.Page
{
    public static string UserId = "1";
    public static string LanguageID = "1";
    protected bool IsArabic = true;
    public int MSCaptchaAddNo = 3;


    private System.Data.SqlClient.SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ExampleConn"].ToString());


    public DataAccess()
    {
        //if (conn.State != ConnectionState.Open)
        //{
        //    conn.Open();
        //}
    }

    public void CloseConnection()
    {
        try
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        catch
        {
        }
    }


    protected void Page_UnLoad(object sender, EventArgs e)
    {
        conn.Close();
    }



    #region Admin
    public DataTable LoginAdmin(string username)
    {
        SqlDataAdapter da = new SqlDataAdapter("LoginAdmin", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@username", username);
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public DataTable GetLoginAdmin(string GUID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetLoginAdmin", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@GUID", GUID);
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    #endregion





    #region MyFunctions


    #region Position Link facebook,twitter,youtune,others

    public DataTable GetPositionLink(string Position)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetPositionLink", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (Position != "")
            da.SelectCommand.Parameters.AddWithValue("@Position", Position);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public int AddPositionLink(string Link, string Position)
    {
        SqlCommand cmd = new SqlCommand("AddPositionLink", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@Link", Link);
        cmd.Parameters.AddWithValue("@Position", Position);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    #endregion

    #region News

    public DataTable NewsSearch(string Word)
    {
        SqlDataAdapter da = new SqlDataAdapter("NewsSearch", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (Word != null)
            da.SelectCommand.Parameters.AddWithValue("@Word", "%" + Word + "%");
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }


    public DataTable SelecNewsIndexDep(string show)
    {
        SqlDataAdapter da = new SqlDataAdapter("SelecNewsIndexDep", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (show != null)
            da.SelectCommand.Parameters.AddWithValue("@show", show);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    //=======================================================================

    public int deleteGetNews(string Id)
    {
        SqlCommand cmd = new SqlCommand("deleteGetNews", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    //=======================================================================

    public int AddNewsCategory(string AName, string EName, string ASummary, string ESummary, string FileName)
    {
        SqlCommand cmd = new SqlCommand("AddNewsCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.Parameters.AddWithValue("@ASummary", ASummary);
        cmd.Parameters.AddWithValue("@ESummary", ESummary);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }



    public int AddPagesCategory(string AName, string EName)
    {
        SqlCommand cmd = new SqlCommand("AddPagesCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }


    public int UpdateNewsCounter(string ID)
    {
        SqlCommand cmd = new SqlCommand("UpdateNewsCounter", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int UpdateNewsCategory(string ID, string AName, string EName, string ASummary, string ESummary, string FileName)
    {
        SqlCommand cmd = new SqlCommand("UpdateNewsCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.Parameters.AddWithValue("@ASummary", ASummary);
        cmd.Parameters.AddWithValue("@ESummary", ESummary);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }



    public DataTable GetNewsCategory(string ID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetNewsCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID", ID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetAllNewsCategory(string InMenu)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllNewsCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (InMenu != "-1")
            da.SelectCommand.Parameters.AddWithValue("@InMenu", InMenu);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

 
    public DataTable DeleteNewsCategory(string ID,string Title)
    {
        SqlDataAdapter da = new SqlDataAdapter("DeleteNewsCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID", ID);
        da.SelectCommand.Parameters.AddWithValue("@Title", Title);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    //
    public DataTable DeletePagesCategory(string ID, string Title)
    {
        SqlDataAdapter da = new SqlDataAdapter("DeletePagesCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID", ID);
        da.SelectCommand.Parameters.AddWithValue("@Title", Title);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public int GetAllNewsCount(string CategoryId, string ShowIn)
    {
        SqlCommand cmd = new SqlCommand("GetAllNewsCount", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        if (CategoryId != null)
            cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
        if (ShowIn != null)
            cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        conn.Open();
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return count;
    }

    public DataTable NewsPagging(int RowsPerPage, int Page, string CategoryID, string ShowIn)
    {
        SqlDataAdapter DA = new SqlDataAdapter("NewsPagging", conn);
        DA.SelectCommand.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
        DA.SelectCommand.Parameters.AddWithValue("@Page", Page);
        DA.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        if (ShowIn != null)
            DA.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        DA.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DT = new DataTable();
        DA.Fill(DT);
        return DT;
    }



    public DataTable GetNews(string Id, string Active)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetNews", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID", Id);
        if (Active != null)
            da.SelectCommand.Parameters.AddWithValue("@Active", Active);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public int AddNews(string CategoryID, string Title, string TitleEN, string Details, string DetailsEN, string Summary, string SummaryEN,
                       string FileName, string Active, string ShowIn, string InsertDate, string Link)
    {
        SqlCommand cmd = new SqlCommand("AddNews", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@Summary", Summary);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@TitleEN", TitleEN);
        cmd.Parameters.AddWithValue("@SummaryEN", SummaryEN);
        cmd.Parameters.AddWithValue("@DetailsEN", DetailsEN);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        if (ShowIn != "0")
            cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        if (Active != null)
            cmd.Parameters.AddWithValue("@Active", Active);
        cmd.Parameters.AddWithValue("@Link", Link);
        cmd.Parameters.AddWithValue("@InsertDate", InsertDate);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int UpdateNews(string Id, string Title, string TitleEN, string Details, string DetailsEN, string Summary, string SummaryEN,
                          string FileName, string ShowIn, string CategoryID, string InsertDate, string Link)
    {
        SqlCommand cmd = new SqlCommand("UpdateNews", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@Summary", Summary);
        cmd.Parameters.AddWithValue("@TitleEN", TitleEN);
        cmd.Parameters.AddWithValue("@SummaryEN", SummaryEN);
        cmd.Parameters.AddWithValue("@DetailsEN", DetailsEN);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        if (ShowIn != "0")
            cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        cmd.Parameters.AddWithValue("@Link", Link);
        cmd.Parameters.AddWithValue("@InsertDate", InsertDate);
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public DataTable GetAllNews(string CategoryId, string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllNews", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (CategoryId != "0")
            da.SelectCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        if (ShowIn != "0")
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }


    public int DeleteNews(string Id)
    {
        SqlCommand cmd = new SqlCommand("DeleteNews", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int UpdateNewsActive(string Id, Boolean Active)
    {
        SqlCommand cmd = new SqlCommand("UpdateNewsActive", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@Active", Active);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }


    public DataTable GetTopNews(string CategoryID, string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopNews", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
      
            da.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
      
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }


    public DataTable GetTopNewsDefault(string CategoryID, string Counter)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopNewsDefault", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        da.SelectCommand.Parameters.AddWithValue("@Counter", Counter);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

  

    #endregion

    #region Images
    public DataTable GetAllImageCategory()
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllImageCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;


        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    

    public int GetAllImagesCount(string CategoryId, string IS7amla)
    {
        SqlCommand cmd = new SqlCommand("GetAllImagesCount", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        if (CategoryId != null)
            cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
        if (IS7amla != null)
            cmd.Parameters.AddWithValue("@IS7amla", IS7amla);
        conn.Open();
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return count;
    }

    public DataTable ImagesPagging(int RowsPerPage, int Page, string CategoryID, string IS7amla)
    {
        SqlDataAdapter DA = new SqlDataAdapter("ImagesPagging", conn);
        DA.SelectCommand.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
        DA.SelectCommand.Parameters.AddWithValue("@Page", Page);
        DA.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        if (IS7amla != null)
            DA.SelectCommand.Parameters.AddWithValue("@IS7amla", IS7amla);
        DA.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DT = new DataTable();
        DA.Fill(DT);
        return DT;
    }

    public DataTable GetImageCategory(string id)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetImageCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@id", id);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }



    public int AddImageCategory(string AName, string EName, string FileName)
    {
        SqlCommand cmd = new SqlCommand("AddImageCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }


    public int UpdateImageCategory(string Id, string AName, string EName, string FileName)
    {
        SqlCommand cmd = new SqlCommand("UpdateImageCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int DeleteImageCategory(string Id)
    {
        SqlCommand cmd = new SqlCommand("DeleteImageCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }



    public DataTable GetAllImage(string CategoryID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllImage", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (CategoryID != "0")
            da.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public DataTable GetImage(string Id)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetImage", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Id", Id);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public int AddImage(string CategoryID, string Title, string FileName, string ETitle, string Details, string IS7amla)
    {
        SqlCommand cmd = new SqlCommand("AddImage", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.Parameters.AddWithValue("@ETitle", ETitle);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@IS7amla", IS7amla);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public int UpdateImage(string Id, string CategoryID, string Title, string FileName, string ETitle, string Details, string IS7amla)
    {
        SqlCommand cmd = new SqlCommand("UpdateImage", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.Parameters.AddWithValue("@ETitle", ETitle);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@IS7amla", IS7amla);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int DeleteImage(string Id)
    {
        SqlCommand cmd = new SqlCommand("DeleteImage", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public DataTable GetTopImage()
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopImage", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }


    public DataTable GetTopImageByCat(string CategoryID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopImageByCat", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable Get_User_SignUpByName(string Name)
    {
        SqlDataAdapter da = new SqlDataAdapter("Get_User_SignUpByName", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Name", Name);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
 
    public DataTable Get_User_SignUp(string Code)
    {
        SqlDataAdapter da = new SqlDataAdapter("Get_User_SignUp", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Code", Code);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }


    public DataTable GetUserContentByID(string ID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetUserContentByID", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID", ID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetTopMainImage(string Code)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopMainImage", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Code", Code);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetTopImageGallary()
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopImageGallary", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public DataTable GetTopImageRandom(string CategoryID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopImageRandom", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (CategoryID != "0")
            da.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }



    #endregion

    #region Videos

    public string BindVideo(string Width, String Height, String Image, String Video)
    {
        return "<p id='player1'><a href='http://www.macromedia.com/go/getflashplayer'>Get the Flash Player</a> to see this player.</p>\n" +
"<script type='text/javascript'>\n" +
    "var s1 = new SWFObject('flvplayer.swf','single','" + Width + "','" + Height + "','7');\n" +
    "s1.addParam('allowfullscreen','true');\n" +
    "s1.addVariable('file','" + Video + "');\n" +
    "s1.addVariable('image','" + Image + "');\n" +
    "s1.addVariable('width','" + Width + "');\n" +
    "s1.addVariable('height','" + Height + "');\n" +
    "s1.addVariable('backcolor','0x000000');\n" +
    "s1.addVariable('frontcolor','0xCCCCCC');\n" +
    "s1.addVariable('lightcolor','0x557722');\n" +
    "s1.write('player1');\n" +
"</script>";


    }


    public DataTable VideoPagging(int RowsPerPage, int Page, string CategoryID, string ShowIn)
    {
        SqlDataAdapter DA = new SqlDataAdapter("VideoPagging", conn);
        DA.SelectCommand.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
        DA.SelectCommand.Parameters.AddWithValue("@Page", Page);
        DA.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        DA.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        DA.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DT = new DataTable();
        DA.Fill(DT);
        return DT;
    }

    public int GetAllVideoCount(string CategoryId, string ShowIn)
    {
        SqlCommand cmd = new SqlCommand("GetAllVideoCount", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        if (CategoryId != null)
            cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
        if (ShowIn != null)
            cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        conn.Open();
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return count;
    }

    public DataTable GetAllVideoCategory()
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllVideoCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetVideoCategory(string id)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetVideoCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@id", id);

        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public int AddVideoCategory(string AName, string EName, string FileName)
    {
        SqlCommand cmd = new SqlCommand("AddVideoCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public int UpdateVideoCategory(string Id, string AName, string EName, string FileName)
    {
        SqlCommand cmd = new SqlCommand("UpdateVideoCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@AName", AName);
        cmd.Parameters.AddWithValue("@EName", EName);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int DeleteVideoCategory(string Id)
    {
        SqlCommand cmd = new SqlCommand("DeleteVideoCategory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    /*-----------------------------------------------------------*/
    public DataTable GetAllVideo(string CategoryID, string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllVideo", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (CategoryID != "0")
            da.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
        if (ShowIn != "")
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);

        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetVideo(string Id, string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetVideo", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Id", Id);
        if (ShowIn != "")
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetTopVideo(string Id, string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetTopVideo", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Id", Id);
        if (ShowIn != "")
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;


    }
    public int AddVideo(string CategoryID, string Title, string Summary, string Details,
                                           string TitleEN, string SummaryEN, string DetailsEN
        , string FileName, string VideoName, string ShowIn)
    {
        SqlCommand cmd = new SqlCommand("AddVideo", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@Summary", Summary);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@TitleEN", TitleEN);
        cmd.Parameters.AddWithValue("@SummaryEN", SummaryEN);
        cmd.Parameters.AddWithValue("@DetailsEN", DetailsEN);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.Parameters.AddWithValue("@VideoName", VideoName);
        cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public int UpdateVideo(string Id, string CategoryID, string Title, string Summary, string Details,
        string TitleEN, string SummaryEN, string DetailsEN
        , string FileName, string VideoName, string ShowIn)
    {
        SqlCommand cmd = new SqlCommand("UpdateVideo", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@Summary", Summary);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@TitleEN", TitleEN);
        cmd.Parameters.AddWithValue("@SummaryEN", SummaryEN);
        cmd.Parameters.AddWithValue("@DetailsEN", DetailsEN);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.Parameters.AddWithValue("@VideoName", VideoName);
        cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
    public int DeleteVideo(string Id)
    {
        SqlCommand cmd = new SqlCommand("DeleteVideo", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    #endregion

    #region Pages

    public int UpdatePages(string Title, string Summary, string Details, string FileName, string CategoryID, string ShowIn)
    {
        SqlCommand cmd = new SqlCommand("UpdatePages", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@Summary", Summary);
        cmd.Parameters.AddWithValue("@Details", Details);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
        cmd.Parameters.AddWithValue("@ShowIn", ShowIn);
        cmd.Parameters.AddWithValue("@UserId", UserId);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public DataTable GetPages(string CategoryId, string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetPages", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        if (ShowIn != "0")
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
   

    public DataTable GetPagesCategory(string Id)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetPagesCategory", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Id", Id);

        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
    public DataTable GetPagesCategoryInMenu(string InMenu)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetPagesCategoryInMenu", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (InMenu != null)
            da.SelectCommand.Parameters.AddWithValue("@InMenu", InMenu);

        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    #endregion

    #region ContactUs

    public int ContactUsAdd(string Name, string MobileNo, string PhoneNo, string Email, string Subject, string Message, string FileName, string CategoryId)
    {
        SqlCommand cmd = new SqlCommand("ContactUsAdd", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@Email", Email);
        cmd.Parameters.AddWithValue("@Subject", Subject);
        cmd.Parameters.AddWithValue("@Message", Message);
        cmd.Parameters.AddWithValue("@MobileNo", MobileNo);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@FileName", FileName);
        cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
        cmd.Parameters.AddWithValue("@IP", GetIpAddress());
        cmd.Parameters.AddWithValue("@PC", GetPCName());
        conn.Open();
        int id = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return id;
    }

  
    public DataTable ContactUsGetAll(string CategoryId)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("ContactUsGetAll", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (CategoryId != "-1")
            da.SelectCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        da.Fill(dt);
        return dt;
    }
    public DataTable ContactUsCategoryGet(string ID)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("ContactUsCategoryGet", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (ID != "-1")
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
        da.Fill(dt);
        return dt;
    }



    public DataTable ContactUsGetOne(string ID)
    {
        SqlDataAdapter DA = new SqlDataAdapter("ContactUsGetOne", conn);
        DA.SelectCommand.Parameters.AddWithValue("@ID", ID);
        DA.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DT = new DataTable();
        DA.Fill(DT);
        return DT;
    }

    public void ContactUsDelete(string ID)
    {
        SqlCommand cmd = new SqlCommand("ContactUsDelete", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }

    #endregion


    #region CutWord
    public string CutWord(string Text, int Len)
    {
        if (Text != "")
        {

            int LenText = Text.Length;
            if (LenText <= Len)
                return Text;
            else
            {
                int Count = 1;

                string[] TextSplit = Text.Split(' ');
                string TextNew = TextSplit[0] + " ";
                int LenNew = TextSplit[0].Length + 1;
                if (LenNew > Len)
                    return Text;
                for (int i = 0; i < TextSplit.Length; i++)
                {
                    if (i != TextSplit.Length)
                    {

                        if (LenNew + TextSplit[i + 1].Length + 1 < Len)
                        {
                            TextNew += TextSplit[i + 1] + " ";
                            LenNew += TextSplit[i + 1].Length + 1;
                            Count += 1;
                        }
                        else
                            break;

                    }
                    else
                    {
                        Count = TextSplit.Length;
                        break;
                    }

                }

                return TextNew;


            }

        }
        else
        {
            return Text;

        }




    }
    #endregion

    #region Visitors Counter

    public string GetAllVisitors()
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllVisitors", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt.Rows[0]["VisitorsCount"].ToString();
    }


    public int UpdateVisitorsCount()
    {
        SqlCommand cmd = new SqlCommand("UpdateVisitorsCount", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    #endregion

    #region Email List

    public int OutEmailList(string Email)
    {
        SqlCommand cmd = new SqlCommand("OutEmailList", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Email", Email);
        conn.Open();
        int id = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return id;
    }

    public int AddEmailList(string Name, string Email, string Mobile, string type, string dep, string country)
    {
        SqlCommand cmd = new SqlCommand("AddEmailList", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@Email", Email);
        cmd.Parameters.AddWithValue("@Mobile", Mobile);
        cmd.Parameters.AddWithValue("@type", type);
        cmd.Parameters.AddWithValue("@dep", dep);
        cmd.Parameters.AddWithValue("@country", country);
        conn.Open();
        int id = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return id;
    }
  
    public DataTable EmailListGetAll(string Active, string type)
    {
        SqlDataAdapter da = new SqlDataAdapter("EmailListGetAll", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (Active != null)
            da.SelectCommand.Parameters.AddWithValue("@Active", Active);
        da.SelectCommand.Parameters.AddWithValue("@type", type);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public int EmailListDelete(string Id)
    {
        SqlCommand cmd = new SqlCommand("EmailListDelete", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    #endregion

    #endregion MyFunctions



    #region SignUp
 

    public int New_SignUp_User(string FullName, string Email, string MobileNo, string User_Password, string WebSite_Name,
        string WebSite_Title, string WebSite_Decription, string WebSite_Logo, string Facebook_Url, string Twitter_Url,
        string Google_Url, string LinkedIN_Url, string Guid)
    {
        SqlCommand cmd = new SqlCommand("New_SignUp_User", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@FullName", FullName);
        cmd.Parameters.AddWithValue("@Email", Email);
        cmd.Parameters.AddWithValue("@MobileNo", MobileNo);
        cmd.Parameters.AddWithValue("@User_Password", User_Password);
        cmd.Parameters.AddWithValue("@WebSite_Name", WebSite_Name);

        cmd.Parameters.AddWithValue("@WebSite_Title", WebSite_Title);
        cmd.Parameters.AddWithValue("@WebSite_Decription", WebSite_Decription);
        cmd.Parameters.AddWithValue("@WebSite_Logo", WebSite_Logo);
        cmd.Parameters.AddWithValue("@Facebook_Url", Facebook_Url);
        cmd.Parameters.AddWithValue("@Twitter_Url", Twitter_Url);
        cmd.Parameters.AddWithValue("@Google_Url", Google_Url);
        cmd.Parameters.AddWithValue("@LinkedIN_Url", LinkedIN_Url);
        cmd.Parameters.AddWithValue("@Guid", Guid); 

        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public int Add_SignUp_User_Content(string Guid, string TypeID, string Title, string IsMain, string CountNo, string StyleType
        ,string PageLink)
    {
        SqlCommand cmd = new SqlCommand("Add_SignUp_User_Content", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Guid", Guid);
        cmd.Parameters.AddWithValue("@TypeID", TypeID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@IsMain", IsMain);
        cmd.Parameters.AddWithValue("@CountNo", CountNo);
        cmd.Parameters.AddWithValue("@StyleType", StyleType);
        cmd.Parameters.AddWithValue("@PageLink", PageLink);
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public int Update_Menu_SignUp_User_Content(string ID,  string IsMenu)
    {
        SqlCommand cmd = new SqlCommand("Update_Menu_SignUp_User_Content", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);
        cmd.Parameters.AddWithValue("@IsMenu", IsMenu); 
        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }


    public int Delete_SignUp_User_Content(string Guid, string TypeID)
    {
        SqlCommand cmd = new SqlCommand("Delete_SignUp_User_Content", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Guid", Guid);
        cmd.Parameters.AddWithValue("@TypeID", TypeID); 

        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

 
    public int DeletePagesStaticContent(string ID)
    {
        SqlCommand cmd = new SqlCommand("DeletePagesStaticContent", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);

        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }
     
    public int UpdatePagesStaticContent(string ID, string Title, string IsMain, string CountNo)
    {
        SqlCommand cmd = new SqlCommand("UpdatePagesStaticContent", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@IsMain", IsMain);
        cmd.Parameters.AddWithValue("@CountNo", CountNo);

        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public int UpdatePagesStaticContentArchive(string ID, string Title, string IsMain, string CountNo,string Style)
    {
        SqlCommand cmd = new SqlCommand("UpdatePagesStaticContentArchive", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ID", ID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@IsMain", IsMain);
        cmd.Parameters.AddWithValue("@CountNo", CountNo);
        cmd.Parameters.AddWithValue("@Style", Style);

        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }

    public DataTable Get_StaticContents(string ID)
    {
        SqlDataAdapter da = new SqlDataAdapter("Get_StaticContents", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID", ID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

 
    public DataTable GetAllLinksForMenu(string Code,string ShowIn)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllLinksForMenu", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Code", Code);
        if (ShowIn != "0")
            da.SelectCommand.Parameters.AddWithValue("@ShowIn", ShowIn);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }


    public DataTable GetAllPagesStaticContent(string Code, string TypeID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllPagesStaticContent", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Code", Code);
        da.SelectCommand.Parameters.AddWithValue("@TypeID", TypeID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }



    public DataTable GetAllPagesStaticContentHome(string Code, string TypeID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetAllPagesStaticContentHome", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Code", Code);
        da.SelectCommand.Parameters.AddWithValue("@TypeID", TypeID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetUserContentByType(string Code, string TypeID)
    {
        SqlDataAdapter da = new SqlDataAdapter("GetUserContentByType", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Code", Code);
        da.SelectCommand.Parameters.AddWithValue("@TypeID", TypeID); 
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

  

    #endregion MyFunctions


    public string GetIpAddress()
    {
        System.Web.HttpContext context = System.Web.HttpContext.Current;
        string sIPAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (string.IsNullOrEmpty(sIPAddress))
        {
            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        else
        {
            string[] ipArray = sIPAddress.Split(new Char[] { ',' });
            return ipArray[0];
        }
    }
    public string GetPCName()
    {
        string PCName = HttpContext.Current.Request.ServerVariables["HTTP_HOST"].ToString();
        return PCName;
    }
    public string GetCurrentPageName()
    {
        string sPath = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        System.IO.FileInfo oInfo = new System.IO.FileInfo(sPath);
        string sRet = oInfo.Name;
        return sRet;
    }
 
    public int UpdateAdminPas(string password)
    {
        SqlCommand cmd = new SqlCommand("UpdateAdminPas", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@password", password);

        cmd.CommandTimeout = 0;
        conn.Open();
        int Result = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return Result;
    }


    

}

