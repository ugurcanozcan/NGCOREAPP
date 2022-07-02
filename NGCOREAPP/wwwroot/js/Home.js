var app = angular.module("APP", []);
app.controller("Home", function ($scope, $http) {

    $scope.Copied = ""; 
    

    $scope.GenerateShort = function () {

        $http({
            method: "POST",
            headers: { "Content-Type": "Application/json; charset=utf-8" },
            url: "/Home/GenerateShortLink",
            data: $scope._link,
        }).then(function (result) {

            $scope.ShortLink = result.data;
            $scope.GetLinkList();
        });
    }

    $scope.GetLinkList = function () {
        $http({
            method: "POST",
            headers: { "Content-Type": "Application/json; charset=utf-8" },
            url: "/Home/GetLinkList",
        }).then(function (result) {

            $scope.LinkList = result.data;

        });
    }

    $scope.GetLinkList();



    $scope.PreCopy = function (shortCode) {


        Copy(shortCode);

        $("#msg").removeClass("d-none");

        $scope.Copied = $("#kopyala" + shortCode).html();

        setTimeout(function () {
            $scope.Copied = "";
            $("#msg").addClass("d-none");
        }, 3000);


    }

    $scope.AddCredit = function (link) {
        
        $scope.currentLink = link;
        
        $http({
            method: "POST",
            headers: { "Content-Type": "Application/json; charset=utf-8" },
            url: "/Home/AddCredit",
            data: $scope.currentLink,
        }).then(function (result) {

            
        });
    }
   

   





});

function Copy(shortCode) {
    var r = document.createRange();
    var element = document.getElementById("kopyala" + shortCode);
    r.selectNode(element);
    window.getSelection().removeAllRanges();
    window.getSelection().addRange(r);
    document.execCommand("copy");
    window.getSelection().removeAllRanges();

    
}