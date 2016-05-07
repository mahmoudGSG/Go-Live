<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSite.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">


    <div style="float:right; width:300px; min-height:500px; margin-right:50px; margin-top:50px; margin-bottom:100px;">
                           
         <div class="titlesSite">اشترك الآن</div>
                            
                         
             <asp:Label ID="lblMsg"  runat="server"  style=" position:absolute; top:-29px; right:19px;"></asp:Label>

                                 <asp:TextBox ID="TxtName" runat="server" class="txt3" placeholder="الاسم كامل " ></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName"
                                        ErrorMessage="" CssClass="validPos" ></asp:RequiredFieldValidator>



                              <asp:TextBox ID="TxtEmail" runat="server" dir="ltr" class="txt3" placeholder="البريد الإلكتروني"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtEmail"
                                        ErrorMessage="" CssClass="validPos" ></asp:RequiredFieldValidator>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ControlToValidate="TxtEmail" ErrorMessage=""  CssClass="validPos"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                            meta:resourcekey="RegularExpressionValidator1Resource1" Display="Dynamic" 
                                            SetFocusOnError="true" ></asp:RegularExpressionValidator>


                             <asp:TextBox ID="txtMobile" runat="server" class="txt3" placeholder="رقم الموبايل" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtPassword" runat="server" class="txt3" placeholder="كلمة المرور" TextMode="Password" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtPasswordConfirm" runat="server" class="txt3" placeholder="تأكيد كلمة المرور"  TextMode="Password" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtSite" runat="server" class="txt3" placeholder="Site Url" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtTitle" runat="server" class="txt3" placeholder="WebSite Title" TextMode="MultiLine" style="height:70px;" ></asp:TextBox>

                             <asp:TextBox ID="txtDesc" runat="server" class="txt3" placeholder="WebSite Description" TextMode="MultiLine" style="height:70px;"  ></asp:TextBox>

                             <asp:FileUpload ID="LogoUpload" runat="server" ToolTip="شعار الموقع" />

                             <asp:TextBox ID="txtFacebook" runat="server" class="txt3" placeholder="رابط فيس بوك" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtTwitter" runat="server" class="txt3" placeholder="رابط توينر" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtGoogle" runat="server" class="txt3" placeholder="رابط جوجل بلس" ></asp:TextBox>
                             
                             <asp:TextBox ID="txtLinkedIn" runat="server" class="txt3" placeholder="رابط لينكد إن" ></asp:TextBox>
                             

                                        
                               <asp:Button ID="btnSend" runat="server"  class="btnsSite"  Text="التالي" OnClick="btnSend_Click" />



    </div>
   






</asp:Content>

