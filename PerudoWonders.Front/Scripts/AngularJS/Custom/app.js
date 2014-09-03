var app = angular.module('app', ['ngRoute',
    'app.services',
    'app.controllers',
    'app.directives']);

app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.when('/', {
        templateUrl: '/ngViews/Connect.html',
        controller: 'PlayerController'
    }).when('/roomlist', {
        templateUrl: '/ngViews/RoomList.html',
        controller: 'RoomController'
    }).otherwise({
        redirectTo: '/'
    });

    $locationProvider.html5Mode(true);
}]);