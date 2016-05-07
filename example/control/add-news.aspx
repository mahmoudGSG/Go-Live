<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add-news.aspx.cs" Inherits="admin_add_news" MasterPageFile="~/example/control/MasterPage.master" ValidateRequest="false" %>


<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="fvcccc" runat="server">


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



                                      <div class="form-group" runat="server" id="ddlCategoryBox"   visible="false"  > 
										 <label class="col-md-3 control-label">القسم</label>
                                             <div class="col-md-9">
                                        <asp:DropDownList ID="ddlCategory" runat="server" DataTextField="AName" DataValueField="ID" CssClass="form-control" ></asp:DropDownList>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCategory"  InitialValue="-1"
                                        ErrorMessage="الرجاء اختيار القسـم" ></asp:RequiredFieldValidator>
										</div>
									</div>

                                              <div class="form-group" id="SummarDiv" runat="server" visible="false">
										<label class="col-md-3 control-label" id="lblSummary" runat="server" >الرابط</label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtSummary" runat="server" TextMode="MultiLine" CssClass="form-control" ></asp:TextBox>
                                       </div>
									</div>

                                            
                                            		  <div class="form-group" id="TitleDivEN" runat="server" visible="false">
										<label class="col-md-3 control-label" id="Label1" runat="server"> العنوان - انجليزي</label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtTitleEN" runat="server" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtTitleEN" 
                                        ErrorMessage="الرجاء ادخال العنوان" ></asp:RequiredFieldValidator>
</div>
									</div>

                                              <div class="form-group" id="TitleDivEN11" runat="server" visible="false" >
										<label class="col-md-3 control-label" id="title2" runat="server">وصف الصورة</label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtTitleENo" runat="server" class="form-control"></asp:TextBox>
                                        
										</div>
									</div>
									


                               							
									  <div class="form-group" id="TitleDiv" runat="server">
										<label class="col-md-3 control-label" id="title1" runat="server">العنوان</label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtTitle" runat="server" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtTitle" 
                                        ErrorMessage="الرجاء ادخال العنوان" ></asp:RequiredFieldValidator>
</div>
									</div>



                                   <div class="form-group" runat="server" id="Div1" visible="false" > 
										<label class="col-md-3 control-label">الجنس</label>
                                          <div class="col-md-9">
                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"  >
                                            <asp:ListItem Value="1">ذكر</asp:ListItem>
                                            <asp:ListItem Value="2">أنثى</asp:ListItem>
                                        </asp:DropDownList>
                                       
										</div>
									</div>

                                   <div class="form-group" runat="server" id="Div2" visible="false" > 
										<label class="col-md-3 control-label" >العمر</label>
                                          <div class="col-md-9">
                                        <asp:DropDownList ID="DropDownList2" runat="server"  CssClass="form-control" >
                                            <asp:ListItem Value="1">1 - 4 سنوات</asp:ListItem>
                                            <asp:ListItem Value="2">5 - 10 سنوات</asp:ListItem>
                                            <asp:ListItem Value="3">11 - 15 سنة</asp:ListItem>
                                        </asp:DropDownList>
                                       
										</div>
									</div>


                                  <div class="form-group" runat="server" id="Div3" visible="false" > 
										<label class="col-md-3 control-label">عدد اللاعبين</label>
                                        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control" >
                                            <asp:ListItem Value="1">لاعب واحد</asp:ListItem>
                                            <asp:ListItem Value="2">لاعبين</asp:ListItem>
                                            <asp:ListItem Value="3">اكثر من 3 لاعبين</asp:ListItem>
                                        </asp:DropDownList>
                                       
										<div class="clear">&nbsp;</div>
									</div>



									



									  <div class="form-group" id="PriceDiv" runat="server" visible="false" >
										<label class="col-md-3 control-label" id="aa" runat="server">الرابط</label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtPrice" runat="server" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtPrice" 
                                        ErrorMessage="الرجاء ادخال السعر" ></asp:RequiredFieldValidator>
<%--<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="ادخل السعر أرقام فقط"
                        ControlToValidate="TxtPrice" SetFocusOnError="true" MaximumValue="999999999999999"
                        MinimumValue="1" Type="Double"  Display="Dynamic"></asp:RangeValidator>--%>
										</div>
									</div>

									  <div class="form-group" id="OldPriceDiv" runat="server" visible="false" >
										<label class="col-md-3 control-label">السعر </label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtOldPrice" runat="server" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtOldPrice" 
                                        ErrorMessage="الرجاء ادخال السعر " ></asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="ادخل السعر أرقام فقط"
                        ControlToValidate="TxtOldPrice" SetFocusOnError="true" MaximumValue="999999999999999"
                        MinimumValue="1" Type="Double"  Display="Dynamic"></asp:RangeValidator>
										</div>
									</div>



									
									
									
									  <div class="form-group" id="EditorDiv" runat="server">
										<label class="col-md-3 control-label" id="lblEditor" runat="server">المحتوى </label>
                                             <div class="col-md-9">
								        <CE:Editor id="Editor"  CustomCulture="ar" AutoConfigure="Simple" ThemeType="Office2007" Width="100%" Height="400px" runat="server" ></CE:Editor>
									   <%--  <asp:TextBox ID="Editor" runat="server"  class="form-control"  TextMode="MultiLine" style="min-height:200px;" ></asp:TextBox>
                                        
                                       --%>   <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="EditorDivRequiredFieldValidator" runat="server" ControlToValidate="Editor" 
                                          ErrorMessage="الرجاء ادخال المحتوى" ></asp:RequiredFieldValidator>
										</div>
									</div>

									  <div class="form-group" id="EditorDivEN" runat="server"  visible="false" >
										<label class="col-md-3 control-label" id="lblEditorEN" runat="server">المحتوى - انجليزي</label>
								   <div class="col-md-9">
<%--<CE:Editor id="EditorEN"  CustomCulture="ar" AutoConfigure="Full" ThemeType="Office2007" Width="100%" Height="400px" runat="server" ></CE:Editor>--%>
                                         <asp:TextBox ID="EditorEN" runat="server"  class="form-control"  TextMode="MultiLine" style="min-height:200px;" ></asp:TextBox>
 <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="EditorEN" 
                                          ErrorMessage="الرجاء ادخال المحتوى" ></asp:RequiredFieldValidator>
										</div>
									</div>

                                    <div id="ImgDiv" runat="server" >

									  <div class="form-group">
										<label class="col-md-3 control-label"></label>
                                             <div class="col-md-9">
                                        <asp:Image ID="Img" runat="server" Visible="false"  />
										</div>
									</div>

									  <div class="form-group" >
										<label class="col-md-3 control-label">الصورة</label>
                                             <div class="col-md-9">
                                        <asp:FileUpload ID="FUImg" runat="server" CssClass="" />
										</div>
									</div>
									</div>


                                  <div class="form-group" runat="server" visible="false" >
										<label class="col-md-3 control-label">ملف PDF</label>
                                         <div class="col-md-9">
                                        <asp:FileUpload ID="FUImg2" runat="server" CssClass="form-control"  />
										</div>
									</div>


                                     <div class="form-group" id="SummarDivEN" runat="server"  visible="false"  >
										<label class="col-md-3 control-label" id="lblSummaryEN" runat="server" >الفيديو YouTube</label>
                                          <div class="col-md-9">
                                          <asp:TextBox ID="TxtSummaryEN" runat="server" TextMode="MultiLine"  CssClass="form-control" ></asp:TextBox>
                                        <%--<asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="TxtSummaryENRequiredFieldValidator" runat="server" ControlToValidate="TxtSummaryEN" 
                                          ErrorMessage="الرجاء ادخال مقتطف - انجليزي" ></asp:RequiredFieldValidator>--%>
										</div>
									</div>



                                    <div id="DateDiv" runat="server" visible="false">
									  <div class="form-group" runat="server" >
										<label class="col-md-3 control-label" runat="server" id="datet">تاريخ الاضافة</label>
                                             <div class="col-md-9">
                                        <asp:TextBox ID="TxtDate" runat="server" date=true class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ForeColor="Red" Display="Dynamic" 
                                        ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtDate" 
                                        ErrorMessage="الرجاء ادخال تاريخ" ></asp:RequiredFieldValidator>
										 </div>
									</div>

                                    </div>


                                     <div class="form-group" runat="server" id="ShowS" dir="rtl" visible="false" >
										<label class="col-md-3 control-label">تفعيل الادارة</label>
                                            <div class="col-md-9">
                                        <asp:CheckBox ID="CheckBox1"  runat="server" />
										 </div>
									</div>
									


									  <div class="form-group">
									    <label class="col-md-3 control-label">&nbsp;</label>
                                             <div class="col-md-9">
									    <asp:Button ID="btnUpdate" class="btn green" Visible="false" runat="server" onclick="btnUpdate_Click" Text="تحديث" />
										 </div>
									</div>
								
									
									

                                        </div>
                                        <div class="form-actions">
                                            <div class="row">
                                                <div class="col-md-offset-3 col-md-9">
                                                  
                                                         <asp:Button ID="btnAdd" runat="server" Text="إضافة" class="btn green" OnClick="btnAdd_Click"  />
                                        <asp:Button ID="btnBack" runat="server" Text="عودة" class="btn default"  CausesValidation="false" onclick="btnBack_Click" Visible="false" />
                                  
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <!-- END SAMPLE FORM PORTLET-->
                         
                        </div>





</asp:Content>

