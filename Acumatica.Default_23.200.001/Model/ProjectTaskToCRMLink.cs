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
	public class ProjectTaskToCRMLink : Entity
	{

		[DataMember(Name="AccountedCampaign", EmitDefaultValue=false)]
		public StringValue? AccountedCampaign { get; set; }

	}
}