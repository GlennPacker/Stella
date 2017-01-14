var apiResource = ["planetResource",
        function (planetResource) {
	        return {
	        	Planet: planetResource
	        };
        }];

angular.module("common.services").factory("apiResource", apiResource);