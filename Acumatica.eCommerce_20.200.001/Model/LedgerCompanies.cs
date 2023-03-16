using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class LedgerCompanies : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue Company { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

		[DataMember(Name="CompanyType", EmitDefaultValue=false)]
		public StringValue CompanyType { get; set; }

	}
}