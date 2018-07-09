angular
    .module('routerApp')
    .controller('loginCtrl', ['$scope', '$state', 'LoginCRUDServices', function ($scope, $state, LoginCRUDServices) {
        $scope.login = function (kazi) {
            localStorage.removeItem('Kazi');
            LoginCRUDServices.KaziAuthenticate(kazi)
                .then(function (result) {
                  
                        $scope.id = result;
                        localStorage.setItem('Kazi', JSON.stringify(result));
                        $state.go('checking');
                    
                   
                }, function () {
                    localStorage.removeItem('Kazi');
                    $scope.error = true; 
                    $scope.mmsg = "Please Enter Valid NID And Password";

                });



              };  //$state.go('checking');
            
           
        
    }]);