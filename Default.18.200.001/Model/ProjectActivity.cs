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
    /// ProjectActivity
    /// </summary>
    [DataContract]
    public partial class ProjectActivity : Entity,  IEquatable<ProjectActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectActivity" /> class.
        /// </summary>
        /// <param name="billable">billable.</param>
        /// <param name="billableOvertime">billableOvertime.</param>
        /// <param name="billableTime">billableTime.</param>
        /// <param name="category">category.</param>
        /// <param name="overtime">overtime.</param>
        /// <param name="owner">owner.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="summary">summary.</param>
        /// <param name="timeSpent">timeSpent.</param>
        /// <param name="type">type.</param>
        /// <param name="workgroup">workgroup.</param>
        public ProjectActivity(BooleanValue billable = default(BooleanValue), StringValue billableOvertime = default(StringValue), StringValue billableTime = default(StringValue), StringValue category = default(StringValue), StringValue overtime = default(StringValue), StringValue owner = default(StringValue), DateTimeValue startDate = default(DateTimeValue), StringValue status = default(StringValue), StringValue summary = default(StringValue), StringValue timeSpent = default(StringValue), StringValue type = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Billable = billable;
            this.BillableOvertime = billableOvertime;
            this.BillableTime = billableTime;
            this.Category = category;
            this.Overtime = overtime;
            this.Owner = owner;
            this.StartDate = startDate;
            this.Status = status;
            this.Summary = summary;
            this.TimeSpent = timeSpent;
            this.Type = type;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Gets or Sets Billable
        /// </summary>
        [DataMember(Name="Billable", EmitDefaultValue=false)]
        public BooleanValue Billable { get; set; }

        /// <summary>
        /// Gets or Sets BillableOvertime
        /// </summary>
        [DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
        public StringValue BillableOvertime { get; set; }

        /// <summary>
        /// Gets or Sets BillableTime
        /// </summary>
        [DataMember(Name="BillableTime", EmitDefaultValue=false)]
        public StringValue BillableTime { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public StringValue Category { get; set; }

        /// <summary>
        /// Gets or Sets Overtime
        /// </summary>
        [DataMember(Name="Overtime", EmitDefaultValue=false)]
        public StringValue Overtime { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTimeValue StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="Summary", EmitDefaultValue=false)]
        public StringValue Summary { get; set; }

        /// <summary>
        /// Gets or Sets TimeSpent
        /// </summary>
        [DataMember(Name="TimeSpent", EmitDefaultValue=false)]
        public StringValue TimeSpent { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets Workgroup
        /// </summary>
        [DataMember(Name="Workgroup", EmitDefaultValue=false)]
        public StringValue Workgroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectActivity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  BillableOvertime: ").Append(BillableOvertime).Append("\n");
            sb.Append("  BillableTime: ").Append(BillableTime).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Overtime: ").Append(Overtime).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  TimeSpent: ").Append(TimeSpent).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Workgroup: ").Append(Workgroup).Append("\n");
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
            return this.Equals(input as ProjectActivity);
        }

        /// <summary>
        /// Returns true if ProjectActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectActivity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && base.Equals(input) && 
                (
                    this.BillableOvertime == input.BillableOvertime ||
                    (this.BillableOvertime != null &&
                    this.BillableOvertime.Equals(input.BillableOvertime))
                ) && base.Equals(input) && 
                (
                    this.BillableTime == input.BillableTime ||
                    (this.BillableTime != null &&
                    this.BillableTime.Equals(input.BillableTime))
                ) && base.Equals(input) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && base.Equals(input) && 
                (
                    this.Overtime == input.Overtime ||
                    (this.Overtime != null &&
                    this.Overtime.Equals(input.Overtime))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && base.Equals(input) && 
                (
                    this.TimeSpent == input.TimeSpent ||
                    (this.TimeSpent != null &&
                    this.TimeSpent.Equals(input.TimeSpent))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Workgroup == input.Workgroup ||
                    (this.Workgroup != null &&
                    this.Workgroup.Equals(input.Workgroup))
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
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.BillableOvertime != null)
                    hashCode = hashCode * 59 + this.BillableOvertime.GetHashCode();
                if (this.BillableTime != null)
                    hashCode = hashCode * 59 + this.BillableTime.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Overtime != null)
                    hashCode = hashCode * 59 + this.Overtime.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.TimeSpent != null)
                    hashCode = hashCode * 59 + this.TimeSpent.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Workgroup != null)
                    hashCode = hashCode * 59 + this.Workgroup.GetHashCode();
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