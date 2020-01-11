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
    /// ProFormaTaxDetail
    /// </summary>
    [DataContract]
    public partial class ProFormaTaxDetail : Entity,  IEquatable<ProFormaTaxDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProFormaTaxDetail" /> class.
        /// </summary>
        /// <param name="retainedTax">retainedTax.</param>
        /// <param name="retainedTaxable">retainedTaxable.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="taxID">taxID.</param>
        /// <param name="taxRate">taxRate.</param>
        public ProFormaTaxDetail(DecimalValue retainedTax = default(DecimalValue), DecimalValue retainedTaxable = default(DecimalValue), DecimalValue taxableAmount = default(DecimalValue), DecimalValue taxAmount = default(DecimalValue), StringValue taxID = default(StringValue), DecimalValue taxRate = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.RetainedTax = retainedTax;
            this.RetainedTaxable = retainedTaxable;
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.TaxID = taxID;
            this.TaxRate = taxRate;
        }
        
        /// <summary>
        /// Gets or Sets RetainedTax
        /// </summary>
        [DataMember(Name="RetainedTax", EmitDefaultValue=false)]
        public DecimalValue RetainedTax { get; set; }

        /// <summary>
        /// Gets or Sets RetainedTaxable
        /// </summary>
        [DataMember(Name="RetainedTaxable", EmitDefaultValue=false)]
        public DecimalValue RetainedTaxable { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
        public DecimalValue TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public DecimalValue TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxID
        /// </summary>
        [DataMember(Name="TaxID", EmitDefaultValue=false)]
        public StringValue TaxID { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="TaxRate", EmitDefaultValue=false)]
        public DecimalValue TaxRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProFormaTaxDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RetainedTax: ").Append(RetainedTax).Append("\n");
            sb.Append("  RetainedTaxable: ").Append(RetainedTaxable).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxID: ").Append(TaxID).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
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
            return this.Equals(input as ProFormaTaxDetail);
        }

        /// <summary>
        /// Returns true if ProFormaTaxDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ProFormaTaxDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProFormaTaxDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.RetainedTax == input.RetainedTax ||
                    (this.RetainedTax != null &&
                    this.RetainedTax.Equals(input.RetainedTax))
                ) && base.Equals(input) && 
                (
                    this.RetainedTaxable == input.RetainedTaxable ||
                    (this.RetainedTaxable != null &&
                    this.RetainedTaxable.Equals(input.RetainedTaxable))
                ) && base.Equals(input) && 
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
                ) && base.Equals(input) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && base.Equals(input) && 
                (
                    this.TaxID == input.TaxID ||
                    (this.TaxID != null &&
                    this.TaxID.Equals(input.TaxID))
                ) && base.Equals(input) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
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
                if (this.RetainedTax != null)
                    hashCode = hashCode * 59 + this.RetainedTax.GetHashCode();
                if (this.RetainedTaxable != null)
                    hashCode = hashCode * 59 + this.RetainedTaxable.GetHashCode();
                if (this.TaxableAmount != null)
                    hashCode = hashCode * 59 + this.TaxableAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxID != null)
                    hashCode = hashCode * 59 + this.TaxID.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
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