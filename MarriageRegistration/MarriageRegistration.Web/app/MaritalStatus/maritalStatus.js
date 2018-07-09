angular
    .module('routerApp')
    .controller('maritalStatusCtrl', ['$scope', '$state', function ($scope, $state) {


        $scope.marriedInfo = localStorage.getItem('MarriedCouple');
        $scope.mmm = false;
        if ($scope.marriedInfo != null) {
            $scope.mmm = true;
            $scope.marriedInfoes = (localStorage.getItem('MarriedCouple'), JSON.parse($scope.marriedInfo));
            $scope.BrideName = $scope.marriedInfoes.brideName;
            $scope.BrideNID = $scope.marriedInfoes.brideNID;
            $scope.BridegroomName = $scope.marriedInfoes.bridegroomName;
            $scope.BridegroomNID = $scope.marriedInfoes.bridegroomNID;
            localStorage.removeItem('MarriedCouple');
        } else {
            $state.go('marriedCouple');
        }

        
    }]);