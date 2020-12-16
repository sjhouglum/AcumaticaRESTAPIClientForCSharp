using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShippingZones : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ZoneID", EmitDefaultValue=false)]
		public StringValue ZoneID { get; set; }

	}
}