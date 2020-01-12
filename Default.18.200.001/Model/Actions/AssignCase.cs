
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class AssignCase : EntityAction<Case>
    {
 public AssignCase(Case entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Case Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
