using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_23_200_001.Model;

namespace Acumatica.eCommerce_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class VendorApi : BaseEndpointApi<Vendor>
	{
		public VendorApi(ApiClient client) : base(client)
		{ }
	}
}