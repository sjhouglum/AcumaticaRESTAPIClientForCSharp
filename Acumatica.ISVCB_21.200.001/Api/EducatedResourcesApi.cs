using Acumatica.RESTClient.Client;
using Acumatica.ISVCB_21_200_001.Model;

namespace Acumatica.ISVCB_21_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class EducatedResourcesApi : BaseEndpointApi<EducatedResources>
	{
		public EducatedResourcesApi(ApiClient client) : base(client)
		{ }
	}
}