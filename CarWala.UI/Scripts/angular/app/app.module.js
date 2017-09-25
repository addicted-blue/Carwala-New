angular.module('carApp', []).controller('mainCtrl', ['$scope', '$http', function ($scope, $http) {
    $scope.requestForm = {};
    $scope.requestForm.FirstName = 'Deepak';
    $scope.requestForm.LastName = 'Deepak';
    $scope.requestForm.EmailAddress = 'Deepak@gmail.com';
    $scope.requestForm.Contact = '8080502010';
    $scope.requestForm.PickUpLocation = 'Hinjewadi';
    $scope.requestForm.Destination = 'Ravet';
    $scope.requestForm.JourneyDate = '10/11/1989';
    $scope.requestForm.JourneyTime = '11:00 AM';


    $scope.RequestCab = function () {
        $http.post('/Home/SubmitCabRequest', $scope.requestForm).then(function (d) {
            console.log(d);
        });
        console.log($scope.requestForm);
    }
}]);