using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class BillTaxDetail : Entity_v3
	{

		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue TaxableAmount { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue TaxAmount { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue TaxRate { get; set; }

	}
}