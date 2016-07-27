var mockDataForThisTest = "json=" + encodeURI(JSON.stringify([{"title":"Ms","firstname":"Daisy","lastname":"Isibor","email_address":"daisyfakeemail@gmail.com","phone":"1234567890","role_name":"Board Member","address":"","city":"BELLEVUE","state":"WA","country":"USA","company":"","date_of_first_contact":"0000-00-00 00:00:00"}]));


var app = angular.module('myApp', []);

function PeopleCtrl($scope, $http) {

    $scope.people = [];

    $scope.loadPeople = function() {
        var httpRequest = $http({
            method: 'POST',
            url: '/echo/json/',
            data: mockDataForThisTest

        }).success(function(data, status) {
            $scope.people = data;
        });

    };

}