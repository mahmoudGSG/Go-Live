// JavaScript Document
$(document).ready(function () {
	
	
	
	$(".top").click(function() {
        ('html, body').animate({ scrollTop: 0 }, 'slow');
    });
	
	
	$(".vote_box").hide();
	$(".voteIcon").click(function () {
		$(".vote_box").show(300);
	});
	
	
	$(".vote_box .close").click(function () {
			$(".vote_box").hide(300);
	});

	 $("label").inFieldLabels();
    $("label").click(function (e) {
        $(this).next().focus();
    });
	

		
	
	
	
	$("[watermarktext]").each(function(){
			$(this).addClass("Focus");
			$(this).val($(this).attr("watermarktext"));			
			$(this).focusin(function(){
				if($(this).val()==$(this).attr("watermarktext")){
					$(this).val('');
					$(this).removeClass("Focus");
				}
				}).focusout(function(){
				if($(this).val()==''){
					$(this).val($(this).attr("watermarktext"));
					$(this).addClass("Focus");
				}	
			});
		}); 
	
	
    var thumbs = $(".news_div .news_in .img_box img");
    var thumbs4 = $(".events_box .manBox img");
    var thumbs2 = $(".events_box img");
    var thumbs3 = $(".allDiv .last .album img,.events_new .img_box img,.video_box_inn .box_img img,.video_box_page .box_video img");

    for (var i = 0, ii = thumbs.length; i < ii; i++) {
        if (thumbs[i].title || thumbs[i].title.length > 0 || thumbs[i].title.length == 0) {
            var imgtitle = thumbs[i].title;
            $(thumbs[i]).wrap('<div class="wrapper" />').

				removeAttr('title');

        }
    }


    for (var i = 0, ii = thumbs2.length; i < ii; i++) {
        if (thumbs2[i].title || thumbs2[i].title.length > 0 || thumbs2[i].title.length == 0) {
            var imgtitle = thumbs2[i].title;
            $(thumbs2[i]).wrap('<div class="wrapper" />').

				removeAttr('title');

        }
    }

    for (var i = 0, ii = thumbs3.length; i < ii; i++) {
        if (thumbs3[i].title || thumbs3[i].title.length > 0 || thumbs3[i].title.length == 0) {
            var imgtitle = thumbs3[i].title;
            $(thumbs3[i]).wrap('<div class="wrapper" />').

				removeAttr('title');

        }
    }

    for (var i = 0, ii = thumbs4.length; i < ii; i++) {
        if (thumbs4[i].title || thumbs4[i].title.length > 0 || thumbs4[i].title.length == 0) {
            var imgtitle = thumbs4[i].title;
            $(thumbs4[i]).wrap('<div class="wrapper" />').

				removeAttr('title');

        }
    }






    $('.wrapper').hover(
		function () {
		    $(this).find('img').animate({ opacity: ".6" }, 300);
		    $(this).find('.caption').animate({ top: "-85px" }, 300);
		},
		function () {
		    $(this).find('img').animate({ opacity: "1.0" }, 300);
		    $(this).find('.caption').animate({ top: "85px" }, 100);
		}
		);
		
		
		
//$(".box_header").hover(function () {
//if ($(this).children().is(":hidden")) {
//$(".box_header_first").slideDown("slow");
//} else {
//$(".box_header_first").slideUp("slow");
//}
//});
		
		
		
		$(".VPalayList > a").hover(function () {
            if ($(this).hasClass("tab_select2")) {
            }
            else {
                $(this).stop().animate({ left: "-10px" }, "slow");
                $(this).children().stop().animate({ opacity: "1" }, "slow");
                $(this).addClass("BVColor");
            }

        }, function () {
            if ($(this).hasClass("tab_select2")) {
            }
            else {
                $(this).stop().animate({ left: "-40px" }, "slow");
                $(this).removeClass("BVColor");
                $(this).children().stop().animate({ opacity: ".5" }, "slow");

            }
        });


      //  $(".VPalayList > div").click(function () {
//            if ($(this).hasClass("currentVideo")) {
//            }
//            else {
//                $(this).addClass("clikcVideo");
//                $(".VPalayList > div").each(function (index, element) {
//                    if ($(this).hasClass("clikcVideo"))
//                    { }
//                    else {
//
//                        $(this).stop().animate({ right: "-40px" }, "slow");
//                        $(this).removeClass("BVColor");
//                        $(this).children().stop().animate({ opacity: ".5" }, "slow");
//                        $(this).removeClass("currentVideo");
//                    }
//                });
//                $(this).stop().animate({ right: "-10px" }, "slow");
//                $(this).children().stop().animate({ opacity: "1" }, "slow");
//                $(this).addClass("currentVideo");
//                $(this).removeClass("clikcVideo");
//
//            }
//
//        });
		
		
		
		$(".v_box a img").hover(function(){
			
			 $(this).stop().animate({ right : "0px" }, "slow");
			 
			}, function () {
				
				 $(this).stop().animate({ right : "-19px" }, "slow");
				 
				});
	$(".bx-prev").click(function () {
            
			
			$(this).addClass("currentVideo");
			//$(".pager .inner_container").css('margin-right',0);
			
            });
$(".container .video_box:odd").addClass("vbox_bg");
$(".related_rows_title:odd").addClass("related_rows_title2");			
$(".srch_inner_div:even").addClass("related_rows_title2");	

$(".big_hyper .news_box_left .allNews_box .news_sub:odd").addClass("new_news_bg");	




$(function () {

            $('.audio').each(function () {

                $(this).html("<object classid='clsid:D27CDB6E-AE6D-11cf-96B8-444553540000' width='290' height='24' id='FlashID'>"

          + "<param name='movie' value='flash/player.swf' />"
          + "<param name='quality' value='high' />"
         + " <param name='wmode' value='transparent' />"
         + " <param name='swfversion' value='9.0.45.0' />"
         + " <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don�t want users to see the prompt. -->"
          + "<param name='expressinstall' value='scripts/expressInstall.swf' />"

		  + "<param value='&bg=0xffffff&leftbg=0xf3f3f3&lefticon=0xffc000&rightbg=0xf3f3f3&rightbghover=0xf4b800&righticon=0xffc000&righticonhover=0xf3f3f3&text=0xffc000&slider=0xf1553a&track=0xebebeb&border=0xffc000&loader=0xf4b800&soundFile=" + $(this).attr('href') + "&rtl=no' name='FlashVars'>"

         + " <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->"
          + "<!--[if !IE]>-->"
          + "<object type='application/x-shockwave-flash' data='flash/player.swf' width='290' height='24'>"
          + "  <!--<![endif]-->"

           + " <param name='quality' value='high' />"
          + "  <param name='wmode' value='transparent' />"
          + "  <param name='swfversion' value='9.0.45.0' />"
          + "  <param name='expressinstall' value='scripts/expressInstall.swf' />"

		  + "<param value='&bg=0xffffff&leftbg=0xf3f3f3&lefticon=0xffc000&rightbg=0xf3f3f3&rightbghover=0xf4b800&righticon=0xffc000&righticonhover=0xf3f3f3&text=0xffc000&slider=0xf1553a&track=0xebebeb&border=0xffc000&loader=0xf4b800&soundFile=" + $(this).attr('href') + "&rtl=no' name='FlashVars'>"



          + " <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->"
          + "  <div>"

           + "   <p><a href='http://www.adobe.com/go/getflashplayer'><img src='http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif' alt='Get Adobe Flash player' width='112' height='33' /></a></p>"
           + " </div>"
           + " <!--[if !IE]>-->"
         + " </object>"
         + " <!--<![endif]-->"
        + "</object>");


            });

        });





var FullUrl = window.location.toString().split('/');
         var page = FullUrl[FullUrl.length - 1].toLowerCase();

         $(".top_menu a").each(function () {
             if ($(this).attr("href") != null) {
                 if ($(this).attr("href").toLowerCase() == page) {

                     $(this).addClass("main_link_hover");
                     $(this).removeAttr("href");
                     $(this).attr("disabled", "disabled");
                 }
                 else
                     $(this).hover(function () {
                         $(this).addClass("main_link_hover");
                     }, function () {
                         $(this).removeClass("main_link_hover");
                     });
             }
         });
	
	


        $("#showcase").awShowcase(
	{
	    content_width: 960,
	    content_height: 420,
	    fit_to_parent: false,
	    auto: true,
	    interval: 6000,
	    continuous: true,
	    loading: true,
	    tooltip_width: 200,
	    tooltip_icon_width: 32,
	    tooltip_icon_height: 32,
	    tooltip_offsetx: 18,
	    tooltip_offsety: 0,
	    arrows: false,
	    buttons: true,
	    btn_numbers: true,
	    keybord_keys: true,
	    mousetrace: false, /* Trace x and y coordinates for the mouse */
	    pauseonover: true,
	    stoponclick: false,
	    transition: 'hslide', /* hslide/vslide/fade */
	    transition_delay: 0,
	    transition_speed: 300,
	    show_caption: 'onload', /* onload/onhover/show */
	    thumbnails: false,
	    thumbnails_position: 'outside-last', /* outside-last/outside-first/inside-last/inside-first */
	    thumbnails_direction: 'vertical', /* vertical/horizontal */
	    thumbnails_slidex: 1, /* 0 = auto / 1 = slide one thumbnail / 2 = slide two thumbnails / etc. */
	    dynamic_height: false, /* For dynamic height to work in webkit you need to set the width and height of images in the source. Usually works to only set the dimension of the first slide in the showcase. */
	    speed_change: true, /* Set to true to prevent users from swithing more then one slide at once. */
	    viewline: false, /* If set to true content_width, thumbnails, transition and dynamic_height will be disabled. As for dynamic height you need to set the width and height of images in the source. */
	    custom_function: null /* Define a custom function that runs on content change */
	});
	
	

	
	/////////////////////////////////////
	
	
	

	if($(window).width() > 600){
		$("#cssmenu").show();
		}
		
		$(".hide_menu").click(function () {
			$("#cssmenu ").slideToggle("fast");
		});
	 
		$(".main_link5").click(function () {
			$("#cssmenu ").slideUp("fast");
		});
		
		
		
	
	
	
	$(".tab li").click(function() {
		$(".tab li").removeClass('active4');
		$(this).addClass("active4");
		$(".work2").hide();
		var selected_tab = $(this).find("a").attr("href");
		$(selected_tab).show();
		return false;
	});
	
	
	


});
	
	

