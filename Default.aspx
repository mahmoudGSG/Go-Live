<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSite.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <div class="IN_PAGES">

        <div class="service" id="Serv" style="width: 730px !important;">
            <a href="#" class="titles">خدمات الشركة</a>
            <div class="service_box">

                <asp:Repeater ID="RptServices" runat="server">
                    <ItemTemplate>

                        <a href="#" class="service2">
                            <span>
                                <img src="img/<%#Eval("FileName") %>" height="70" width="71" /></span>
                            <h1><%#CutWord(Eval("Title").ToString(),30)%></h1>
                            <p><%#CutWord(Eval("Summary").ToString(),200)%> </p>
                        </a>

                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>

        <div class="about_box" id="About">
            <div class="dataway2">
                <a id="A1" href="~/" runat="server" class="logo"></a>
                <h1>عن الشركة </h1>
                <p>

                    <asp:Repeater ID="RpAboutUS" runat="server">
                        <ItemTemplate>
                            <%#CutWord(Eval("Summary").ToString(),400)%>
                        </ItemTemplate>
                    </asp:Repeater>

                </p>
            </div>

        </div>

        <section class="page">
            <div class="IN_PAGES">

                <section class="our_work" id="Wwork">
                    <a href="#" class="titles">منصة العمل </a>

                    <ul class="tab" style="margin-right: 370px !important;">

                        <li class="active4"><a href="#tab3" class="web2"></a></li>
                        <li><a href="#tab2" class="web3"></a></li>
                        <li><a href="#tab1" class="web"></a></li>

                    </ul>

                    <div class="work">

                        <section id="tab3" style="display: block;" class="work2">
                                 <div class="dataway2">
                
                                      <p style="color:#232323;">
يمكنك البدء بانشاء الموقع الالكتروني الخاص بك من هنا .. اضغط الزر و اتبع الخطوات  .. اصنع موقعك الخاص خلال أقل من دقيقتين
                                          </p>
                                     <a href="SignUp.aspx" class="outBtn" style="width: 50%;padding: 5px; background: #2691d7;
                                                                      margin: auto; line-height: 35px; margin-right: 25%; margin-top: 50px;">جرب الآن ... مجانا</a>
            </div>
                        </section>

                        <section id="tab2" class="work2">
                                            <div class="dataway2">
                
                                      <p style="color:#232323;">
يمكنك البدء بانشاء التطبيق  الخاص بك من هنا .. اضغط الزر و اتبع الخطوات  .. اصنع موقعك الخاص خلال أقل من دقيقتين
                                          </p>
                                     <a href="#" class="outBtn" style="width: 50%;padding: 5px; background: #2691d7;
                                                                      margin: auto; line-height: 35px; margin-right: 25%; margin-top: 50px;">جرب الآن ... مجانا</a>
            </div>
                        </section>

                        <section id="tab1" class="work2">
                                            <div class="dataway2">
                
                                      <p style="color:#232323;">
يمكنك البدء بانشاء العرض  الخاص بك من هنا .. اضغط الزر و اتبع الخطوات  .. اصنع موقعك الخاص خلال أقل من دقيقتين
                                          </p>
                                     <a href="#" class="outBtn" style="width: 50%;padding: 5px; background: #2691d7;
                                                                      margin: auto; line-height: 35px; margin-right: 25%; margin-top: 50px;">جرب الآن ... مجانا</a>
            </div>
                        </section>


                    </div>

                </section>

            </div>

        </section>
    </div>
</asp:Content>

