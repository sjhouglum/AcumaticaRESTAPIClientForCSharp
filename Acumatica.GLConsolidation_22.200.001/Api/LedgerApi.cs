using System;
using Acumatica.RESTClient.Client;
using Acumatica.GLConsolidation_22_200_001.Model;

namespace Acumatica.GLConsolidation_22_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class LedgerApi : BaseEndpointApi<Ledger>
	{
		public LedgerApi(ApiClient client) : base(client)
		{ }
	}
}