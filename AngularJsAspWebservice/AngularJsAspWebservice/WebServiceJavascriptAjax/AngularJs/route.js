app.config(function ($routeProvider) {
    $routeProvider
        .when("/Login", {
            templateUrl: "Login.html",
            controller: "LoginCtrl"
        })
        .when("/Details", {
            templateUrl: "Details.html",
            controller: "DetailsCtrl"
        })
        .when("/Register", {
            templateUrl: "Register.html",
            controller: "RegCtrl"
        });
        
});