<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Contact.ascx.cs" Inherits="Contact" %>
<%@ Register assembly="MSCaptcha" namespace="MSCaptcha" tagprefix="cc1" %>



                    	<div class="left" >
                            <div class="titles3">ارسل رسالة لنا</div>
                            
                              <asp:UpdatePanel ID="UpdatePanel1"  runat="server">
        <ContentTemplate>
             <asp:Label ID="lblMsg"  runat="server"  style=" position:absolute; top:-29px; right:19px;"></asp:Label>

                                 <asp:TextBox ID="TxtName" runat="server" class="txt2" placeholder="الاسم" ></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName"
                                        ErrorMessage="" CssClass="validPos" ></asp:RequiredFieldValidator>



                              <asp:TextBox ID="TxtEmail" runat="server" dir="ltr" class="txt2" placeholder="البريد الإلكتروني"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtEmail"
                                        ErrorMessage="" CssClass="validPos" ></asp:RequiredFieldValidator>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ControlToValidate="TxtEmail" ErrorMessage=""  CssClass="validPos"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                            meta:resourcekey="RegularExpressionValidator1Resource1" Display="Dynamic" 
                                            SetFocusOnError="true" ></asp:RegularExpressionValidator>


                             <asp:TextBox ID="TxtSubject" runat="server" class="txt2" placeholder="رقم التواصل" ></asp:TextBox>
                             

                               <asp:TextBox ID="TxtMessage" runat="server" TextMode="MultiLine" class="area" placeholder="محتوى الرسالة"  style="resize:none;"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtMessage" CssClass="validPos"
                                        ErrorMessage="" ></asp:RequiredFieldValidator>

                                        
                               <asp:Button ID="btnSend" runat="server"  class="btns"
                                                     onclick="btnSend_Click" Text="إرسال" />


                                 <div id="CaptchaDiv" runat="server" visible="false">

									<div class="inpt" >

										<div class="txtcont" >
											<label for=""></label>
                                            <cc1:CaptchaControl ID="captcha" runat="server" 
                                    CaptchaLineNoise="Low" FontColor="Black" NoiseColor="Gray" 
                                    BackColor="White" CaptchaChars="ACDEFGHJKLNPQRTUVXYZ2346789" 
                                    CaptchaMinTimeout="3" LineColor="Black" />
										</div>
										<div style="clear:right;height:5px;">
											&nbsp;
										</div>
									</div>


									<div class="inpt" >

										<div class="txtcont" >
											<label for="TxtCaptcha">رمز التحقق</label>
                                        <asp:TextBox ID="TxtCaptcha" runat="server" dir="ltr" class="txt1 TxtCaptcha"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtCaptcha" 
                                        ErrorMessage="" CssClass="validPos" ></asp:RequiredFieldValidator>
										</div>
										<div style="clear:right;height:5px;">
											&nbsp;
										</div>
									</div>





                                    </div>


                 </ContentTemplate>
        </asp:UpdatePanel>

<asp:UpdateProgress ID="UpdateProgress1" runat="server">
<ProgressTemplate>
<div style="position: absolute;
    right: 145px;
    top: -45px;">
<img src="Images/loading.gif" />
</div>
</ProgressTemplate>
</asp:UpdateProgress>          

                                    </div>
                      
                       
               



                                  
