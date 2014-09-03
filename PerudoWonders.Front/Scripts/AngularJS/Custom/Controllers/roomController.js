angular.module("app.controllers").controller('RoomController', ['$http', '$scope', function ($http, $scope) {
    'use strict';

    $scope.rooms = [];
    $scope.getRoomList = function () {
        $http.get("/api/room/").success(function (roomList) {
            $scope.rooms = roomList;
        });
    };
}]);