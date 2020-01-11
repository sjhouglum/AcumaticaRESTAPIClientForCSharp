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
    /// ManageFinancialPeriods
    /// </summary>
    [DataContract]
    public partial class ManageFinancialPeriods : Entity,  IEquatable<ManageFinancialPeriods>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageFinancialPeriods" /> class.
        /// </summary>
        /// <param name="actionToPerform">actionToPerform.</param>
        /// <param name="company">company.</param>
        /// <param name="details">details.</param>
        /// <param name="fromYear">fromYear.</param>
        /// <param name="reopenFinancialPeriodsinAllModules">reopenFinancialPeriodsinAllModules.</param>
        /// <param name="toYear">toYear.</param>
        public ManageFinancialPeriods(StringValue actionToPerform = default(StringValue), StringValue company = default(StringValue), List<ManageFinancialPeriodsDetail> details = default(List<ManageFinancialPeriodsDetail>), StringValue fromYear = default(StringValue), BooleanValue reopenFinancialPeriodsinAllModules = default(BooleanValue), StringValue toYear = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ActionToPerform = actionToPerform;
            this.Company = company;
            this.Details = details;
            this.FromYear = fromYear;
            this.ReopenFinancialPeriodsinAllModules = reopenFinancialPeriodsinAllModules;
            this.ToYear = toYear;
        }
        
        /// <summary>
        /// Gets or Sets ActionToPerform
        /// </summary>
        [DataMember(Name="ActionToPerform", EmitDefaultValue=false)]
        public StringValue ActionToPerform { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public StringValue Company { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<ManageFinancialPeriodsDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets FromYear
        /// </summary>
        [DataMember(Name="FromYear", EmitDefaultValue=false)]
        public StringValue FromYear { get; set; }

        /// <summary>
        /// Gets or Sets ReopenFinancialPeriodsinAllModules
        /// </summary>
        [DataMember(Name="ReopenFinancialPeriodsinAllModules", EmitDefaultValue=false)]
        public BooleanValue ReopenFinancialPeriodsinAllModules { get; set; }

        /// <summary>
        /// Gets or Sets ToYear
        /// </summary>
        [DataMember(Name="ToYear", EmitDefaultValue=false)]
        public StringValue ToYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManageFinancialPeriods {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActionToPerform: ").Append(ActionToPerform).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  FromYear: ").Append(FromYear).Append("\n");
            sb.Append("  ReopenFinancialPeriodsinAllModules: ").Append(ReopenFinancialPeriodsinAllModules).Append("\n");
            sb.Append("  ToYear: ").Append(ToYear).Append("\n");
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
            return this.Equals(input as ManageFinancialPeriods);
        }

        /// <summary>
        /// Returns true if ManageFinancialPeriods instances are equal
        /// </summary>
        /// <param name="input">Instance of ManageFinancialPeriods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManageFinancialPeriods input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ActionToPerform == input.ActionToPerform ||
                    (this.ActionToPerform != null &&
                    this.ActionToPerform.Equals(input.ActionToPerform))
                ) && base.Equals(input) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && base.Equals(input) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) && 
                (
                    this.FromYear == input.FromYear ||
                    (this.FromYear != null &&
                    this.FromYear.Equals(input.FromYear))
                ) && base.Equals(input) && 
                (
                    this.ReopenFinancialPeriodsinAllModules == input.ReopenFinancialPeriodsinAllModules ||
                    (this.ReopenFinancialPeriodsinAllModules != null &&
                    this.ReopenFinancialPeriodsinAllModules.Equals(input.ReopenFinancialPeriodsinAllModules))
                ) && base.Equals(input) && 
                (
                    this.ToYear == input.ToYear ||
                    (this.ToYear != null &&
                    this.ToYear.Equals(input.ToYear))
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
                if (this.ActionToPerform != null)
                    hashCode = hashCode * 59 + this.ActionToPerform.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.FromYear != null)
                    hashCode = hashCode * 59 + this.FromYear.GetHashCode();
                if (this.ReopenFinancialPeriodsinAllModules != null)
                    hashCode = hashCode * 59 + this.ReopenFinancialPeriodsinAllModules.GetHashCode();
                if (this.ToYear != null)
                    hashCode = hashCode * 59 + this.ToYear.GetHashCode();
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