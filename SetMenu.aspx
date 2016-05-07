<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSite.master" AutoEventWireup="true" CodeFile="SetMenu.aspx.cs" Inherits="SetMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">


    <div style="float:right; width:300px; min-height:100px; margin-right:50px; margin-top:50px;position:relative;">
                           
         <div class="titlesSite">العرض في القائمة الرئيسية</div>
                
          <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                    
                         
             <asp:Label ID="lblMsg"  runat="server"  style=" position:absolute; top:-29px; right:19px;"></asp:Label>

                            
         <asp:Repeater ID="RptStatic" runat="server">
<ItemTemplate>
           
        <div class="checkBox" >
            <asp:CheckBox ID="StaticContentChk" runat="server"  Checked='<%#  Eval("InMenu").ToString() == "True" ? true : false %>' Text='<%#Eval("Title") %>' ChkID='<%#Eval("ID") %>' />
        </div>
 
    </ItemTemplate>
             </asp:Repeater>

                <asp:Button ID="btnSave" runat="server"  class="btnsSite"  Text="حفظ" OnClick="btnSave_Click" />


                </ContentTemplate>
              </asp:UpdatePanel>
        
         <br />  <br />  <br />  <br /> 
             <asp:Button ID="Button2" runat="server"  class="btnsSite"  Text="انهاء" OnClick="btnSend_Click" />


        
    </div>
        <br /> 
 


</asp:Content>

