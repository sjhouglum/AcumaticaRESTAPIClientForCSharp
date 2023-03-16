using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MoveEntryDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<MoveEntryDetailAllocation> Allocations { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="GLBatchLineNbr", EmitDefaultValue=false)]
		public IntValue GLBatchLineNbr { get; set; }

		[DataMember(Name="GLBatchNbr", EmitDefaultValue=false)]
		public StringValue GLBatchNbr { get; set; }

		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue INDocType { get; set; }

		[DataMember(Name="INLineNbr", EmitDefaultValue=false)]
		public IntValue INLineNbr { get; set; }

		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue INRefNbr { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="QtyisScrap", EmitDefaultValue=false)]
		public BooleanValue QtyisScrap { get; set; }

		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue QtyScrapped { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue Quantity { get; set; }

		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue ReasonCode { get; set; }

		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue ReceiptNbr { get; set; }

		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue ScrapAction { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue TranDescription { get; set; }

		[DataMember(Name="TransactionAttributes", EmitDefaultValue=false)]
		public List<MoveEntryTranAttribute> TransactionAttributes { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}