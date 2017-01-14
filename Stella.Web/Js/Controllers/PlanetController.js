(function () {
	//
	var planetCtrl = ['apiResource', function (apiResource) {
		var vm = this;
		vm.testMsg = 'Hi';
		vm.data = [];
		
		apiResource.Planet.query(
            function (data) {
            	vm.data = data;
            });
	}];

	angular.module("app").controller("planetCtrl", planetCtrl);
}());
