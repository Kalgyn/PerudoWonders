angular.module('app.controllers').controller('PlayerController', ['$http', '$location', '$scope', 'ajaxPlayer', function ($http, $location, $scope, ajaxPlayer) {
    'use strict';

    $scope.player = {};
    $scope.createPlayer = function (player) {
        var promise = ajaxPlayer.createPlayer(player);
        promise.then(function (data) {
                var playerId = data;
                $scope.player.Id = playerId;
                $location.path("roomlist");
            }
        );
    };
}]);