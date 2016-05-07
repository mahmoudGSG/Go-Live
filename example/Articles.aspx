<%@ Page Title=" " Language="C#" MasterPageFile="~/example/MasterPage.master" AutoEventWireup="true" CodeFile="Articles.aspx.cs" Inherits="Articles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     

          <div class="video_box_inn" style="margin-bottom:100px;">
                    
                    				<div class="marq_bg"><span><asp:Label ID="LblTitle" runat="server" ></asp:Label></span></div>
                                    

                                                                                                       <asp:UpdatePanel id="UPNews" runat="server">
 <ContentTemplate>

 <asp:Repeater ID="RpNews" runat="server">
                <ItemTemplate>





                                <div class="topics_box mdr_box ">
                                    <div class="topic_img2">
                                    <img src="../images/News/<%#Eval("FileName") %>" alt="" width="214" height="89"  />
                                    </div>
                                    <div class="fathBox2" style="width:70%;">
                                    <div class="topicsTitle2"><a href=""><%#DA.CutWord(Eval("Title").ToString(),70)%> </a></div>
                                    <div class="topicsCont2">
                                   <%#DA.CutWord(Eval("Summary").ToString(),250)%>
                                    </div>
                                </div>
                                </div>

                  

</ItemTemplate>
</asp:Repeater>

</ContentTemplate>
</asp:UpdatePanel>

<asp:Label ID="lblNoResults" CssClass="success" Text="لا يوجد بيانات" Visible="false" runat="server"></asp:Label>
                                    
                                 
                                   
                               <%--   
                                    
                                    <asp:UpdatePanel ID="UPanelNewsPager" runat="server" >
        <ContentTemplate>

							<div class="pager">
                            <ul>

                <asp:Repeater ID="rpPaging" runat="server" onitemcommand="rpPaging_ItemCommand">
                <ItemTemplate>
                <li><asp:LinkButton CssClass="pager_link" CommandName="Paging" Text='<%# Bind("Page") %>' runat="server" ID="btnPage"></asp:LinkButton></li>
                </ItemTemplate>
                </asp:Repeater>
                <asp:HiddenField ID="hdnCurrentPage" runat="server" Value="1" />


 </ul>
							

</ContentTemplate>
        </asp:UpdatePanel>

<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UPanelNewsPager">
<ProgressTemplate>
<div style="bottom: 36px;
    position: absolute;
    right: 330px;">
<img src="Images/loading.gif" />
</div>
</ProgressTemplate>
</asp:UpdateProgress>    --%> 


	


<asp:UpdatePanel ID="UPanelNewsPager" runat="server" >
        <ContentTemplate>

							<div class="pager">
    <asp:Repeater ID="RpNewPagesNumber" runat="server">     
    <ItemTemplate>

           <asp:Button ID="btnNewPagesNumber" runat="server" class='<%# Eval("PageCssClass") %>' Text='<%# Eval("PageNumber") %>' CausesValidation="false"
           style="background-color:Transparent;border:none" 
           onclick="btnNewPagesNumber_Click" meta:resourcekey="btnNewPagesNumberResource1" />
          
    </ItemTemplate>
    </asp:Repeater>
 
							</div>

</ContentTemplate>
        </asp:UpdatePanel>


        
<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UPanelNewsPager">
<ProgressTemplate>
<div style="bottom: 36px;
    position: absolute;
    right: 330px;">
<img src="Images/loading.gif" />
</div>
</ProgressTemplate>
</asp:UpdateProgress>
                    
             





					  </div>
                    

           
</asp:Content>