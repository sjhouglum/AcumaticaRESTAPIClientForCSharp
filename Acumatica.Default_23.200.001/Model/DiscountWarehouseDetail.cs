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
	public class DiscountWarehouseDetail : Entity
	{

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}