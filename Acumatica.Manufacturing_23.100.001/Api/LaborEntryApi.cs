using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	[Obsolete("For backward compatibility")]
	public class LaborEntryApi : BaseEndpointApi<LaborEntry>
	{
		public LaborEntryApi(ApiClient client) : base(client)
		{ }
	}
}