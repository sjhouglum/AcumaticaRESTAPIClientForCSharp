
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class GeneratePeriods : EntityAction<FinancialPeriod>
    {
 public GeneratePeriods(FinancialPeriod entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public FinancialPeriod Entity
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
