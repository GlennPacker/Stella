(function () {
	"use strict";
	var app = angular.module("app", ['ui.router', 'ngToast', 'ui.bootstrap', 'common.services']);

	app.config(['$stateProvider', '$urlRouterProvider', '$httpProvider', function ($stateProvider, $urlRouterProvider, $httpProvider) {
		$httpProvider.interceptors.push('errorInterceptor');

		$urlRouterProvider.otherwise('planet');

		$stateProvider
            .state('planet', {
            	url: '/planet',
            	templateUrl: '/home/planets',
            	controller: 'planetCtrl as vm'
            });
	}]
    );

	app.factory('errorInterceptor', ['$q', 'ngToast', function ($q, ngToast) {
		return {
			request: function (config) {
				config.headers = config.headers || {};
				return config;
			},
			response: function (response) {
				return response || $q.when(response);
			},
			responseError: function (response) {
				if (response.status === 403) {
					ngToast.create({
						className: 'danger',
						content: 'Authentication failure',
						dismissOnTimeout: true,
						timeout: 3000
					});
				}
				if (response.status === 400) {
					ngToast.create({
						className: 'danger',
						content: 'Request could not be processed',
						dismissOnTimeout: true,
						timeout: 3000
					});
				}
				if (response.status === 404) {
					ngToast.create({
						className: 'danger',
						content: 'Address not found',
						dismissOnTimeout: true,
						timeout: 3000
					});
				}
			}
		};
	}]);

	app.filter('to_trusted', ['$sce', function ($sce) {
		return function (text) {
			return $sce.trustAsHtml(text);
		};
	}]);
}());