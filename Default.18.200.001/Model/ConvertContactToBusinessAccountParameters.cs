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
    /// The parameters of the action.
    /// </summary>
    [DataContract]
    public partial class ConvertContactToBusinessAccountParameters :  IEquatable<ConvertContactToBusinessAccountParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertContactToBusinessAccountParameters" /> class.
        /// </summary>
        /// <param name="accountClass">accountClass.</param>
        /// <param name="bAccountID">bAccountID.</param>
        /// <param name="accountName">accountName.</param>
        public ConvertContactToBusinessAccountParameters(StringValue accountClass = default(StringValue), StringValue bAccountID = default(StringValue), StringValue accountName = default(StringValue))
        {
            this.AccountClass = accountClass;
            this.BAccountID = bAccountID;
            this.AccountName = accountName;
        }
        
        /// <summary>
        /// Gets or Sets AccountClass
        /// </summary>
        [DataMember(Name="AccountClass", EmitDefaultValue=false)]
        public StringValue AccountClass { get; set; }

        /// <summary>
        /// Gets or Sets BAccountID
        /// </summary>
        [DataMember(Name="BAccountID", EmitDefaultValue=false)]
        public StringValue BAccountID { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public StringValue AccountName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertContactToBusinessAccountParameters {\n");
            sb.Append("  AccountClass: ").Append(AccountClass).Append("\n");
            sb.Append("  BAccountID: ").Append(BAccountID).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ConvertContactToBusinessAccountParameters);
        }

        /// <summary>
        /// Returns true if ConvertContactToBusinessAccountParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertContactToBusinessAccountParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertContactToBusinessAccountParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountClass == input.AccountClass ||
                    (this.AccountClass != null &&
                    this.AccountClass.Equals(input.AccountClass))
                ) && 
                (
                    this.BAccountID == input.BAccountID ||
                    (this.BAccountID != null &&
                    this.BAccountID.Equals(input.BAccountID))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
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
                int hashCode = 41;
                if (this.AccountClass != null)
                    hashCode = hashCode * 59 + this.AccountClass.GetHashCode();
                if (this.BAccountID != null)
                    hashCode = hashCode * 59 + this.BAccountID.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
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
            yield break;
        }
    }

}