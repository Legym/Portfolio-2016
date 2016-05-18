// Include gulp
var gulp = require('gulp'); 

// Include Our Plugins
var plumber      = require('gulp-plumber'); // To handle error events
var jshint       = require('gulp-jshint'); // To show JS errors
var cssmin       = require('gulp-cssmin'); // Minify
var imagemin     = require('gulp-imagemin'); // Image Minification
var sass         = require('gulp-sass'); // Compile our Sass
var concat       = require('gulp-concat'); // Concatinate JS
var uglify       = require('gulp-uglify'); // Pass through Uglification
var rename       = require('gulp-rename'); // Rename files after compilation
var autoprefixer = require('gulp-autoprefixer'); // Automatically add CSS prefixes for greater CSS3 browser support
var notify       = require("gulp-notify"); // Ability to send error notifications

// Lint Task
gulp.task('lint', function() {
    return gulp.src('js/vendor/base.js')
		.pipe(jshint())
		.pipe(jshint.reporter('default'));
});

// Compile Our Sass
gulp.task('sass', function() {
    gulp.src([
        'scss/*.scss',
        'node_modules/foundation-sites/dist/foundation.min.css'
        ])
        .pipe(plumber())
    	.pipe(sass(
        {
            includePaths: [
    	        'node_modules/foundation-sites/scss/'
            ]
        }))
		//.pipe(notify())
		.pipe(cssmin())
		.pipe(autoprefixer({
		    browsers: ['last 5 versions'],
		}))
        .pipe(concat('app.min.css'))
		.pipe(gulp.dest('css/'));
});


// Compresses Images
gulp.task('images', function() {
	gulp.src([
		'media/*',
	])
		.pipe(imagemin({
			progressive: true,
			interlaced: true,
			svgoPlugins: [{removeUnknownsAndDefaults: false}, {cleanupIDs: false}]
		}))
		.pipe(gulp.dest('media'))
});

// Concatenate & Minify JS
gulp.task('scripts', function() {
    gulp.src([
        "js/vendor/jquery-2.2.3.min.js",
        "node_modules/foundation-sites/dist/foundation.min.js",
        "js/vendor/slick.min.js",
        "js/vendor/jquery.mmenu.oncanvas.js",
        "js/base.js",
        "js/router.js"
	])
		.pipe(plumber())
		.pipe(concat('all.js'))
		.pipe(rename('district.js'))
		.pipe(plumber())
		.pipe(uglify())
		.pipe(gulp.dest('scripts/'));
});


// Watch Files For Changes
gulp.task('watch', function() {
    gulp.watch('js/*.js', ['lint', 'scripts']);
	gulp.watch(['scss/*.scss', 'scss/**/*.scss'], ['sass']);
});

// Default Task
gulp.task('default', ['lint', 'sass', 'scripts', 'watch']);
