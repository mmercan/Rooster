/// <binding Clean='clean' />

var gulp = require("gulp"),
  rimraf = require("rimraf"),
  fs = require("fs");

eval("var project = " + fs.readFileSync("./project.json"));

var paths = {
  bower: "./bower_components/",
  lib: "./" + project.webroot + "/lib/"
};

gulp.task("clean", function (cb) {
  rimraf(paths.lib, cb);
});

gulp.task("copy", ["clean"], function () {
    var bower = {
        "modernizr": "modernizr/modernizr.js",
        "jquery": "jquery/dist/jquery.{js,map}",
        "jquery-validation": "jquery-validation/jquery.validate.js",
        "jquery-validation-unobtrusive": "jquery-validation-unobtrusive/jquery.validate.unobtrusive.js",
        "hammer.js": "hammer.js/hammer*.{js,map}",
        "bootstrap": "bootstrap/dist/**/*.{js,map,css,ttf,svg,woff,eot}",
        "bootstrap-touch-carousel": "bootstrap-touch-carousel/dist/**/*.{js,css}",
        "font-awesome": "font-awesome/{css,fonts,less}/*.{js,css,less,ttf,svg,woff,eot,otf,woff2}",

        "angular": "angular/angular.js",
        "angular-animate": "angular-animate/angular-animate.js",
        "angular-animate-css": "angular-animate-css/build/nga.css",
        "angular-cookies": "angular-cookies/angular-cookies.js",
        "angular-touch": "angular-touch/angular-touch.js",
        "angular-sanitize": "angular-sanitize/angular-sanitize.js",
        "angular-resource": "angular-resource/angular-resource.js",
        "angular-route": "angular-route/angular-route.js",
        "angular-ui-router": "angular-ui-router/release/angular-ui-router.js",
        "angular-bootstrap": "angular-bootstrap/ui-bootstrap-tpls.js",
        "PACE": "PACE/pace.js",
        "metisMenu": "metisMenu/dist/*.{js,css}",
        "slimScroll": "slimScroll/jquery.slimscroll.min.js",
        "simple-line-icons": "simple-line-icons/{css,font}/*.*",

        "jquery-ui": "jquery-ui/jquery-ui.js",
        "moment": "moment/moment.js",
        "fullcalendar": "fullcalendar/dist/fullcalendar.{js,css}",
        "select2": "/select2/select2.{js,css}",
        "toastr": "toastr/toastr.{js,css}",
        "masked-input": "masked-input/masked-input.js",
        "jquery.maskedinput": "jquery.maskedinput/dist/jquery.maskedinput.js",
        "tinymce": "tinymce/tinymce.js,tinymce/{plugins,skins,themes}/**/*.{js,css}",
        "jquery-knob": "jquery-knob/js/jquery.knob.js",
        "nprogress": "nprogress/nprogress.{js,css}",
        "jqueryui-touch-punch": "jqueryui-touch-punch/jquery.ui.touch-punch.min.js",
        "respond": "respond/dest/respond.src.js",
        "lodash": "lodash/lodash.js",

        "Angular-Directives": ["Angular-Directives/**/*.{js,css,html,less}"],
        "oclazyload": "oclazyload/dist/ocLazyLoad.min.js",
        "ng-idle": "ng-idle/angular-idle.js",
        "angular-bootstrap-checkbox": "angular-bootstrap-checkbox/angular-bootstrap-checkbox.js"
    }

    for (var destinationDir in bower) {
    gulp.src(paths.bower + bower[destinationDir])
      .pipe(gulp.dest(paths.lib + destinationDir));
  }
});



gulp.paths = {
    src: 'wwwroot',
    dist: 'wwwroot/dist',
    tmp: 'wwwroot/.tmp',
    e2e: 'wwwroot/e2e'
};

require('require-dir')('./gulp');

gulp.task('default', ['clean'], function () {
    gulp.start('build');
});
