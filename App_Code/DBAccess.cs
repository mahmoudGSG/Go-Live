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
/// Summary description for DBAccess
/// </summary>
public class DBAccess : System.Web.UI.Page
{
    public int MSCaptchaAddNo = 3;
    private System.Data.SqlClient.SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GoLiveConn"].ToString());

	public DBAccess()
	{
		//
		// TODO: Add constructor logic here
		//
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


    public DataTable GetTopMainImage()
    {
        SqlDataAdapter da = new SqlDataAdapter("SP_GetTopMainImage", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetContacts(string CatgID, string LangID)
    {
        SqlDataAdapter da = new SqlDataAdapter("SP_GetContacts", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@CatgID", CatgID);
        if (LangID != "0")
            da.SelectCommand.Parameters.AddWithValue("@LangID", LangID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

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


    public DataTable GetPageDetails(string CatgId, string LangID)
    {
        SqlDataAdapter da = new SqlDataAdapter("SP_GetPageDetails", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@CatgId", CatgId);
        if (LangID != "0")
            da.SelectCommand.Parameters.AddWithValue("@LangID", LangID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }

    public DataTable GetServices(string LangID)
    {
        SqlDataAdapter da = new SqlDataAdapter("SP_GetServices", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if (LangID != "0")
            da.SelectCommand.Parameters.AddWithValue("@LangID", LangID);
        da.SelectCommand.CommandTimeout = 0;
        DataTable Dt = new DataTable();
        da.Fill(Dt);
        return Dt;
    }
}