var app = angular.module("app", ['ngRoute', 'ui.bootstrap'])

.config(['$routeProvider', function($routeProvider){
    $routeProvider
        .when("/", {
            templateUrl: "ux/partials/overview.html"
            // controller: "searchController"
        })
        .when("/people", {
            templateUrl: "ux/partials/people.html",
            controller: "peopleController"
        })
        .otherwise({
            templateUrl: "ux/partials/overview.html"
        })
}])

.controller("peopleController", ['$scope', '$http', function ($scope, $http) {

    $scope.people = [];

    $scope.init = function () {
        $scope.loadPeople();
    }

    $scope.loadPeople = function() {
        var httpRequest = $http({
            method: 'POST',
            url: 'ux/mock/people.json',
            data: ""
        }).success(function(data, status) {
            console.log(data);
            $scope.people = data;
        });

    };

    $scope.init();

}])