using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CompaniesStructure : Entity
	{

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<CompaniesStructureDetail> Results { get; set; }

	}
}