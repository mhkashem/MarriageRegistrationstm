angular
    .module('routerApp')
    .controller('CheckingCtrl', ['$scope', '$state', 'CheckingCRUDServices', function ($scope, $state, CheckingCRUDServices) {

       
        var a, b;
        $scope.BrideChecking = function (user) {
            
            a = user.bnid;
            $scope.user = {};
            
            CheckingCRUDServices.getByNID(user).then(function (result) {
                $scope.error = false;
                $scope.msg = true;
                $scope.value = result;
                $scope.bnid = result[0].nid;
                localStorage.setItem('bride', JSON.stringify(result));
            }, function () {
                $scope.msg = false;
                $scope.error = true;
                $scope.mmsg = "Yor are not eligible.";

            });
           
        }
        $scope.BridegroomChecking = function (user) {
            b = user.bgnid;
            $scope.user1 = {};
            CheckingCRUDServices.getBridegroom(user).then(function (result) {

                $scope.value1 = result;
                $scope.bgnid = result[0].nid;
               
                if (b === $scope.bgnid && a === $scope.bnid) {
                    $scope.a = false;
                    $scope.ms = true;
                    $scope.value1 = result;
                    localStorage.setItem('bridegroom', JSON.stringify(result));
                    $scope.show = b;
                }


               

            }, function () {
                $scope.ms = false;
                $scope.a = true;
                $scope.mms = "Yor are not eligible.";

            });
           
        }

        $scope.register = function () {
            $state.go('marriageRegistration');
        }
    }]);