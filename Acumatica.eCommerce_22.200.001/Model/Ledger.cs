using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class Ledger : Entity, ITopLevelEntity
	{

		[DataMember(Name="Branches", EmitDefaultValue=false)]
		public List<LedgerBranches>? Branches { get; set; }

		[DataMember(Name="Companies", EmitDefaultValue=false)]
		public List<LedgerCompanies>? Companies { get; set; }

		[DataMember(Name="ConsolidationSource", EmitDefaultValue=false)]
		public BooleanValue? ConsolidationSource { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}