using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CreditCardProcessingDetail : Entity_v3
	{

		[DataMember(Name="TransactionAmount", EmitDefaultValue=false)]
		public DecimalValue TransactionAmount { get; set; }

		[DataMember(Name="TransactionStatus", EmitDefaultValue=false)]
		public StringValue TransactionStatus { get; set; }

	}
}