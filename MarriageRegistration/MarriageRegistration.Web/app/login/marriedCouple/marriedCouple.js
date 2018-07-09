
angular
    .module('routerApp')
    .controller('marriedCoupleCtrl', ['$scope', '$state', 'MaritalStatusServices', function ($scope, $state, MaritalStatusServices) {
        localStorage.removeItem('MarriedCouple');
        $scope.maritalStatus = function (user) {
            MaritalStatusServices.MaritalStatusCheck(user)
                .then(function (response) {
                    localStorage.setItem('MarriedCouple', JSON.stringify(response));
                    $state.go('maritalStatus');
                }, function () {
                    localStorage.removeItem('MarriedCouple');
                    $scope.error = true;
                    $scope.mmsg = "Invalid Registration Number";
                });

        }
    }]);