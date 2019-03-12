var app = angular.module('BlankApp', ['ngMaterial', 'ngMessages']);

app.controller('MainCtrl', function ($scope, $timeout) {
    $scope.loginModel = {
        username: '',
        password: '',
        retypepassword: '',
        something: ''
    };

 
    $scope.somefunction =function() {
        console.log("pressed");
    }

    $scope.inputype = 'password';
    $scope.repassvisible = true;
    $scope.reinputype = 'password';
    $scope.passwordvisible = true;
    $scope.showrepassword = function () {
        $scope.reinputype = 'text';
        $scope.repassvisible = false;
    }
    $scope.hiderepassword = function () {
        $scope.reinputype = 'password';
        $scope.repassvisible = true;
    }

    $scope.showpassword = function () {
        $scope.inputype = 'text';
        $scope.passwordvisible = false;
    }
    $scope.hidepassword = function () {
        $scope.inputype = 'password';
        $scope.passwordvisible = true;
    }

});