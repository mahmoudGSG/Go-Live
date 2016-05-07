<%@ Page Title=" " Language="C#" MasterPageFile="~/example/control/MasterPage.master" AutoEventWireup="true" CodeFile="delete-news.aspx.cs" Inherits="admin_edit_news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

		
							<div runat="server" visible="false" >
                            <asp:Label ID="lbl" Text="القســم : " runat="server"></asp:Label>

                            <asp:DropDownList ID="ddlNewscategory" runat="server" DataTextField="AName" 
                                                DataValueField="ID" AutoPostBack="true" 
                                                onselectedindexchanged="ddlNewscategory_SelectedIndexChanged" Width="200" ></asp:DropDownList>

                       
                            </div>



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

                                     <asp:LinkButton ID="lnkDelSelected" ForeColor="black" runat="server" style="float:right;" onclick="LinkButton1_Click" OnClientClick='javascript:return confirm("هل انت متأكد ؟")'>حذف المحدد</asp:LinkButton>
        <br />
                                         <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                                    <br />
                                    <table class="table table-bordered table-striped" id="user">
                                        <tbody>

                                              
                                            <tr>

                                                <th> <asp:CheckBox ID="chkSelectAll" runat="server" AutoPostBack="true" OnCheckedChanged="chkSelectAll_CheckedChanged"/>
                     الكل</th>

                                                 <th>العنوان </th>
			                            <th>القسم</th>
			                            <th>التاريخ</th>
			                             <th>حذف</th>
			                  
                                            </tr>

 <asp:Repeater ID="RpNews" runat="server" OnItemCommand="cpRepeater_ItemCommand">
                                <ItemTemplate>
                                    <tr >

                                     <td> 
                      <asp:CheckBox ID="chkDelete" Val='<%#Eval("ID") %>' runat="server" />

                      <asp:Label ID="lblID" Visible="false" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
            <asp:Label ID="lblName" Visible="false" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
            <asp:TextBox ID="txtName" BackColor="#d4d0c8" runat="server" Text='<%#Eval("ID")%>' Visible="false"></asp:TextBox>
            <asp:DropDownList ID="ddlType" runat="server" Visible="false">
            </asp:DropDownList>

                      </td>

			                            <td style="text-align: right;"><%#Eval("Title").ToString()=="" ?Eval("Summary"):Eval("Title") %></td>
                                        <td style="text-align: right;"><%#Eval("CategoryName")%></td>
                                        <td style="text-align: right;"><%#Eval("InsertDate") %></td>
			                            <td>
<asp:LinkButton ID="btnDelete"  CommandName="delete" CommandArgument='<%#Eval("id") %>' Text="حذف" runat="server" NewsID='<%#Eval("ID") %>'  OnClientClick='javascript:return confirm("هل انت متأكد من الحذف ؟")'   />
                                        </td>
			                        </tr>
                                </ItemTemplate>
                                </asp:Repeater>

</tbody>
                                        </table>



</div>

                                </div>
                            </div>

            </div>

    

			                    
                                    <asp:Button ID="btnBack" Visible="false" OnClick="btnBack_Click" CssClass="vote_submit back no-f" runat="server" />
									


</asp:Content>

