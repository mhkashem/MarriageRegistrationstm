routerApp.factory('MaritalStatusServices', function ($http) {
    CRUD = {};

    CRUD.getAll = function () {
        var all;

        var all = $http({ method: 'Get', url: '/api/PurchaseInfoes/' }).
            then(function (response) {
                return response.data;
            });

        return all;
    };

    CRUD.getByEid = function (eid) {
        var Emp;

        var Emp = $http({ method: 'Get', url: '/api/PurchaseInfoes/', params: { id: eid } }).
            then(function (response) {
                return response.data;
            });

        return Emp;
    };

    CRUD.deleteByEid = function (eid) {
        var cc;

        var cc = $http({ method: 'Delete', url: '/api/PurchaseInfoes/', params: { id: eid } }).
            then(function (response) {
                return response.data;
            });

        return cc;
    };

    CRUD.MaritalStatusCheck = function (user) {
        var regi_no = user.marriageRegNo;
        var aa = $http({ method: 'Get', url: 'http://localhost:56437/api/MaritalStatus', params: { regi_no } })
            .then(function (response) {
                alert("fair");
                return response.data;
            });


        return aa;
    };

    CRUD.updateEmployee = function (eid, emp) {

        var Emp;

        var Emp = $http({ method: 'Put', url: '/api/PurchaseInfoes', params: { id: eid }, data: emp }).then(function (response) {
            return response.data;
        });

        return Emp;
    };

    return CRUD;
});