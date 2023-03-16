using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class EstimateToolDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public IntValue OperationID { get; set; }

		[DataMember(Name="QtyReq", EmitDefaultValue=false)]
		public DecimalValue QtyReq { get; set; }

		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue ToolID { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

	}
}