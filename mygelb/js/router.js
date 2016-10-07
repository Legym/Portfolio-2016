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
 *   "An Axon is the long threadlike part of a nerve cell along which impulses are conducted from the cell body to other cells."
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
 * PAGE SETUP 
 * ----------
 * 
 * 	DOM-based Routing
 * 	Based on http://goo.gl/EUTi53 by Paul Irish
 *	
 * 	NOTE: Only fires on body classes that match. If a body class contains a dash,
 * 	replace the dash with an underscore when adding it to the object below.
 *
 * 	.noConflict()
 * 	The routing is enclosed within an anonymous function so that you can 
 * 	always reference jQuery with $, even when in .noConflict() mode.
 */

(function($) {

	/**
	 * @var AXONROUTER
	 * 		Use this variable to set up the common and page specific functions. If you
	 * 		rename this variable, you will also need to rename the namespace variable site router.
	 *
	 * @usage
	 *      var AXONROUTER = {
	 *          // All pages
	 *          common: {
	 *              init: function() {
	 *                  // JavaScript to be fired on all pages
	 *                  FEATURES.yourFunctionName();
	 *              }
	 *          },
	 *      };
	 */
	var AXONROUTER = {

		/**
		 * All pages
		 */
		common: {
		    init: function () {
		        FEATURES.mmenu();
		        FEATURES.search();
		        FEATURES.runFoundation();
		        FEATURES.toTop();
		        FEATURES.matchHeight();
		        FEATURES.currentPage();
		        FEATURES.fancybox();
		        FEATURES.hireMe();
			}
		},

		subpage_homepage: {
		    init: function () {
		        FEATURES.homepageSlideshow();
		        FEATURES.staticSlider('.homepage-static-slider', 3);
		        FEATURES.parallax(
                    ".homepage-message .parallax-wrapper > .parallax-window",
                    ".homepage-message .parallax-wrapper > span[data-bg]"
	            )
		        FEATURES.parallax(
                    "#explore .parallax-wrapper > .parallax-window",
                    "#explore .parallax-wrapper > span[data-bg]"
	            )
		    }
		},

		subpage_blog: {
		    init: function () {
		        FEATURES.parallax(
                    "#blog-overview-image .parallax-wrapper > .parallax-window",
                    "#blog-overview-image .parallax-wrapper > span[data-bg]"
	            )
		        FEATURES.blogOvSidebar();
		        FEATURES.blogOvSticky();
		        FEATURES.blogSocialMedia();
		    }
		},

		subpage_about: {
		    init: function () {
		        FEATURES.mapCover();
		        FEATURES.instagramSlider(".instagram-slide");
		        FEATURES.parallax(
                    "#about-image .parallax-wrapper > .parallax-window",
                    "#about-image .parallax-wrapper > span[data-bg]"
	            )
		        FEATURES.parallax(
                    "#experience .parallax-wrapper > .parallax-window",
                    "#experience .parallax-wrapper > span[data-bg]"
	            )
		    }
		},

		subpage_portfolio: {
		    init: function () {
		        FEATURES.parallax(
                    ".parallax-wrapper > .parallax-window",
                    ".parallax-wrapper > span[data-bg]"
	            )
		    }
		},

		subpage_project: {
		    init: function () {
		        FEATURES.parallax(
                    ".parallax-wrapper > .parallax-window",
                    ".parallax-wrapper > span[data-bg]"
	            )
		        FEATURES.projectSlideshow();
		    }
		},

		subpage_sitemap: {
		    init: function () {
		        FEATURES.parallax(
                    ".parallax-wrapper > .parallax-window",
                    ".parallax-wrapper > span[data-bg]"
	            )
		    }
		},

		subpage_contact: {
		    init: function () {
		        FEATURES.parallax(
                    ".parallax-wrapper > .parallax-window",
                    ".parallax-wrapper > span[data-bg]"
	            )
		    }
		},

		subpage_search: {
		    init: function () {
		        FEATURES.parallax(
                    ".parallax-wrapper > .parallax-window",
                    ".parallax-wrapper > span[data-bg]"
	            )
		    }
		},

		subpage_newsletter: {
		    init: function () {
		        FEATURES.parallax(
                    ".parallax-wrapper > .parallax-window",
                    ".parallax-wrapper > span[data-bg]"
	            )
		    }
		},
	};

	/**
	 * SITE ROUTER 
	 * ----------
	 * 
	 * 	The routing fires all common scripts, followed by the page specific scripts.
	 * 	Add additional events for more control over timing e.g. a finalize event
	 */
	var UTIL = {
		fire: function(func, funcname, args) {
			var namespace = AXONROUTER;
			funcname = (funcname === undefined) ? 'init' : funcname;
			if (func !== '' && namespace[func] && typeof namespace[func][funcname] === 'function') {
				namespace[func][funcname](args);
			}
		},
		loadEvents: function() {
			UTIL.fire('common');

			$.each(document.body.className.replace(/-/g, '_').split(/\s+/),function(i,classnm) {
				UTIL.fire(classnm);
			});
		}
	};
	 
	$(document).ready(UTIL.loadEvents);
 
})(jQuery); // Fully reference jQuery after this point.