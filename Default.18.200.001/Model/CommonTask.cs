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
    /// CommonTask
    /// </summary>
    [DataContract]
    public partial class CommonTask : Entity,  IEquatable<CommonTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonTask" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="billingAndAllocationSettings">billingAndAllocationSettings.</param>
        /// <param name="commonTaskID">commonTaskID.</param>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="description">description.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="properties">properties.</param>
        /// <param name="visibilitySettings">visibilitySettings.</param>
        public CommonTask(List<AttributeValue> attributes = default(List<AttributeValue>), ProjectTaskBillingAndAllocationSettings billingAndAllocationSettings = default(ProjectTaskBillingAndAllocationSettings), StringValue commonTaskID = default(StringValue), ProjectTaskDefaultValues defaultValues = default(ProjectTaskDefaultValues), StringValue description = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), ProjectTaskProperties properties = default(ProjectTaskProperties), VisibilitySettings visibilitySettings = default(VisibilitySettings), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Attributes = attributes;
            this.BillingAndAllocationSettings = billingAndAllocationSettings;
            this.CommonTaskID = commonTaskID;
            this.DefaultValues = defaultValues;
            this.Description = description;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.Properties = properties;
            this.VisibilitySettings = visibilitySettings;
        }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="Attributes", EmitDefaultValue=false)]
        public List<AttributeValue> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets BillingAndAllocationSettings
        /// </summary>
        [DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
        public ProjectTaskBillingAndAllocationSettings BillingAndAllocationSettings { get; set; }

        /// <summary>
        /// Gets or Sets CommonTaskID
        /// </summary>
        [DataMember(Name="CommonTaskID", EmitDefaultValue=false)]
        public StringValue CommonTaskID { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name="DefaultValues", EmitDefaultValue=false)]
        public ProjectTaskDefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="Properties", EmitDefaultValue=false)]
        public ProjectTaskProperties Properties { get; set; }

        /// <summary>
        /// Gets or Sets VisibilitySettings
        /// </summary>
        [DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
        public VisibilitySettings VisibilitySettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonTask {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  BillingAndAllocationSettings: ").Append(BillingAndAllocationSettings).Append("\n");
            sb.Append("  CommonTaskID: ").Append(CommonTaskID).Append("\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  VisibilitySettings: ").Append(VisibilitySettings).Append("\n");
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
            return this.Equals(input as CommonTask);
        }

        /// <summary>
        /// Returns true if CommonTask instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonTask input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && base.Equals(input) && 
                (
                    this.BillingAndAllocationSettings == input.BillingAndAllocationSettings ||
                    (this.BillingAndAllocationSettings != null &&
                    this.BillingAndAllocationSettings.Equals(input.BillingAndAllocationSettings))
                ) && base.Equals(input) && 
                (
                    this.CommonTaskID == input.CommonTaskID ||
                    (this.CommonTaskID != null &&
                    this.CommonTaskID.Equals(input.CommonTaskID))
                ) && base.Equals(input) && 
                (
                    this.DefaultValues == input.DefaultValues ||
                    (this.DefaultValues != null &&
                    this.DefaultValues.Equals(input.DefaultValues))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && base.Equals(input) && 
                (
                    this.VisibilitySettings == input.VisibilitySettings ||
                    (this.VisibilitySettings != null &&
                    this.VisibilitySettings.Equals(input.VisibilitySettings))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.BillingAndAllocationSettings != null)
                    hashCode = hashCode * 59 + this.BillingAndAllocationSettings.GetHashCode();
                if (this.CommonTaskID != null)
                    hashCode = hashCode * 59 + this.CommonTaskID.GetHashCode();
                if (this.DefaultValues != null)
                    hashCode = hashCode * 59 + this.DefaultValues.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.VisibilitySettings != null)
                    hashCode = hashCode * 59 + this.VisibilitySettings.GetHashCode();
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