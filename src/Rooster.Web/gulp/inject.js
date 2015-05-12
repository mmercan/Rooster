'use strict';

var gulp = require('gulp');

var paths = gulp.paths;

var $ = require('gulp-load-plugins')();

var wiredep = require('wiredep').stream;

gulp.task('inject', ['styles'], function () {

  var injectStyles = gulp.src([
    'wwwroot/css/**/*.css',
    '!wwwroot/css/vendor.css'
  ], { read: false });

  var injectScripts = gulp.src([
    paths.src + '/{app,components}/**/*.js',
    '!' + paths.src + '/{app,components}/**/*.spec.js',
    '!' + paths.src + '/{app,components}/**/*.mock.js'
  ]).pipe($.angularFilesort());

  var injectOptions = {
      // ignorePath: [paths.src, paths.tmp + '/serve'],
      ignorePath: [paths.src],
    addRootSlash: true
  };

  var wiredepOptions = {
    directory: 'wwwroot/bower_components',
   // exclude: [/bootstrap\.js/, /bootstrap\.css/, /bootstrap\.css/, /foundation\.css/]
  };

  return gulp.src(paths.src + '/*.html')
    .pipe($.inject(injectStyles, { ignorePath: 'wwwroot', addRootSlash: true }))
    .pipe($.inject(injectScripts, injectOptions))
    .pipe(wiredep(wiredepOptions))
      .pipe($.rename('index.html'))
  //  .pipe(gulp.dest(paths.tmp + '/serve'));
      .pipe(gulp.dest('./wwwroot'));
});
