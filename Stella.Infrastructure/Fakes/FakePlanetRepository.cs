using System.Collections.Generic;
using System.Linq;
using Stella.Domain;
using Stella.Infrastructure.Interfaces;

namespace Stella.Infrastructure.Fakes
{
	public class FakePlanetRepository : IPlanetRepository
	{
		public IEnumerable<Planet> GetPlanets()
		{
			yield return new Planet(1, "Mercury", "mercury.png", 2440, "3.285 × 10^23 kg (0.055 M⊕)", 57.91M);
			yield return new Planet(2, "Venus", "venus.png", 6052, "4.867 × 10^24 kg (0.815 M⊕)", 108.2M);
			yield return new Planet(3, "Earth", "earth.png", 6371, "5.972 × 10^24 kg", 149.6M);
			yield return new Planet(4, "Mars", "mars.png", 3390, "6.39 × 10^23 kg (0.107 M⊕)", 227.9M);
			yield return new Planet(5, "Jupiter", "jupiter.png", 69911, "1.898 × 10^27 kg (317.8 M⊕)");
			yield return new Planet(6, "Saturn", "saturn.png", 58232, "5.683 × 10^26 kg (95.16 M⊕)");
			yield return new Planet(7, "Uranus", "uranus.png", 25362, "8.681 × 10^25 kg (14.54 M⊕)");
			yield return new Planet(8, "Neptune", "neptune.png", 24622, "1.024 × 10^26 kg (17.15 M⊕)");
			yield return new Planet(9, "Pluto", "pluto.png", 1187);
		}


		public Planet GetPlanet(int id)
		{
			var result = GetPlanets().FirstOrDefault(r => r.Id == id);
			return result;
		}
	}
}
