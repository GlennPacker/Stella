using NUnit.Framework;

namespace Stella.Domain.Tests
{
	[TestFixture]
	public class PlanetTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Constructor_Populates_All_Values()
		{
			// Arrange
			// Act
			var result = new Planet(100, "name", "path", 1, "mass", 0);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(100, result.Id);
			Assert.AreEqual("name", result.Name);
			Assert.AreEqual("path", result.PicturePath);
			Assert.AreEqual("mass", result.Mass);
			Assert.AreEqual(0, result.DistanceFromTheSun);
			Assert.AreEqual(1, result.Radius);
		}

		[Test]
		public void Constructor_Populates_Required_Values()
		{
			// Arrange
			// Act
			var result = new Planet(100, "name", "path");

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(100, result.Id);
			Assert.AreEqual("name", result.Name);
			Assert.AreEqual("path", result.PicturePath);
			Assert.IsNull(result.Mass);
			Assert.IsNull(result.DistanceFromTheSun);
			Assert.IsNull(result.Radius);
		}

		[TestCase(0, 0)]
		[TestCase(1, 2)]
		[TestCase(null, null)]
		public void Diameter_Calcualtion_Is_Correct(long radius, long expectedResult)
		{
			// Arrange
			// Act
			var result = new Planet(1, "name", "path", radius);

			// Assert
			Assert.AreEqual(expectedResult, result.Diameter);
		}

	}
}
