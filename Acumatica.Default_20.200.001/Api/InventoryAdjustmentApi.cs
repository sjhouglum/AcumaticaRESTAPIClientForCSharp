using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class InventoryAdjustmentApi : BaseEndpointApi<InventoryAdjustment>
	{
		public InventoryAdjustmentApi(ApiClient client) : base(client)
		{ }
	}
}