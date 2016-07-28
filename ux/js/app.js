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
        .when("/events", {
            templateUrl: "ux/partials/events.html",
            controller: "peopleController"
        })
        .when("/donor-activity", {
            templateUrl: "ux/partials/donor-activity.html",
            controller: "peopleController"
        })
        .when("/expenses", {
            templateUrl: "ux/partials/expenses.html",
            controller: "peopleController"
        })
        .otherwise({
            templateUrl: "ux/partials/overview.html"
        })
}])

.config(function($httpProvider) {
  //Enable cross domain calls
  $httpProvider.defaults.useXDomain = true;

  //Remove the header used to identify ajax call  that would prevent CORS from working
  delete $httpProvider.defaults.headers.common['X-Requested-With'];
})

.controller("peopleController", ['$scope', '$http', function ($scope, $http) {

    $scope.people = [];

    $scope.init = function () {
        $scope.loadPeople();
    }

    $scope.loadPeople = function() {
        var httpRequest = $http({
            method: 'GET',
            url: 'http://localhost:3000/people'
        }).success(function(data, status) {
            console.log(data);
            $scope.people = data;
        });

    };

    $scope.init();

}])