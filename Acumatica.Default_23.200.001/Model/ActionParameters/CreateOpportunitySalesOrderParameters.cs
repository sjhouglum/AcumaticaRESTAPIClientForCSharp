using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class CreateOpportunitySalesOrderParameters
	{
		public CreateOpportunitySalesOrderParameters() { }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }
		[DataMember(Name="RecalculatePricesandDiscounts", EmitDefaultValue=false)]
		public BooleanValue? RecalculatePricesandDiscounts { get; set; }
	}
}