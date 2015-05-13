'use strict';

var gulp = require('gulp');

var paths = gulp.paths;

var $ = require('gulp-load-plugins')();

var wiredep = require('wiredep').stream;

//gulp.task('inject', ['styles','copy'], function () {

//  var injectStyles = gulp.src(['wwwroot/css/**/*.css','!wwwroot/css/vendor.css'], { read: false });

//  var injectScripts = gulp.src([
//    paths.src + '/{app,components}/**/*.js',
//    '!' + paths.src + '/{app,components}/**/*.spec.js',
//    '!' + paths.src + '/{app,components}/**/*.mock.js'
//  ]).pipe($.angularFilesort());

//  var injectOptions = {
//      ignorePath: [paths.src],
//      addRootSlash: true,
//      name: "inject"
//  };

//  var wiredepOptions = {
//    directory: 'bower_components',
//  };

//  return gulp.src(paths.src + '/*.html')
//    .pipe($.inject(injectStyles, { ignorePath: 'wwwroot', addRootSlash: true }))
//    .pipe($.inject(injectScripts, injectOptions))
//    //.pipe(wiredep(wiredepOptions))
//      .pipe($.rename('index.html'))
//  //  .pipe(gulp.dest(paths.tmp + '/serve'));
//      .pipe(gulp.dest('./wwwroot'));
//});


gulp.task('inject', ['styles', 'copy'], function() {

    var injectStyles = gulp.src(['wwwroot/css/**/*.css', '!wwwroot/css/vendor.css'], { read: false });

    var injectScripts = gulp.src([
         'wwwroot/{app,components}/**/*.js',
        '!wwwroot/{app,components}/**/*.spec.js',
        '!wwwroot/{app,components}/**/*.mock.js']).pipe($.angularFilesort());

    var injectOptions = {
        ignorePath: [paths.src],
        addRootSlash: true,
        name: "app"
    };

    var libroot = "wwwroot/lib/";
    var injectfiles = {
        js: [
            libroot + "modernizr/modernizr.js",
            libroot + "jquery/jquery.js",
            libroot + "jquery-validation/jquery.validate.js",
            libroot + "jquery-validation-unobtrusive/jquery.validate.unobtrusive.js",
            libroot + "hammer.js/hammer.js",
            libroot + "bootstrap/js/bootstrap.js",
            libroot + "bootstrap-touch-carousel/js/*.js",
            libroot + "angular/angular.js",
            libroot + "angular-animate/angular-animate.js",
            libroot + "angular-cookies/angular-cookies.js",
            libroot + "angular-touch/angular-touch.js",
            libroot + "angular-sanitize/angular-sanitize.js",
            libroot + "angular-resource/angular-resource.js",
            libroot + "angular-route/angular-route.js",
            libroot + "angular-ui-router/angular-ui-router.js",
            libroot + "angular-bootstrap/ui-bootstrap-tpls.js",
            libroot + "PACE/pace.js",
            libroot + "metisMenu/metisMenu.js",
            libroot + "slimScroll/jquery.slimscroll.min.js",
            libroot + "jquery-ui/jquery-ui.js",
            libroot + "moment/moment.js",
            libroot + "fullcalendar/fullcalendar.js",
            libroot + "select2/select2.js",
            libroot + "toastr/toastr.js",
            libroot + "masked-input/masked-input.js",
            libroot + "jquery.maskedinput/jquery.maskedinput.js",
            libroot + "tinymce/tinymce.js,tinymce/{plugins,skins,themes}/**/*.js",
            libroot + "jquery-knob/js/jquery.knob.js",
            libroot + "nprogress/nprogress.js",
            libroot + "jqueryui-touch-punch/jquery.ui.touch-punch.min.js",
            libroot + "respond/dest/respond.src.js",
            libroot + "lodash/lodash.js",
            libroot + "Angular-Directives/*.js",
            "!" + libroot + "Angular-Directives/*.min.js",
            libroot + "oclazyload/ocLazyLoad.min.js",
            libroot + "ng-idle/angular-idle.js",
            libroot + "angular-bootstrap-checkbox/angular-bootstrap-checkbox.js"
            
        ],
        css: [
            libroot + "bootstrap/css/bootstrap.css",
            libroot + "metisMenu/metisMenu.css",
            libroot + "font-awesome/css/font-awesome.css",
             libroot + "bootstrap-touch-carousel/css/*.css",
           
            libroot + "angular-animate-css/build/nga.css",
            libroot + "fullcalendar/dist/fullcalendar.css",
            
           
            libroot + "select2/select2.css",
            libroot + "toastr/toastr.css",
            libroot + "simple-line-icons/css/*.*",
            libroot + "nprogress/nprogress.css",
            libroot + "Angular-Directives/**/*.css"


           
        ]


    }

    //var wiredepOptions = {
    //    directory: 'bower_components',
    //};

    return gulp.src(paths.src + '/*.html')
        .pipe($.inject(injectStyles, { ignorePath: 'wwwroot', addRootSlash: true, name:'app' }))
         .pipe($.inject(injectScripts, injectOptions))
        .pipe($.inject(gulp.src(injectfiles.js), { ignorePath: 'wwwroot', addRootSlash: true, name: 'bower' }))
        .pipe($.inject(gulp.src(injectfiles.css), { ignorePath: 'wwwroot', addRootSlash: true, name: 'bower' }))
       
        // .pipe(wiredep(wiredepOptions))
        .pipe($.rename('index.html'))
        //  .pipe(gulp.dest(paths.tmp + '/serve'));
        .pipe(gulp.dest('./wwwroot'));
});
