<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update-page.aspx.cs" Inherits="admin_update_page" MasterPageFile="~/example/control/MasterPage.master" validateRequest="false" %>

<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="eeeree" runat="server"> 





      <div class="col-md-12 ">
                            <!-- BEGIN SAMPLE FORM PORTLET-->
                            <div class="portlet light bordered">
                                <div class="portlet-title">
                                    <div class="caption">
                                        <i class="icon-settings font-dark"></i>
                                        <asp:Label ID="lblTitle" runat="server" class="caption-subject font-dark sbold uppercase"></asp:Label>
                                    </div>
                                     
                                </div>
                                <div class="portlet-body form">
                                    <form role="form" class="form-horizontal">
                                        <div class="form-body">

                                             <div class="form-group">
                                                <label class="col-md-3 control-label"></label>
                                                <div class="col-md-9">
                                              <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                                                    </div>
                                                 </div>


                                            
                                             <div class="form-group"  id="TitleDiv" runat="server"  visible="false">
                                    	<label id="lbl_Title" runat="server" class="col-md-3 control-label">العنوان عربي</label>
                                                    <div class="col-md-9">
                                       <asp:TextBox ID="TxtTitle" runat="server"  class="form-control" ></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtTitle" 
                                        ErrorMessage="الرجاء ادخال العنوان" ></asp:RequiredFieldValidator>
                                    </div>	
                                                 </div>
									
									

                                   <div class="form-group" id="SummaryDiv"  runat="server">
                                                <label id="lblss" runat="server" class="col-md-3 control-label">الملخص</label>
                                                <div class="col-md-9">
                                        <asp:TextBox ID="TxtSummary" runat="server"  class="form-control"  TextMode="MultiLine" ></asp:TextBox>
										</div>
									</div>

									<div class="form-group"  id="SummaryDivEN" runat="server" visible="false">
										<label id="lblssen" runat="server" class="col-md-3 control-label"> الملخص - إنجليزي</label>
                                         <div class="col-md-9">
                                          <asp:TextBox ID="TxtSummaryEN" runat="server"  class="form-control"  TextMode="MultiLine" ></asp:TextBox>
										</div>
									</div>


                                
                                            <div class="form-group" runat="server" id="EditorDiv">
										<label  id="lbleditor" runat="server" class="col-md-3 control-label">المحتوى</label>
									 	<div class="col-md-9">
                                                <CE:Editor id="Editor"  CustomCulture="ar" AutoConfigure="Simple" ThemeType="Office2007" Width="100%" Height="400px" runat="server" ></CE:Editor>
                                            <asp:TextBox ID="TextBox1" runat="server"  class="form-control"   Visible="false" ></asp:TextBox>
										
                                              	</div>
									</div>

									<div id="EditorDivEN" class="form-group" runat="server" visible="false" >
										<label class="col-md-3 control-label">المحتوى - إنجليزي</label>
									 	<div class="col-md-9">
                                        <CE:Editor id="EditorEN"  CustomCulture="ar" AutoConfigure="Simple" ThemeType="Office2007" Width="100%" Height="400px" runat="server" ></CE:Editor>
                                         </div>
									</div>


                                
                                            <div id="ImgDiv" runat="server">
                                    
                                    
									  <div class="form-group">
										<label class="col-md-3 control-label"></label>
                                          	<div class="col-md-9">
                                        <asp:Image ID="Img" runat="server" Visible="false" Width="150px" />
										</div>
									</div>

									 <div class="form-group">
										<label class="col-md-3 control-label">الصورة </label>
                                         	<div class="col-md-9">
                                        <asp:FileUpload ID="FUImg" runat="server" />
										</div>
									</div>
                                    </div>



                                        </div>
                                        <div class="form-actions">
                                            <div class="row">
                                                <div class="col-md-offset-3 col-md-9">
                                                  
                                                         <asp:Button ID="btnAdd" runat="server" Text="إضافة" class="btn green" OnClick="btnAdd_Click" />
                                        <asp:Button ID="btnBack" runat="server" Text="عودة" class="btn default" OnClick="Back_Click" Visible="false" />
                                  
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <!-- END SAMPLE FORM PORTLET-->
                         
                        </div>










</asp:Content>
