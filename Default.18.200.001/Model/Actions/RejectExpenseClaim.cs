
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class RejectExpenseClaim : EntityAction<ExpenseClaim>
    {
 public RejectExpenseClaim(ExpenseClaim entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ExpenseClaim Entity
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
