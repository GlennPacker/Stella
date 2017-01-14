describe("PlanetCtrl", function () {
	var ctrl;
	
	beforeEach(function () {
	    module('app');

	    inject(function ($controller, $q, $sce) {

	        apiResource = {
	            Planet: {
	                query: function () { }
	            }
	        }
	        spyOn(apiResource.Planet, 'query');

	        ctrl = $controller('planetCtrl', { 'apiResource': apiResource });
		});
	});

	it('constructs ok', function () {
			expect(ctrl).toBeDefined();
			expect(ctrl.testMsg).toBeDefined();
			expect(ctrl.testMsg).toBe("Hi");
	});

	it('can get data from api', function () {
        expect(apiResource.Planet.query).toHaveBeenCalled();
	})
	
});
