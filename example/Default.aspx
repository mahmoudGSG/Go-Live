<%@ Page Title=" " Language="C#" MasterPageFile="~/example/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    	<div class="IN_PAGES">
            

             <asp:Repeater ID="RptPages" runat="server" OnItemDataBound="RptPages_ItemDataBound" >
<ItemTemplate>

             	<div class="service"  >
                	<a href="#" class="titles"><%#Eval("Title") %></a>
                    <div class="service_box">
                         <asp:Repeater ID="RpAboutUS" runat="server">
<ItemTemplate>
 <%#DA.CutWord(Eval("Summary").ToString(),500)%>
</ItemTemplate>
</asp:Repeater>
                    </div>
                </div>
                
                </ItemTemplate>
                 </asp:Repeater>

                            

                     
            	<section class="page">
                	<div class="IN_PAGES">


               		   <asp:Repeater ID="Repeater5" runat="server" OnItemDataBound="Repeater5_ItemDataBound">
<ItemTemplate>
                                <section class="our_work" id="Wwork">
                                <a href="" class="titles"><%#Eval("Title") %></a>
                                 	
                                <div class="work">
                                
                                  <section   style="display:block;" class="work2">

                                   
                                                <asp:Repeater ID="Repeater5_1" runat="server">
<ItemTemplate>
                                    	<div class="product2" >
                                        	<span class="new"></span>
                                        	<a href=" "   >
                                            	<img src="../images/News/<%#Eval("FileName") %>" height="211" width="213" alt='<%#Eval("Title")%>'>
                                                	<span class="fa fa-search view"></span>
                                                    <span class="fa fa-link view2"></span>
                                                <div class="work_dec">
                                                    <h1><%#DA.CutWord(Eval("Title").ToString(),70)%> </h1>
                                                    <p><%#DA.CutWord(Eval("Summary").ToString(),150)%></p> 
                                                </div>
                                            </a>
                                        </div>

    
    </ItemTemplate>
           </asp:Repeater>


       <asp:Repeater ID="Repeater5_2" runat="server">
<ItemTemplate>

    <div class="newc_box" >
                                            <a href="" class="newc_img"><img src="../images/News/<%#Eval("FileName") %>" alt='<%#Eval("Title")%>' /> </a>
                                            <div class="topicsTitle"><%#DA.CutWord(Eval("Title").ToString(),70)%>  </div>
                                            <div class="fathBox">
                                                <p class="topicsCont">
                                                   <%#DA.CutWord(Eval("Summary").ToString(),150)%>
                                                </p>
                                                  <p class="topicsCont"  style="margin-top:15px; font-weight:bold; font-family:Arial; font-size:9pt;"> <%#Eval("Date","{0:dd/MM/yyyy}") %> </p>
                                            </div>
                                        </div>


                                      
    
    </ItemTemplate>
                                          </asp:Repeater>
                                    	
                                    </section>

                                     

                                </div>    	
                                    
                                    
                                    
                                </section>
                                
                                
                                
                                 </ItemTemplate>
                              </asp:Repeater>
                                 
                                 
                    </div>
                                
                                
                                
                                
                                
                                
                </section>              
                    </div>

     

</asp:Content>

