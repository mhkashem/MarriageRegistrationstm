routerApp.factory('MarriageRegistrationCRUDServices', function ($http) {
    CRUD = {};

  
   

  

    CRUD.Create = function (emp) {
        var aa;
        
        var aa = $http({ method: 'Post', url: 'http://localhost:56437/api/MarriageRegisters', data: emp }).
            then(function (response) {
                return response.data;
            });

        return aa;
    };

   

    return CRUD;
});
