
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class LockProjectCommitments : EntityAction<Project>
    {
 public LockProjectCommitments(Project entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Project Entity
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
