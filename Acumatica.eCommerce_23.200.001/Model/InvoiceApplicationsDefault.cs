using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class InvoiceApplicationsDefault : Entity
	{

		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="PaymentDate", EmitDefaultValue=false)]
		public DateTimeValue? PaymentDate { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}