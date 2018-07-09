routerApp.factory('LoginCRUDServices', function ($http) {
    CRUD = {};

    CRUD.KaziAuthenticate = function (kazi) {
        var aa;
        var NID = kazi.NID;
        var Password = kazi.Password;
        var aa = $http({ method: 'Get', url: 'http://localhost:56437/api/Login', params: { NID, Password } })
            .then(function (response) {
                return response.data;
            });
            

        return aa;
    };

    return CRUD;
});