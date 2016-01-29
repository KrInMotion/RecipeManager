var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify');

var paths = {
    webroot: "./wwwroot/"
};


paths.bootstrapCss = "./bower_components/bootstrap/dist/css/bootstrap.css";
paths.sbAdminCss = "./bower_components/startbootstrap-sb-admin-2/dist/css/sb-admin-2.css";
paths.fontAwesomeCss = "./bower_components/font-awesome/css/font-awesome.css";
paths.morrisCss = "./bower_components/morrisjs/morris.css";

paths.fontAwesomeFont = "./bower_components/font-awesome/fonts/*";

paths.jqueryJs = "./bower_components/jquery/dist/jquery.js";
paths.bootstrapJs = "./bower_components/bootstrap/dist/js/bootstrap.js";
paths.sbAdminJs = "./bower_components/startbootstrap-sb-admin-2/dist/js/sb-admin-2.js";
paths.morrisJs = "./bower_components/morrisjs/morris.js";
paths.raphaelJs = "./bower_components/raphael/raphael.js";

paths.destCss = paths.webroot + "css";
paths.destJs = paths.webroot + "js";
paths.destFonts = paths.webroot + "fonts";

gulp.task("min:js", function () {
    return gulp.src([paths.jqueryJs, paths.bootstrapJs, paths.sbAdminJs, paths.morrisJs, paths.raphaelJs])
        .pipe(concat(paths.destJs + "/site.min.js"))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.bootstrapCss, paths.fontAwesomeCss, paths.sbAdminCss, paths.morrisCss])
        .pipe(concat(paths.destCss + "/site.min.css"))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("copy:css", function () {
    return gulp.src([paths.bootstrapCss, paths.fontAwesomeCss, paths.sbAdminCss, paths.morrisCss])
    .pipe(gulp.dest(paths.destCss));
});
gulp.task("copy:js", function () {
    return gulp.src([paths.jqueryJs, paths.bootstrapJs, paths.sbAdminJs, paths.morrisJs, paths.raphaelJs])
    .pipe(gulp.dest(paths.destJs));
});
gulp.task("copy:fonts", function () {
    return gulp.src([paths.fontAwesomeFont])
    .pipe(gulp.dest(paths.destFonts));
});

gulp.task("copy", ["copy:css", "copy:js", "copy:fonts"]);

gulp.task("min", ["min:css", "min:js"]);

gulp.task('default', function () {
    // place code for your default task here
});
