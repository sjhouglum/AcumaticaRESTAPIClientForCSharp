using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_200_001.Model;

namespace Acumatica.Manufacturing_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class MoveEntryApi : BaseEndpointApi<MoveEntry>
	{
		public MoveEntryApi(ApiClient client) : base(client)
		{ }
	}
}