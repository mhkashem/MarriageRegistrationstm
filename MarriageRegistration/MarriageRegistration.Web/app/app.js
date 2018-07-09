var routerApp = angular.module('routerApp', ['ui.router', 'angularjs-datetime-picker']);

routerApp.config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/home');

    $stateProvider

        .state('home', {
            url: '/home',
            templateUrl: 'app/home/home.html'
        })

       

         //Kazi Login
        .state('login', {
            url: '/login',
            templateUrl: 'app/login/kazi/kazi.login.html',
            controller: 'loginCtrl'

        })
         //Married Couple Login
        .state('marriedCouple', {
            url: '/marriedCouple',
            templateUrl: 'app/login/marriedCouple/marriedCouple.login.html',
            controller:'marriedCoupleCtrl'

        })

        .state('marriageRegistration', {
            url: '/marriageRegistration',
            templateUrl: 'app/marriageRegistration/marriageRegistration.html',
            controller:'marriageRegiCtrl'
        })
    
        .state('checking', {
            url: '/checking',
            templateUrl: 'app/marriageRegistration/checking.html',
            controller: 'CheckingCtrl'
        })

        .state('maritalStatus', {
            url: '/maritalStatus',
            templateUrl: 'app/MaritalStatus/maritalStatus.html',
            controller: 'maritalStatusCtrl'
        })
       
        // ABOUT PAGE AND MULTIPLE NAMED VIEWS =================================
        .state('about', {
            url: '/about',
            views: {
                '': { templateUrl: 'app/about/partial-about.html' },
                'columnOne@about': { template: 'Look I am a column!' },
                'columnTwo@about': {
                    templateUrl: 'table-data.html',
                    controller: 'scotchController'
                }
            }

        });
   

});

