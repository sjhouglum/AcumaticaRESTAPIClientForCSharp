using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public class CheckApi : BaseEndpointApi<Check>
	{
		public CheckApi(Configuration configuration) : base(configuration)
		{ }
	}
}