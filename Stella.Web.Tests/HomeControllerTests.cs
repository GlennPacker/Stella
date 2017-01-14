using System.Web.Mvc;
using NUnit.Framework;
using Stella.Web.Controllers;

namespace Stella.Web.Tests
{
	[TestFixture]
	public class HomeControllerTests
	{
		private HomeController _controller;

		[SetUp]
		public void Setup()
		{
			_controller = new HomeController();
		}

		[Test]
		public void Index_ReturnsView()
		{
			// Arrange
			// Act
			var result = _controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("Index", result.ViewName);
		}

		[Test]
		public void Planets_ReturnsView()
		{
			// Arrange
			// Act
			var result = _controller.Planets() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("Planets", result.ViewName);
		}

		[Test]
		public void DirPlanet_ReturnsView()
		{
			// Arrange
			// Act
			var result = _controller.DirPlanet() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("DirPlanet", result.ViewName);
		}
	}
}
