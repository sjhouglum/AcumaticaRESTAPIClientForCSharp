using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	public class ServiceOrderApi : BaseEndpointApi<ServiceOrder>
	{
		public ServiceOrderApi(ApiClient client) : base(client)
		{ }
	}
}