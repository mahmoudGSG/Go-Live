<%@ Page Title=" " Language="C#" MasterPageFile="~/example/control/MasterPage.master" AutoEventWireup="true" CodeFile="edit-news.aspx.cs" Inherits="admin_edit_news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

			
					
							<div runat="server" visible="false" >
                            <asp:Label ID="lbl" Text="القســم : " runat="server"></asp:Label>

                            <asp:DropDownList ID="ddlNewscategory" runat="server" DataTextField="AName" 
                                                DataValueField="ID" AutoPostBack="true" 
                                                onselectedindexchanged="ddlNewscategory_SelectedIndexChanged" ></asp:DropDownList>
</div>
                         
				
                                    <asp:Button ID="btnBack" Visible="false" OnClick="btnBack_Click" CssClass="vote_submit back no-f" runat="server" />


								<div class="portlet light portlet-fit bordered">
                        <div class="portlet-title">
                            <div class="caption">
                                <i class="icon-settings font-dark"></i>
                                <asp:Label ID="lblTitle" runat="server"  class="caption-subject font-dark sbold uppercase"></asp:Label>
                            </div>
                          
                        </div>
                        <div class="portlet-body">
                            <div class="row">
                                <div class="col-md-12">
                                    <table class="table table-bordered table-striped" id="user">
                                        <tbody>

                                              
                                            <tr>
                                                 <th>العنوان </th>
			                            <th>القسم</th>
			                            <th>التاريخ</th>
			                            <th>تعديل</th>
                                            </tr>

   <asp:Repeater ID="RpNews" runat="server">
                                <ItemTemplate>
                                    <tr>
			                            <td style="text-align: right; width:70%;"><%#Eval("Title").ToString()=="" ?Eval("Summary"):Eval("Title") %></td>
                                        <td style="text-align: right;"><%#Eval("CategoryName")%></td>
                                        <td style="text-align: right;"><%#Eval("InsertDate") %></td>
			                            <td><a href="add-news.aspx?Cat=<%#Eval("CategoryID") %>&ID=<%#Eval("ID") %>">تعديل</a></td>
			                        </tr>
                                </ItemTemplate>
                                </asp:Repeater>

                                            </tbody>
                                            </table>



</div>

                                </div>

                            </div>
                                    </div>

                             



</asp:Content>

