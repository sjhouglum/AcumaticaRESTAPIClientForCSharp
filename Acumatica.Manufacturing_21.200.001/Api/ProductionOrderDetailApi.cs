using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ProductionOrderDetailApi : BaseEndpointApi<ProductionOrderDetail>
	{
		public ProductionOrderDetailApi(ApiClient client) : base(client)
		{ }
	}
}