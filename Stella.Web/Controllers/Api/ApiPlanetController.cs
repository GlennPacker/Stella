using System.Linq;
using System.Web.Http;
using Stella.Infrastructure.Interfaces;

namespace Stella.Web.Controllers
{
	public class ApiPlanetController : ApiController
	{
		private readonly IPlanetRepository _repository;

		public ApiPlanetController(IPlanetRepository repository)
		{
			_repository = repository;
		}

		// GET api/<controller>
		public IHttpActionResult Get()
		{
			var data = _repository.GetPlanets().ToList();
			return Ok(data);
		}
	}
}