<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSite.master" AutoEventWireup="true" CodeFile="Sections.aspx.cs" Inherits="Sections" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">


    <div style="float:right; width:300px; min-height:100px; margin-right:50px; margin-top:50px;position:relative;">
                           
         <div class="titlesSite">الاضافات الاساسية</div>
                
          <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                    
                         
             <asp:Label ID="lblMsg"  runat="server"  style=" position:absolute; top:-29px; right:19px;"></asp:Label>

                            
         <asp:Repeater ID="RptStatic" runat="server">
<ItemTemplate>
           
        <div class="checkBox" >
            <asp:CheckBox ID="StaticContentChk" runat="server"  Checked='<%#  Eval("InSite").ToString() == "1" ? true : false %>' Text='<%#Eval("Title") %>' ChkID='<%#Eval("ID") %>' />
        </div>
 
    </ItemTemplate>
             </asp:Repeater>

                <asp:Button ID="btnSave" runat="server"  class="btnsSite"  Text="حفظ" OnClick="btnSave_Click" />


                </ContentTemplate>
              </asp:UpdatePanel>
        
        
    </div>
        <br /> 

    <div style="float:right; width:80%; min-height:100px; margin-right:50px; margin-top:50px; position:relative;">
    
         <div class="titlesSite">الصفحات الثابتة</div>
         

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                  <asp:Label ID="Label1"  runat="server"  style=" position:absolute; top:-29px; right:19px;"></asp:Label>


        <table class="table" width="70%">
            <tr style="width:80%;">

                <td style="width:50%;">
                     <asp:TextBox ID="TxtName" style="width:80%;" runat="server" class="txt3" placeholder="اسم الصفحة " ></asp:TextBox>
                </td>
                <td  style="width:15%;">
  <asp:CheckBox ID="IsMain" runat="server" Text='In Home' />
       
                </td>
                <td  style="width:15%;">
  <asp:Button ID="SaveBtn" runat="server"  class="btnsSite"  Text="اضافة + " OnClick="SaveBtn_Click" />

                </td>
            </tr>


             <asp:Repeater ID="Repeater1" runat="server"  OnItemCommand="Repeater1_ItemCommand">
<ItemTemplate>

             <tr style="width:80%;">

                <td style="width:50%;">
                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Title") %>'  class="txt3"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" Text='<%#Eval("Title") %>'  class="txt3" Visible="false" ></asp:TextBox>
                </td>
                <td  style="width:15%;">
<asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Convert.ToBoolean(Eval("IsMain").ToString()) %>' Text='In Home' />
  
                </td>
                <td  style="width:15%;">  
                    <asp:LinkButton ID="lnkEdit"   runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="edit"   Visible="true" class="print print1"><span class="icon-pencil4">Edit</asp:LinkButton> 
                                                            <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                                            <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
                  
                                      <asp:LinkButton ID="lnkDelete" class="setting-item del" CausesValidation="false" CommandName="delete" CommandArgument='<%#Eval("ID") %>'  runat="server" TeamID='<%#Eval("ID") %>'  OnClientClick='javascript:return confirm("هل انت متأكد من الحذف ؟")'   >
                                           <i class="fa fa-times"></i>Delete</asp:LinkButton>
                                     

                </td>

            </tr>

    </ItemTemplate>
                 </asp:Repeater>


        </table>

                       </ContentTemplate>
                </asp:UpdatePanel>
        
        
        


   </div>




      <div style="float:right; width:80%; min-height:150px; margin-right:50px; margin-top:10px; position:relative; margin-bottom:100px; ">
    
         <div class="titlesSite">صفحات الارشفة</div>
         

        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>

                  <asp:Label ID="Label2"  runat="server"  style=" position:absolute; top:-29px; right:19px;"></asp:Label>


        <table class="table" width="70%">
            <tr style="width:80%;">

                <td style="width:40%;">
                     <asp:TextBox ID="txtArticals" style="width:80%;" runat="server" class="txt3" placeholder="اسم الصفحة " ></asp:TextBox>
                </td>
                <td  style="width:25%;">
  <asp:CheckBox ID="chkMain" runat="server" Text='In Home' AutoPostBack="true" OnCheckedChanged="chkMain_CheckedChanged" />
           <asp:TextBox ID="txtCount" style="width:100px" runat="server" class="txt3" Visible="false" placeholder="عدد العناصر " ></asp:TextBox>
               
                </td>

                 <td style="width:15%;">
                     <asp:DropDownList ID="DDLStyle" runat="server" style="float:right;">
                         <asp:ListItem Value="1">Item</asp:ListItem>
                         <asp:ListItem Value="2">Grid</asp:ListItem>
                     </asp:DropDownList>
                </td>

                <td  style="width:15%;">
  <asp:Button ID="Button1" runat="server"  class="btnsSite"  Text="اضافة +" OnClick="Button1_Click" />

                </td>
            </tr>


             <asp:Repeater ID="Repeater2" runat="server"  OnItemCommand="Repeater2_ItemCommand" OnItemDataBound="Repeater2_ItemDataBound">
<ItemTemplate>

             <tr style="width:80%;">

                <td style="width:40%;">
                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Title") %>'  class="txt3"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" Text='<%#Eval("Title") %>'  class="txt3" Visible="false" ></asp:TextBox>
                </td>
                <td  style="width:25%;">
<asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Convert.ToBoolean(Eval("IsMain").ToString()) %>' Text='In Home' AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" />
   <asp:TextBox ID="txtCount" style="width:100px" runat="server" class="txt3" Visible="false" Text='<%#Eval("CountNo") %>'  placeholder="عدد العناصر " ></asp:TextBox>
          
                </td>

                   <td style="width:15%;" >
                     <asp:DropDownList ID="DDLStyle" runat="server" style="float:right;">
                         <asp:ListItem Value="1">Item</asp:ListItem>
                         <asp:ListItem Value="2">Grid</asp:ListItem>
                     </asp:DropDownList>
                </td>


                <td  style="width:15%;">  
                    <asp:LinkButton ID="lnkEdit"   runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="edit"   Visible="true" class="print print1"><span class="icon-pencil4">Edit</asp:LinkButton> 
                                                            <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                                            <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("ID") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
                  
                                      <asp:LinkButton ID="lnkDelete" class="setting-item del" CausesValidation="false" CommandName="delete" CommandArgument='<%#Eval("ID") %>'  runat="server" TeamID='<%#Eval("ID") %>'  OnClientClick='javascript:return confirm("هل انت متأكد من الحذف ؟")'   >
                                           <i class="fa fa-times"></i>Delete</asp:LinkButton>
                                     

                </td>

            </tr>

    </ItemTemplate>
                 </asp:Repeater>


        </table>

                       </ContentTemplate>
                </asp:UpdatePanel>
        
        <br /><br /><br />
        
                         
                               <asp:Button ID="Button2" runat="server"  class="btnsSite"  Text="التالي" OnClick="btnSend_Click" />



   </div>





</asp:Content>

