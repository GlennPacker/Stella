using System.Collections.Generic;
using System.Web.Http.Results;
using Moq;
using NUnit.Framework;
using Stella.Domain;
using Stella.Infrastructure.Interfaces;
using Stella.Web.Controllers;

namespace Stella.Web.Tests
{
	[TestFixture]
	public class ApiPlanetControllerTests
	{
		private ApiPlanetController _controller;
		private Mock<IPlanetRepository> _mockRepo;
		
		[SetUp]
		public void Setup()
		{
			_mockRepo = new Mock<IPlanetRepository>();
			_controller = new ApiPlanetController(_mockRepo.Object);
		}

		[Test]
		public void Get_CallsRepo()
		{
			// Arrange
			_mockRepo.Setup(r => r.GetPlanets()).Returns(new List<Planet>()); 

			// Act
			var response = _controller.Get() as OkNegotiatedContentResult<List<Planet>>;

			// Assert
			Assert.IsNotNull(response);
			var data = response.Content as List<Planet>;
			Assert.IsNotNull(data);

			_mockRepo.Verify(r => r.GetPlanets(), Times.Once);
		}
		
	}
}
