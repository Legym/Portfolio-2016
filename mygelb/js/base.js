/* global $ */
/**
 *    ▄████████ ▀████    ▐████▀  ▄██████▄  ███▄▄▄▄           ▄████████  ▄██████▄  ███    █▄      ███        ▄████████    ▄████████ 
 *   ███    ███   ███▌   ████▀  ███    ███ ███▀▀▀██▄        ███    ███ ███    ███ ███    ███ ▀█████████▄   ███    ███   ███    ███ 
 *   ███    ███    ███  ▐███    ███    ███ ███   ███        ███    ███ ███    ███ ███    ███    ▀███▀▀██   ███    █▀    ███    ███ 
 *   ███    ███    ▀███▄███▀    ███    ███ ███   ███       ▄███▄▄▄▄██▀ ███    ███ ███    ███     ███   ▀  ▄███▄▄▄      ▄███▄▄▄▄██▀ 
 * ▀███████████    ████▀██▄     ███    ███ ███   ███      ▀▀███▀▀▀▀▀   ███    ███ ███    ███     ███     ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   
 *   ███    ███   ▐███  ▀███    ███    ███ ███   ███      ▀███████████ ███    ███ ███    ███     ███       ███    █▄  ▀███████████ 
 *   ███    ███  ▄███     ███▄  ███    ███ ███   ███        ███    ███ ███    ███ ███    ███     ███       ███    ███   ███    ███ 
 *   ███    █▀  ████       ███▄  ▀██████▀   ▀█   █▀         ███    ███  ▀██████▀  ████████▀     ▄████▀     ██████████   ███    ███ 
 *                                                          ███    ███                                                  ███    ███                                                                             
 * -------------------------------------------------------------------------------------------------------------------------------
 *   "An Axon is the long threadlike part of a nerve cell along which impulses are conducted from the cell body to other cells.""
 *
 * @author 
 * 		Cameron Van Orman
 * 		<cameron@efelle.com>
 * 		Slack @cameronv
 *
 * @reference
 * 		Code Standards: http://daux.efellemedia.com/SOP/master/code-standards/javascript
 *
 * @usage
 * 		Store javascript functions under the FEATURES namespace to give your functions global scope.
 * 		Pass your functions to the Site Router under the relevant page name. Page names are defined by body classes.
 *
 * 		NOTE: You must have a body class on the template you're targeting in order for your page specific scripts to run.
 * 		i.e <body class='home'> if you're on the frontpage template.
 * 
 * 		NOTE: In order for your javascript to run on a specific page you need to declare the function in the FEATURES global namespace,
 * 		then call the function in the page setup where you've setup your page specific body class.
 *
 *
 * FEATURES SETUP
 * -------------
 *
 *	NOTE: Your FEATURES variable is global scope.
 * 	Javascript Global Scope: http://stackoverflow.com/a/500459 
 * 	ie. FEATURES.yourFunctionName();
 * 
 * 	NOTE: Our global variable "FEATURES" is all caps. 
 * 	ALL global scoped variables should be written in all caps
 *	to signify hierarchy in the application,
 *
 * 	Write your page specific functions here, then call the function for 
 * 	the pages you need it on below.
 *
 * @usage
 * 		var FEATURES = {
 *   		yourFunctionName: function() {
 *    		 -- Write/paste your script here --
 *  		},
 * 		};
 */

var FEATURES = {

    hireMe: function() {
        console.log("Thanks for taking a peek! If you work with amazing people I want to be part of it.");
    },

    fancybox: function() {
        $(".fancybox").fancybox();
    },

    currentPage: function () {
        var $linkURL = $("#desktop-menu ul li > a");

        $linkURL.filter(function () {
            return this.href == location.href.replace(/#.*/, "");
        }).addClass("menu-active");

        $('#desktop-menu ul li > a[href^="/' + location.pathname.split("/")[4] + '"]').addClass('menu-active');
    },

    blogSocialMedia: function () {
        $("#share").jsSocials({
            showLabel: false,
            showCount: false,
            shares: ["twitter", "facebook", "googleplus",]
        });

        $("#share-mobile").jsSocials({
            showLabel: false,
            showCount: false,
            shares: ["twitter", "facebook", "googleplus", ]
        });
    },

    blogOvSticky: function () {

        $(document).scroll(function () {
            var y = $(document).scrollTop(),
                header = $("#blog-sticky");
            if (y >= 500) {
                header.css({ position: "fixed", "top": "11%", "width": "100%" });
            } else {
                header.css("position", "relative");
            }
        });

    },

    blogOvSidebar: function () {
        $('.responsive-accordion').each(function () {
            // Set Expand/Collapse Icons
            $('.responsive-accordion-minus', this).hide();

            // Hide panels
            $('.responsive-accordion-panel', this).hide();

            // Bind the click event handler
            $('.responsive-accordion-head', this).click(function (e) {
                // Get elements
                var thisAccordion = $(this).parent().parent(),
                    thisHead = $(this),
                    thisPlus = thisHead.find('.responsive-accordion-plus'),
                    thisMinus = thisHead.find('.responsive-accordion-minus'),
                    thisPanel = thisHead.siblings('.responsive-accordion-panel');

                // Reset all plus/mins symbols on all headers
                thisAccordion.find('.responsive-accordion-plus').show();
                thisAccordion.find('.responsive-accordion-minus').hide();

                // Reset all head/panels active statuses except for current
                // thisAccordion.find('.responsive-accordion-head').not(this).removeClass('active');
                // thisAccordion.find('.responsive-accordion-panel').not(this).removeClass('active').slideUp();

                // Toggle current head/panel active statuses
                if (thisHead.hasClass('active')) {
                    thisHead.removeClass('active');
                    thisPlus.show();
                    thisMinus.hide();
                    thisPanel.removeClass('active').slideUp();
                } else {
                    thisHead.addClass('active');
                    thisPlus.hide();
                    thisMinus.show();
                    thisPanel.addClass('active').slideDown();
                }
            });

            $('.accordion-default', this).click();
        });
    },

    projectSlideshow: function () {
        $('.project-slideshow').slick({
            arrows: true,
            dots: true,
            infinite: true,
            speed: 300,
            slidesToShow: 1,
            fade: true,
        });

    },

    staticSlider: function (param, number) {
        $(window).load(function () {
            // On initialization of slick slider...
            $(param).on('init', function (event, slick) {
                // Remove Preloader
                $("#static-loader-wrapper").fadeOut(300, function () {
                    $(this).remove();
                });

                $('#slider-wrapper, #slider-info').addClass('slick-initialized');

                // remove display none from first slide-info container and give animate class
                $('#slider-info .item-0').show(function () {
                    $(this).removeClass('animate-out');
                    $(this).addClass('animate');
                });

                // Remove inactive class from first slide and add active class
                $('.slide-0').removeClass('inactive');
                $('.slide-0').addClass('active');
            })
			// Slick settings
			.slick({
			    arrows: false,
			    slidesToShow: number,
			    dots: false,
			    centerMode: true,
			    variableWidth: true,
			    responsive: [
                  {
                      breakpoint: 1100,
                      settings: {
                          centerMode: true,
                          slidesToShow: 2,
                          variableWidth: false,
                      }
                  },
                  {
                      breakpoint: 1025,
                      settings: {
                          fade: true,
                          speed: 500,
                          centerMode: false,
                          slidesToShow: 1,
                          variableWidth: false,
                      }
                  }
			    ]
			})
			// Callback functions: Slider works by adding classes to info-container outside of the actual slider
			// After slide change show info-slide and add animate class, remove inactive from slide and add active
			.on('afterChange', function (event, slick, currentSlide) {
			    $('#slider-info .item-' + currentSlide + '').show(function () {
			        $(this).removeClass('animate-out');
			        $(this).addClass('animate');
			    });

			    $('.slide-' + currentSlide + '').removeClass('inactive');
			    $('.slide-' + currentSlide + '').addClass('active');
			})
			// Before slide change display none info-slide and remove the animate class, remove active from slide and add inactive.
			.on('beforeChange', function (event, slick, currentSlide) {
			    $('#slider-info .item-' + currentSlide + '').removeClass('animate');
			    $('#slider-info .item-' + currentSlide + '').addClass('animate-out');
			    $('#slider-info .item-' + currentSlide + '').fadeOut();

			    $('.slide-' + currentSlide + '').removeClass('active');
			    $('.slide-' + currentSlide + '').addClass('inactive');
			});
            // Custom slider next button
            $("#slider-next").click(function (e) {
                e.preventDefault();
                $(param).slick('slickPrev');
            });
            // Custom slider Previous button
            $("#slider-prev").click(function (e) {
                e.preventDefault();
                $(param).slick('slickNext');
            });

            // Enable swipe slide change events for slider-info container
            //$("#slider-info").swipe({
            //    swipeLeft: function (event, direction, distance, duration, fingerCount) {
            //        $(param).slick('slickNext');
            //    },
            //    swipeRight: function (event, direction, distance, duration, fingerCount) {
            //        $(param).slick('slickPrev');
            //    }
            //});
        });
    },

    parallax: function (pWindow, background) {
        var $pWindow = $(pWindow);
  	
        var $background = $(background);
        var bgPath = $background.data('bg');
  	
        $pWindow.parallax({ imageSrc: bgPath });
    },

    toTop: function() {
      // browser window scroll (in pixels) after which the "back to top" link is shown
      var offset = 300,
      //browser window scroll (in pixels) after which the "back to top" link opacity is reduced
      // offset_opacity = 1200,
      //duration of the top scrolling animation (in ms)
      scroll_top_duration = 700,
      //grab the "back to top" link
      $back_to_top = $('#to-top');
    
      //hide or show the "back to top" link
      $(window).scroll(function(){
        ( $(this).scrollTop() > offset ) ? $back_to_top.fadeIn().addClass('in') : $back_to_top.fadeOut().removeClass('in');
      });
    
      //smooth scroll to top
      $back_to_top.on('click', function(event){
        event.preventDefault();
        $('body,html').animate({
          scrollTop: 0 ,
          }, scroll_top_duration
        );
      });
    },

    instagramSlider: function (target) {
        var $target = $(target);

        $target.slick({
            lazyLoad: 'ondemand',
            slidesToShow: 5,
            slidesToScroll: 1,
            autoplay: false,
            autoplaySpeed: 3500,
            arrows: true,
            dots: false,
            infinite: true,
            prevArrow: '<button class="fa fa-angle-left"></button>',
            nextArrow: '<button class="fa fa-angle-right"></button>',
            responsive: [
				{
				    breakpoint: 1199,
				    settings: {
				        slidesToShow: 3,
				        slidesToScroll: 1,
				        autoplay: true,
				        autoplaySpeed: 3500,
				        centerMode: true,
				        autoplay: false,
				        arrows: true,
				        dots: false,
				        infinite: true
				    }
				},
					{
					    breakpoint: 992,
					    settings: {
					        slidesToShow: 3,
					        slidesToScroll: 1,
					        autoplay: true,
					        autoplaySpeed: 3500,
					        centerMode: true,
					        autoplay: false,
					        arrows: true,
					        dots: false,
					        infinite: true
					    }
					},
				{
				    breakpoint: 700,
				    settings: {
				        slidesToShow: 1,
				        slidesToScroll: 1,
				        autoplay: true,
				        autoplaySpeed: 3500,
				        autoplay: false,
				        arrows: true,
				        dots: false,
				        infinite: true
				    }
				}
            ]
        });

        $.ajax({
            type: "GET",
            dataType: "jsonp",
            cache: false,
            url: "https://api.instagram.com/v1/users/self/media/recent/?access_token=1723043700.1677ed0.2563c0e77aee46b1b05144fde13bd641",
            success: function (data) {
                for (var i = 0; i < 15; i++) {
                    x = i + 1;
                    $(".instagram-slide .slick-list .slick-track").append("<a href=" + data.data[i].link + " target='_blank' ><div class='instagram-img'> <img data-lazy=" + data.data[i].images.standard_resolution.url + " " + "'></div></a>");
                }
                $('.instagram-slide').slick('reinit');
            }
        });
    },

    runFoundation: function () {
        $(document).foundation();
    },

    mmenu: function () {

        $("#menu-mobile").mmenu({
            searchfield: {
                add: true,
                search: false
            },

            "offCanvas": {
                "position": "right"
            },
            "extensions": [
                "pageshadow"
            ],
        });

        $(".mm-search input").keyup(function (e) {
            if (e.keyCode == 13) {
                window.location.href = '/search-results?Keywords=' + $(this).val();
            }
        });

    },

    homepageSlideshow: function () {

        $('.homepage-slideshow').slick({
            arrows: true,
            dots: true,
            infinite: true,
            speed: 300,
            slidesToShow: 1,
            fade: true,
        });

        $(window).on("resize", function () {
            $('.homepage-slideshow').height($(window).height() - 50)
        }).resize();
          
    },

    search: function () {

        /* 
			Please set anchor tag of search button to <a href="#/"></a>
			to prevent page from jumping.
		*/

        /* Hides searchbar if clicking anywhere else on page other than input */
        $(document).click(function () {
            $('.search-input').removeClass("search-show");

            /* Removes click event listner and adds new event handler: showSearch()*/
            $('.search-icon').unbind('click').bind('click', showSearch);
        });


        /* Always shows searchbar when clicking on search icon */
        $('.search-icon').bind('click', showSearch);


        /* 
			When searchbar is displayed and user clicks inside, prevent searchbar from entering Bubbling phase and hiding searchbar
		*/
        $('.search-input').click(function (ev) {
            ev.stopPropagation();
        });

        /* Shows searchbar */
        function showSearch(ev) {

            /* 
				Shows searchbar with CSS3 and binds executeSearch to searchbar 
			*/
            $('.search-input').addClass("search-show");
            $('.search-icon').bind('click', executeSearch);
            ev.stopPropagation();
        }

        /* Executes Search. */
        function executeSearch() {
            var searchvalue = $('.search-input').val();

            /* 
				If user presses the search button with text in input, perform search.
				If user presses the search button with no text, hide searchbar

			*/
            if ($.trim(searchvalue) !== '') {
                location.href = '/search/' + searchvalue;
            } else {
                $('.search-input').toggleClass("search-show");
            }
        }
    },

    mapCover: function () {
        $('.map-cover').on('click', function () {
            $('.map-cover').hide();
        });
    },

    matchHeight: function () {
        $('.height').matchHeight();
    }
};