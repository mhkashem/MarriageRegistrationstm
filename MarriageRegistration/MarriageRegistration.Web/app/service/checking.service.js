routerApp.factory('CheckingCRUDServices', function ($http) {
    CRUD = {};

   
    CRUD.getByNID = function (eid) {
        var Emp;
        var searchText = eid.bnid;
        var Emp = $http({ method: 'Get', url: 'http://localhost:56437/api/Checking', params: { searchText } }).
            then(function (response) {
                return response.data;
            });

        return Emp;
    };
    CRUD.getBridegroom = function (eid) {
        var Emp;
        var searchText = eid.bgnid;
        var Emp = $http({ method: 'Get', url: 'http://localhost:56437/api/BridegroomChecking', params: { searchText } }).
            then(function (response) {
                return response.data;
            });

        return Emp;
    };

    

   

    

    return CRUD;
});
