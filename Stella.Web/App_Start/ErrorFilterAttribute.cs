using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Stella.Web
{
	public class ErrorFilterAttribute : ExceptionFilterAttribute
	{
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnException(HttpActionExecutedContext context)
		{
            log.Error(context.Exception.Message, context.Exception);

            context.Response = new HttpResponseMessage(HttpStatusCode.BadRequest)
			{
				Content = new StringContent("An Error has Occured")
			};
		}
	}
}