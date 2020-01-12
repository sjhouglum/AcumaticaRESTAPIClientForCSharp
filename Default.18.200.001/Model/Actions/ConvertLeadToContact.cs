
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ConvertLeadToContact : EntityAction<Lead>
    {
 public ConvertLeadToContact(Lead entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Lead Entity
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
