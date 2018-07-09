angular
    .module('routerApp')
    .controller('marriageRegiCtrl', ['$scope', '$state', 'MarriageRegistrationCRUDServices', function ($scope, $state , MarriageRegistrationCRUDServices) {
        $scope.title = "Marriage Registration";
        $scope.save = localStorage.getItem('bride');
        $scope.brideinfo = (localStorage.getItem('bride'), JSON.parse($scope.save));
        $scope.save1 = localStorage.getItem('bridegroom');
        $scope.bridegroominfo = (localStorage.getItem('bridegroom'), JSON.parse($scope.save1));
        $scope.save2 = localStorage.getItem('Kazi');
        $scope.KaziId = (localStorage.getItem('Kazi'), JSON.parse($scope.save2));
        if ($scope.KaziId != null) {
            $scope.Submit = function (reg) {

                //alert($scope.brideinfo[0].name);
                $scope.value1 = reg;
                $scope.value1.BrideName = $scope.brideinfo[0].name;
                $scope.value1.BrideNID = $scope.brideinfo[0].nid;
                $scope.value1.BridegroomName = $scope.bridegroominfo[0].name;
                $scope.value1.BridegroomNID = $scope.bridegroominfo[0].nid;
                $scope.value1.KaziId = $scope.KaziId;





                MarriageRegistrationCRUDServices.Create($scope.value1).then(function (result) {
                    //$scope.Msg = reg.CustomerInfo.Name + " Has been created successfully";
                    //crudServiceEmployees.getAll().then(function (result) {
                    //    $scope.Emps = result;
                    //});
                    $scope.msg = "Your Marriage Registration Number Is : " +result;
                    alert($scope.msg);
                    localStorage.removeItem('bride');
                    localStorage.removeItem('bridegroom');

                });
            };
        }
        else {
            $state.go('login'); 
        }
       

        $scope.submitForm = function () {

            // check to make sure the form is completely valid
            if ($scope.userForm.$valid) {
            }

        };

        $scope.Create = function () {
            alert('our form is amazing');
        }

    }]);