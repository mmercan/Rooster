'use strict';
angular.module('app', []);
angular.module('inspinia', ['ngAnimate', 'ngCookies', 'ngTouch', 'ngSanitize', 'ngResource', 'ui.router', 'ui.bootstrap', 'app', 'oc.lazyLoad', 'directives', 'component'])
  .config(function ($stateProvider, $urlRouterProvider,$ocLazyLoadProvider) {

      $ocLazyLoadProvider.config({
          // Set to true if you want to see what and when is dynamically loaded
          debug: false
      });


            $stateProvider
                .state('index', {
                    abstract: true,
                    url: "/index",
                    templateUrl: "components/common/content.html",
                })
                .state('index.main', {
                    url: "/main",
                    templateUrl: "app/main/main.html",
                    data: { pageTitle: 'Example view' }
                })
                .state('index.minor', {
                    url: "/minor",
                    templateUrl: "app/minor/minor.html",
                    data: { pageTitle: 'Example view' }
                }).state('index.calendar', {
                    url: "/calendar",
                    templateUrl: "app/calendar/calendar.html",
                    controller:"calendarCtrl",
                    controllerAs:"vm",
                    data: { pageTitle: 'Calendar view' },
                resolve: {
                loadPlugin: function ($ocLazyLoad) {
                    return $ocLazyLoad.load([
                        {
                            serie: true,
                            name: 'fullcalendar',
                            files: ['/lib/fullcalendar/fullcalendar.js', '/lib/fullcalendar/fullcalendar.css']
                        }
                    ]);
                }
            }
                });

    $urlRouterProvider.otherwise('/index/main');
  })
;
