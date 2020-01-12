
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class SalesOrderCreatePurchaseOrder : EntityAction<SalesOrder>
    {
 public SalesOrderCreatePurchaseOrder(SalesOrder entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public SalesOrder Entity
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
