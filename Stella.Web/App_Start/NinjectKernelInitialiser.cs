using System.Configuration;
using Ninject;
using Stella.Infrastructure.Fakes;
using Stella.Infrastructure.Interfaces;

namespace Stella.Web.App_Start
{
	public class NinjectKernelInitialiser
	{
		public static void Configure(IKernel kernel)
		{
			if (ConfigurationManager.AppSettings["Virtual.Mode"] != null &&
				ConfigurationManager.AppSettings["Virtual.Mode"].ToUpper() == "TRUE")
				BindFakes(kernel);
			else
				BindReal(kernel);
		}

		public static void BindReal(IKernel kernel)
		{
			// no real implementations as there is no database to keep project simple and unknown ORM preference.
		}

		public static void BindFakes(IKernel kernel)
		{
			kernel.Bind<IPlanetRepository>().To<FakePlanetRepository>();
		}
	}
}