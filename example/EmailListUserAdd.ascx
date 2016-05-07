<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmailListUserAdd.ascx.cs" Inherits="EmailListUserAdd" %>
<asp:Panel ID="Palen1" runat="server" DefaultButton="btnEmailAdd">
<asp:UpdatePanel ID="UpdatePanelEmail" runat="server">
<ContentTemplate>

 
                    
                 <span class="company_titles2">اشترك معنا ليصلك كل جديد</span>
                    <asp:Label ID="lblMsg" runat="server"
style="position: absolute;
    right: 90px;
    top: 40px; color:Green;"></asp:Label>
 
 

<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanelEmail">
<ProgressTemplate>
<div style="
    position: absolute;
    right: 263px;
    top: -16px;">
<img src="Images/loading.gif" />
</div>
</ProgressTemplate>
</asp:UpdateProgress>



                     
                     


   
                                            	<div class="emails"> 
                                                     <asp:TextBox ID="TxtEmail" runat="server" placeholder="example@domain.com"  CssClass="txt3"></asp:TextBox>
                                
                                                       <asp:Button ID="btnEmailAdd" runat="server"  CssClass="btn"  ValidationGroup="Email" onclick="btnEmailAdd_Click" />
                                                </div>
 
                    
                 
                     
     




</ContentTemplate>
</asp:UpdatePanel>



</asp:Panel>
