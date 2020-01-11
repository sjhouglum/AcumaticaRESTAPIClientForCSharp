/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Acumatica.RESTClient.Client.OpenAPIDateConverter;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
    /// <summary>
    /// BusinessAccountDefaultLocationSetting
    /// </summary>
    [DataContract]
    public partial class BusinessAccountDefaultLocationSetting : Entity,  IEquatable<BusinessAccountDefaultLocationSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountDefaultLocationSetting" /> class.
        /// </summary>
        /// <param name="fOBPoint">fOBPoint.</param>
        /// <param name="insurance">insurance.</param>
        /// <param name="leadTimeInDays">leadTimeInDays.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="orderPriority">orderPriority.</param>
        /// <param name="priceClass">priceClass.</param>
        /// <param name="residentialDelivery">residentialDelivery.</param>
        /// <param name="saturdayDelivery">saturdayDelivery.</param>
        /// <param name="shippingBranch">shippingBranch.</param>
        /// <param name="shippingRule">shippingRule.</param>
        /// <param name="shippingTerms">shippingTerms.</param>
        /// <param name="shippingZone">shippingZone.</param>
        /// <param name="shipVia">shipVia.</param>
        /// <param name="taxRegistrationID">taxRegistrationID.</param>
        /// <param name="taxZone">taxZone.</param>
        /// <param name="warehouse">warehouse.</param>
        public BusinessAccountDefaultLocationSetting(StringValue fOBPoint = default(StringValue), BooleanValue insurance = default(BooleanValue), ShortValue leadTimeInDays = default(ShortValue), StringValue locationName = default(StringValue), ShortValue orderPriority = default(ShortValue), StringValue priceClass = default(StringValue), BooleanValue residentialDelivery = default(BooleanValue), BooleanValue saturdayDelivery = default(BooleanValue), StringValue shippingBranch = default(StringValue), StringValue shippingRule = default(StringValue), StringValue shippingTerms = default(StringValue), StringValue shippingZone = default(StringValue), StringValue shipVia = default(StringValue), StringValue taxRegistrationID = default(StringValue), StringValue taxZone = default(StringValue), StringValue warehouse = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.FOBPoint = fOBPoint;
            this.Insurance = insurance;
            this.LeadTimeInDays = leadTimeInDays;
            this.LocationName = locationName;
            this.OrderPriority = orderPriority;
            this.PriceClass = priceClass;
            this.ResidentialDelivery = residentialDelivery;
            this.SaturdayDelivery = saturdayDelivery;
            this.ShippingBranch = shippingBranch;
            this.ShippingRule = shippingRule;
            this.ShippingTerms = shippingTerms;
            this.ShippingZone = shippingZone;
            this.ShipVia = shipVia;
            this.TaxRegistrationID = taxRegistrationID;
            this.TaxZone = taxZone;
            this.Warehouse = warehouse;
        }
        
        /// <summary>
        /// Gets or Sets FOBPoint
        /// </summary>
        [DataMember(Name="FOBPoint", EmitDefaultValue=false)]
        public StringValue FOBPoint { get; set; }

        /// <summary>
        /// Gets or Sets Insurance
        /// </summary>
        [DataMember(Name="Insurance", EmitDefaultValue=false)]
        public BooleanValue Insurance { get; set; }

        /// <summary>
        /// Gets or Sets LeadTimeInDays
        /// </summary>
        [DataMember(Name="LeadTimeInDays", EmitDefaultValue=false)]
        public ShortValue LeadTimeInDays { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public StringValue LocationName { get; set; }

        /// <summary>
        /// Gets or Sets OrderPriority
        /// </summary>
        [DataMember(Name="OrderPriority", EmitDefaultValue=false)]
        public ShortValue OrderPriority { get; set; }

        /// <summary>
        /// Gets or Sets PriceClass
        /// </summary>
        [DataMember(Name="PriceClass", EmitDefaultValue=false)]
        public StringValue PriceClass { get; set; }

        /// <summary>
        /// Gets or Sets ResidentialDelivery
        /// </summary>
        [DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
        public BooleanValue ResidentialDelivery { get; set; }

        /// <summary>
        /// Gets or Sets SaturdayDelivery
        /// </summary>
        [DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
        public BooleanValue SaturdayDelivery { get; set; }

        /// <summary>
        /// Gets or Sets ShippingBranch
        /// </summary>
        [DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
        public StringValue ShippingBranch { get; set; }

        /// <summary>
        /// Gets or Sets ShippingRule
        /// </summary>
        [DataMember(Name="ShippingRule", EmitDefaultValue=false)]
        public StringValue ShippingRule { get; set; }

        /// <summary>
        /// Gets or Sets ShippingTerms
        /// </summary>
        [DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
        public StringValue ShippingTerms { get; set; }

        /// <summary>
        /// Gets or Sets ShippingZone
        /// </summary>
        [DataMember(Name="ShippingZone", EmitDefaultValue=false)]
        public StringValue ShippingZone { get; set; }

        /// <summary>
        /// Gets or Sets ShipVia
        /// </summary>
        [DataMember(Name="ShipVia", EmitDefaultValue=false)]
        public StringValue ShipVia { get; set; }

        /// <summary>
        /// Gets or Sets TaxRegistrationID
        /// </summary>
        [DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
        public StringValue TaxRegistrationID { get; set; }

        /// <summary>
        /// Gets or Sets TaxZone
        /// </summary>
        [DataMember(Name="TaxZone", EmitDefaultValue=false)]
        public StringValue TaxZone { get; set; }

        /// <summary>
        /// Gets or Sets Warehouse
        /// </summary>
        [DataMember(Name="Warehouse", EmitDefaultValue=false)]
        public StringValue Warehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountDefaultLocationSetting {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  FOBPoint: ").Append(FOBPoint).Append("\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  LeadTimeInDays: ").Append(LeadTimeInDays).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  OrderPriority: ").Append(OrderPriority).Append("\n");
            sb.Append("  PriceClass: ").Append(PriceClass).Append("\n");
            sb.Append("  ResidentialDelivery: ").Append(ResidentialDelivery).Append("\n");
            sb.Append("  SaturdayDelivery: ").Append(SaturdayDelivery).Append("\n");
            sb.Append("  ShippingBranch: ").Append(ShippingBranch).Append("\n");
            sb.Append("  ShippingRule: ").Append(ShippingRule).Append("\n");
            sb.Append("  ShippingTerms: ").Append(ShippingTerms).Append("\n");
            sb.Append("  ShippingZone: ").Append(ShippingZone).Append("\n");
            sb.Append("  ShipVia: ").Append(ShipVia).Append("\n");
            sb.Append("  TaxRegistrationID: ").Append(TaxRegistrationID).Append("\n");
            sb.Append("  TaxZone: ").Append(TaxZone).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessAccountDefaultLocationSetting);
        }

        /// <summary>
        /// Returns true if BusinessAccountDefaultLocationSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountDefaultLocationSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountDefaultLocationSetting input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FOBPoint == input.FOBPoint ||
                    (this.FOBPoint != null &&
                    this.FOBPoint.Equals(input.FOBPoint))
                ) && base.Equals(input) && 
                (
                    this.Insurance == input.Insurance ||
                    (this.Insurance != null &&
                    this.Insurance.Equals(input.Insurance))
                ) && base.Equals(input) && 
                (
                    this.LeadTimeInDays == input.LeadTimeInDays ||
                    (this.LeadTimeInDays != null &&
                    this.LeadTimeInDays.Equals(input.LeadTimeInDays))
                ) && base.Equals(input) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && base.Equals(input) && 
                (
                    this.OrderPriority == input.OrderPriority ||
                    (this.OrderPriority != null &&
                    this.OrderPriority.Equals(input.OrderPriority))
                ) && base.Equals(input) && 
                (
                    this.PriceClass == input.PriceClass ||
                    (this.PriceClass != null &&
                    this.PriceClass.Equals(input.PriceClass))
                ) && base.Equals(input) && 
                (
                    this.ResidentialDelivery == input.ResidentialDelivery ||
                    (this.ResidentialDelivery != null &&
                    this.ResidentialDelivery.Equals(input.ResidentialDelivery))
                ) && base.Equals(input) && 
                (
                    this.SaturdayDelivery == input.SaturdayDelivery ||
                    (this.SaturdayDelivery != null &&
                    this.SaturdayDelivery.Equals(input.SaturdayDelivery))
                ) && base.Equals(input) && 
                (
                    this.ShippingBranch == input.ShippingBranch ||
                    (this.ShippingBranch != null &&
                    this.ShippingBranch.Equals(input.ShippingBranch))
                ) && base.Equals(input) && 
                (
                    this.ShippingRule == input.ShippingRule ||
                    (this.ShippingRule != null &&
                    this.ShippingRule.Equals(input.ShippingRule))
                ) && base.Equals(input) && 
                (
                    this.ShippingTerms == input.ShippingTerms ||
                    (this.ShippingTerms != null &&
                    this.ShippingTerms.Equals(input.ShippingTerms))
                ) && base.Equals(input) && 
                (
                    this.ShippingZone == input.ShippingZone ||
                    (this.ShippingZone != null &&
                    this.ShippingZone.Equals(input.ShippingZone))
                ) && base.Equals(input) && 
                (
                    this.ShipVia == input.ShipVia ||
                    (this.ShipVia != null &&
                    this.ShipVia.Equals(input.ShipVia))
                ) && base.Equals(input) && 
                (
                    this.TaxRegistrationID == input.TaxRegistrationID ||
                    (this.TaxRegistrationID != null &&
                    this.TaxRegistrationID.Equals(input.TaxRegistrationID))
                ) && base.Equals(input) && 
                (
                    this.TaxZone == input.TaxZone ||
                    (this.TaxZone != null &&
                    this.TaxZone.Equals(input.TaxZone))
                ) && base.Equals(input) && 
                (
                    this.Warehouse == input.Warehouse ||
                    (this.Warehouse != null &&
                    this.Warehouse.Equals(input.Warehouse))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.FOBPoint != null)
                    hashCode = hashCode * 59 + this.FOBPoint.GetHashCode();
                if (this.Insurance != null)
                    hashCode = hashCode * 59 + this.Insurance.GetHashCode();
                if (this.LeadTimeInDays != null)
                    hashCode = hashCode * 59 + this.LeadTimeInDays.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.OrderPriority != null)
                    hashCode = hashCode * 59 + this.OrderPriority.GetHashCode();
                if (this.PriceClass != null)
                    hashCode = hashCode * 59 + this.PriceClass.GetHashCode();
                if (this.ResidentialDelivery != null)
                    hashCode = hashCode * 59 + this.ResidentialDelivery.GetHashCode();
                if (this.SaturdayDelivery != null)
                    hashCode = hashCode * 59 + this.SaturdayDelivery.GetHashCode();
                if (this.ShippingBranch != null)
                    hashCode = hashCode * 59 + this.ShippingBranch.GetHashCode();
                if (this.ShippingRule != null)
                    hashCode = hashCode * 59 + this.ShippingRule.GetHashCode();
                if (this.ShippingTerms != null)
                    hashCode = hashCode * 59 + this.ShippingTerms.GetHashCode();
                if (this.ShippingZone != null)
                    hashCode = hashCode * 59 + this.ShippingZone.GetHashCode();
                if (this.ShipVia != null)
                    hashCode = hashCode * 59 + this.ShipVia.GetHashCode();
                if (this.TaxRegistrationID != null)
                    hashCode = hashCode * 59 + this.TaxRegistrationID.GetHashCode();
                if (this.TaxZone != null)
                    hashCode = hashCode * 59 + this.TaxZone.GetHashCode();
                if (this.Warehouse != null)
                    hashCode = hashCode * 59 + this.Warehouse.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}