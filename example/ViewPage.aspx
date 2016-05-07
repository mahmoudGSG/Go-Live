<%@ Page Title=" " Language="C#" MasterPageFile="~/example/MasterPage.master" AutoEventWireup="true" CodeFile="ViewPage.aspx.cs" Inherits="ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">




 <div class="video_box_inn">
                    	<div class="marq_bg"><span id="lblTitle" runat="server">عن الشركــــــة </span></div>
                    				
                       <div class="box_inn">

										<div class="drcont_box">
                                     
                                     <asp:Repeater ID="RpAboutUS" runat="server">
<ItemTemplate>
<%#Eval("Details").ToString() == "" ? Eval("Summary") : Eval("Details")%>
</ItemTemplate>
</asp:Repeater>
<asp:Label ID="lblNoResults" CssClass="success" Text="لا يوجد بيانات" Visible="false" runat="server"></asp:Label>
                                      
                                     
                                     
                                       </div>
						</div>
          
					</div>
                    	



</asp:Content>

