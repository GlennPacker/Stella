(function () {
	var planetResource = ["$resource", function ($resource) {
		return $resource("/api/apiplanet/", { Id: '@id' });
	}];
	
	angular.module("common.services").factory("planetResource", planetResource);
}())