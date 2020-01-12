
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class SalesInvoiceAddOrder : EntityAction<SalesInvoice>
    {
 public SalesInvoiceAddOrder(SalesInvoice entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public SalesInvoice Entity
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
