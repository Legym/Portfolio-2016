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

    runFoundation: function () {
        $(document).foundation();

        document.querySelector("#nav-toggle").addEventListener("click", function () {
                this.classList.toggle("active");
        });
    },

    mmenu: function () {
        $("#menu-mobile").mmenu({
            "offCanvas": {
                "position": "right"
            },
            "extensions": [
                "theme-dark"
            ],
            "navbars": [
                {
                    "position": "bottom",
                    "content": [
                    "<a class='fa fa-envelope' href='#/'></a>",
                    "<a class='fa fa-twitter' href='#/'></a>",
                    "<a class='fa fa-facebook' href='#/'></a>"
                    ]
                }
            ]
        });
    }
};