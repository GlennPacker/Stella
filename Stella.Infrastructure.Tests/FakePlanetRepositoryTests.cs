using System.Linq;
using NUnit.Framework;
using Stella.Infrastructure.Fakes;

namespace Stella.Infrastructure.Tests
{
	[TestFixture]
	public class FakePlanetRepositoryTests
	{
		private FakePlanetRepository _repo;

		[SetUp]
		public void Setup()
		{
			_repo = new FakePlanetRepository();
		}

		[Test]
		public void GetPlanets_Can_Suply_List_Of_Planets()
		{
			// Arrange
			// Act
			var result = _repo.GetPlanets();

			// Assert
			Assert.AreEqual(9, result.Count());
		}

		[Test]
		public void GetPlanet_Gets_Correct_Planet()
		{
			// Arrange
			// Act
			var result = _repo.GetPlanet(1);

			// Assert
			Assert.AreEqual(1, result.Id);
		}
	}
}
