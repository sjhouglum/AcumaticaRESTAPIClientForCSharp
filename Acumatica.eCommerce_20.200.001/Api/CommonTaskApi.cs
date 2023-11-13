using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	public class CommonTaskApi : BaseEndpointApi<CommonTask>
	{
		public CommonTaskApi(ApiClient client) : base(client)
		{ }
	}
}