using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class FinancialPeriodApi : BaseEndpointApi<FinancialPeriod>
	{
		public FinancialPeriodApi(ApiClient client) : base(client)
		{ }
	}
}