(function () {
    //
    var dirPlanet = [function (service) {
        return {
            restrict: "E",
            templateUrl: "home/DirPlanet",
            transclude: true,
            scope: {
                planet: '='
            },
            link: function (scope, element, attrs, ngModel) {
                scope.showFull = false;

                scope.toggle = function () {
                    scope.showFull = !scope.showFull;
                }
            }
        }
    }
    ];

    angular.module("app").directive("dirPlanet", dirPlanet);
}());