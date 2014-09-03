angular.module('app.directives').directive('roomModalForm', function () {
    'use strict';
    return {
        templateUrl: '/ngViews/RoomModalForm.html',
        controller: 'RoomController',
        restrict : 'E'
    };
});