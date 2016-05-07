<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderScripts.ascx.cs" Inherits="HeaderScripts" %>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

     <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	

		<link rel="stylesheet" type="text/css" href="css/style.css" />
        <link rel="stylesheet" type="text/css" href="font-awesome/css/font-awesome.css" />
		<link rel="stylesheet" type="text/css" href="skins/tango/skin.css" />
		<script type="text/javascript" src="js/jquery.js"></script>

		<script type="text/javascript" src="js/jquery.infieldlabel.min.js"></script>
		<script type="text/javascript" src="js/myjs.js"></script>
		<script type="text/javascript" src="js/jquery.jcarousel.min.js"></script>
		<script type="text/javascript">
		    $(document).ready(function () {

		        $('.first-and-second-carousel').jcarousel({
		            scroll: 1,
		            outo: 8,
		            wrap: 'circular'
		        });



		        $(function () {
		            $('#cssmenu a[href*=#]:not([href=#])').click(function () {
		                $('.blue').removeClass("blue");
		                $(this).addClass("blue");
		                if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {

		                    var target = $(this.hash);
		                    target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
		                    if (target.length) {
		                        $('html,body').animate({
		                            scrollTop: target.offset().top
		                        }, 700);
		                        return false;
		                    }
		                }
		            });
		        });


		    });
		</script>
  <script type="text/javascript" src="js/jquery.aw-showcase.js"></script>
    

<script src="js/swfobject.js" type="text/javascript"></script>
<link rel="shortcut icon" href="favicon.ico" />  
<meta property="og:image" content="http://DatawayConnpro.com/img/face.png" />


  




<%--<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/ar_AR/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>--%>
<%--<script src="http://widgets.twimg.com/j/2/widget.js"></script>--%>


<div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/ar_AR/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>