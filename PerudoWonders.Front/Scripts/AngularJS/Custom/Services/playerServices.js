angular.module('app.services').factory('ajaxPlayer', ['$http', function ($http) {
    return {
        createPlayer: function (playerData) {
            //return the promise directly.
            return $http.post("http://localhost:9000/api/Player/", $.param(playerData),
            {
                headers:
                {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        }
    };
}]);