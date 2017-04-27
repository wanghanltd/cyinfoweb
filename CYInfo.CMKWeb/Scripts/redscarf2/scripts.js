jQuery(document).ready(function($) {
	$("#menu-maina").flexNav({
        'hoverIntent': true,
        'hover': true
    });
	/*$('.box_skitter_large').skitter({
				theme: 'clean',
				//theme: 'default',
				numbers_align: 'right', 
				preview: true,
				navigation: false
			});
	$('#box_skitter_large').camera({
				thumbnails: true
			});*/
					
	$('ul.sf-menu').sooperfish({
        autoArrows:  false,
		   dualColumn:     7,
        delay    : 100,
           speedShow    : 100,
        speedHide    : 100
		   });
	$("#menu-item-href-225").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-229").prepend("<div class='sf-arrow'></div>");
	//$("#menu-item-href-230").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-1029").prepend("<div class='sf-arrow'></div>");
	//$("#menu-item-href-2290").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-164545").prepend("<div class='sf-arrow'></div>");
    $("#menu-item-href-156648").prepend("<div class='sf-arrow'></div>");
    $("#menu-item-href-157124").prepend("<div class='sf-arrow'></div>");

	//$("#menu-item-href-82434").prepend("<div class='sf-arrow'></div>");
	//$("#menu-item-href-120942").prepend("<div class='sf-arrow'></div>");
    //

	$("#menu-item-href-126819").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-1503").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-1502").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-124178").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-1536").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-1546").prepend("<div class='sf-arrow'></div>");
    //
	//$("#menu-item-href-85619").prepend("<div class='sf-arrow'></div>");
	//$("#menu-item-href-85620").prepend("<div class='sf-arrow'></div>");
	//$("#menu-item-href-85621").prepend("<div class='sf-arrow'></div>");
    //
	$("#menu-item-href-85957").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-85958").prepend("<div class='sf-arrow'></div>");
	$("#menu-item-href-85959").prepend("<div class='sf-arrow'></div>");
	//$("#menu-item-href-125688").prepend("<div class='sf-arrow'></div>");
	
	
	
	$(".mask .rsp").hide();
	//获得隐藏元素方法

    $(".dir-china").hover(function(){
        $(".dir-china-tag").addClass('active');
    },function(){
        $(".dir-china-tag").removeClass('active');
    });

	$(".mask").hover(function(){
	//定义一个伪类鼠标触及事件
		$(this).find(".rsp").stop().fadeTo(500,0.8)
		//当鼠标移动到图片上时通过遍历停止所有运行的动画，获得一个淡出事件
		$(this).find(".text").stop().animate({left:'0'}, {duration: 500})
		//当鼠标移动到图片上时通过遍历停止所有运行的动画，在移动一个动画让标题出从左边出现
	},function(){
	//在jquery 在定义一个方法
		$(this).find(".rsp").stop().fadeTo(500,0)
		//当鼠标离开是通过遍历停止动画在让淡出效果回去
		$(this).find(".text").stop().animate({left:'187'}, {duration: "fast"})
		//通过遍历停止动画后，在触发一个动画让原本出现的标题开始回收，让背景颜色变化正常
		$(this).find(".text").animate({left:'-187'}, {duration: 0})
		//通过遍历制动动画，发出动画让标题回到原位，让背景值变回0
	});

    $('.brand-name-item').hide();
    //$('#deal-content .deal-content-item:first').show();
    //$('ul#deal-cats li:first').addClass('active');

    /*$('ul#brand-name-first li').click(function(){
        $('ul#brand-name-first li').removeClass('active');
        $(this).parent().addClass('active');
        var currentTab = $(this).attr('href');
        $('#brand-name-content .brand-name-item').hide();
        $(currentTab).fadeIn(1000);
        return false;
    });*/


    /*$('ul#brand-name-first a').click(function(){
            $('ul#brand-name-first li').removeClass('active');
            $(this).parent().addClass('active');
            var currentTab = $(this).attr('href');
            $('#brand-name-content .brand-name-item').hide();
            $(currentTab).fadeIn(1000);

     });*/

     $("ul#brand-name-first a").toggle(function(){
         $('ul#brand-name-first li').removeClass('active');
         $(this).parent().addClass('active');
         var currentTab = $(this).attr('href');
         $('#brand-name-content .brand-name-item').hide();
         $(currentTab).fadeIn(1000);},
         function(){
            $('ul#brand-name-first li').removeClass('active');
            $(this).parent().removeClass('active');
            var currentTab = $(this).attr('href');
            $('#brand-name-content .brand-name-item').hide();}
       );


	
    $('.deal-content-item').hide();
    $('#deal-content .deal-content-item:first').show();
    $('ul#deal-cats li:first').addClass('active');

    $('ul#deal-cats a').click(function(){
        $('ul#deal-cats li').removeClass('active');
        $(this).parent().addClass('active');
        var currentTab = $(this).attr('href');
        $('#deal-content .deal-content-item').hide();
        $(currentTab).fadeIn(1000);
        return false;
    });

    $('.section-content-item').hide();
    $('#section-content .section-content-item:first').show();
    $('ul#section-cats li:first').addClass('active');

    $('ul#section-cats a').click(function(){
        var val = $("body").scrollTop();
        $('ul#section-cats li').removeClass('active');
        $(this).parent().addClass('active');
        var currentTab = $(this).attr('href');
        $('#section-content .section-content-item').hide();
        $(currentTab).fadeIn(1000);
        $("body").scrollTop(val);
        return false;
    });

    function moreDeals(e){
        $(e).click(function(){
            for(var i = 0; i < 12; i++) {
                $(".deal:not(.active):eq(0)").show(200).addClass("active");
            }
            if($(".deal:not(.active)").size() == 0) {
                $(this).hide();
            }
        });
    };

    moreDeals("#more_product_1");
    moreDeals("#more_product_2");
    moreDeals("#more_product_3");
    moreDeals("#more_product_4");
    moreDeals("#more_product_5");
    moreDeals("#more_product_6");
    moreDeals("#more_product_7");
    moreDeals("#more_product_8");

    //$(".deal-hot-brand").flexisel({
    //    visibleItems: 7
    //});

    $(".dealpage-hot-brand").flexisel({
        visibleItems: 5
    });
    /*$(".dealpage_item_content_popdeals").flexisel({
        autoPlay: true,
        autoPlaySpeed: 3000,
        visibleItems: 3
    });*/
    $(".dealpage_item_content_latestdeal").flexisel({
        /*autoPlay: true,
        autoPlaySpeed: 4000,*/
        visibleItems: 3
    });
    $(".dealpage_item_content_endseason").flexisel({
        /*autoPlay: true,
        autoPlaySpeed: 5000,*/
        visibleItems: 3
    });
    $(".dealpage_item_content_beautydeal").flexisel({
        /*autoPlay: true,
        autoPlaySpeed: 4000,*/
        visibleItems: 3
    });
    $(".dealpage_item_content_recommendeddeal").flexisel({
        autoPlay: true,
        autoPlaySpeed: 3000,
        visibleItems: 3
    });

    $(".flexisel-articles").flexisel({
        visibleItems: 3,
        enableResponsiveBreakpoints: true, //是否开启响应式
        responsiveBreakpoints: {
            portrait: {
                changePoint:480,
                visibleItems: 1
            },
            landscape: {
                changePoint:640,
                visibleItems: 1
            },
            tablet: {
                changePoint:768,
                visibleItems: 2
            }
        }
    });

    $(".flexisel-recarticles").flexisel({
        visibleItems: 3,
        enableResponsiveBreakpoints: true, //是否开启响应式
        responsiveBreakpoints: {
            portrait: {
                changePoint:480,
                visibleItems: 1
            },
            landscape: {
                changePoint:640,
                visibleItems: 1
            },
            tablet: {
                changePoint:768,
                visibleItems: 2
            }
        }
    });

    $(".flexisel-recdeals").flexisel({
        visibleItems: 3,
        enableResponsiveBreakpoints: true, //是否开启响应式
        responsiveBreakpoints: {
            portrait: {
                changePoint:480,
                visibleItems: 1
            },
            landscape: {
                changePoint:640,
                visibleItems: 1
            },
            tablet: {
                changePoint:768,
                visibleItems: 2
            }
        }
    });

    $(".flexisel-latestdeals").flexisel({
        visibleItems: 3,
        enableResponsiveBreakpoints: true, //是否开启响应式
        responsiveBreakpoints: {
            portrait: {
                changePoint:480,
                visibleItems: 1
            },
            landscape: {
                changePoint:640,
                visibleItems: 1
            },
            tablet: {
                changePoint:768,
                visibleItems: 2
            }
        }
    });
    /*$(window).resize(function(){
        $(".deal-modal").css({
            position: "absolute",
            left: ($(window).width() - $(".deal-modal").outerWidth())/2,
            top: ($(window).height() - $(".deal-modal").outerHeight())/2
        });
    });*/

    var offset = 300,
    //browser window scroll (in pixels) after which the "back to top" link opacity is reduced
        offset_opacity = 1200,
    //duration of the top scrolling animation (in ms)
        scroll_top_duration = 700,
    //grab the "back to top" link
        $back_to_top = $('.cd-top');

    //hide or show the "back to top" link
    $(window).scroll(function(){
        ( $(this).scrollTop() > offset ) ? $back_to_top.addClass('cd-is-visible') : $back_to_top.removeClass('cd-is-visible cd-fade-out');
        if( $(this).scrollTop() > offset_opacity ) {
            $back_to_top.addClass('cd-fade-out');
        }
    });

    //smooth scroll to top
    $back_to_top.on('click', function(event){
        event.preventDefault();
        $('body,html').animate({
                scrollTop: 0 ,
            }, scroll_top_duration
        );
    });

});
function addCodeModal(the_ID,the_link) {
    $('.modal').on('hidden', function () {
        $(this).removeData('modal');
    });
    $('#modal-common-'+ the_ID +'').modal('show');
    if(the_link){
        window.open(the_link);
    }
    //window.focus();
    $('body').on('hidden', '.modal', function () {
        $(this).removeData('modal');
    });
};