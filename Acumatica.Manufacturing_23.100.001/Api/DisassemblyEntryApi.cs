using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	[Obsolete("For backward compatibility")]
	public class DisassemblyEntryApi : BaseEndpointApi<DisassemblyEntry>
	{
		public DisassemblyEntryApi(ApiClient client) : base(client)
		{ }
	}
}