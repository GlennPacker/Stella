using System.Collections.Generic;
using Stella.Domain;

namespace Stella.Infrastructure.Interfaces
{
	public interface IPlanetRepository
	{
		IEnumerable<Planet> GetPlanets();
		Planet GetPlanet(int id);
	}
}