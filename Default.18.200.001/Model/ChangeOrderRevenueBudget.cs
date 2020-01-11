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
    /// ChangeOrderRevenueBudget
    /// </summary>
    [DataContract]
    public partial class ChangeOrderRevenueBudget : Entity,  IEquatable<ChangeOrderRevenueBudget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOrderRevenueBudget" /> class.
        /// </summary>
        /// <param name="accountGroup">accountGroup.</param>
        /// <param name="actualAmount">actualAmount.</param>
        /// <param name="actualQty">actualQty.</param>
        /// <param name="amount">amount.</param>
        /// <param name="completed">completed.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="description">description.</param>
        /// <param name="draftInvoicesAmount">draftInvoicesAmount.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="originalBudgetedAmount">originalBudgetedAmount.</param>
        /// <param name="originalBudgetedQty">originalBudgetedQty.</param>
        /// <param name="otherDraftCOAmount">otherDraftCOAmount.</param>
        /// <param name="previouslyApprovedCOAmount">previouslyApprovedCOAmount.</param>
        /// <param name="previouslyApprovedCOQty">previouslyApprovedCOQty.</param>
        /// <param name="projectTaskID">projectTaskID.</param>
        /// <param name="qty">qty.</param>
        /// <param name="revisedBudgetedAmount">revisedBudgetedAmount.</param>
        /// <param name="revisedBudgetedQty">revisedBudgetedQty.</param>
        /// <param name="totalPotentiallyRevisedAmount">totalPotentiallyRevisedAmount.</param>
        /// <param name="unitRate">unitRate.</param>
        /// <param name="uOM">uOM.</param>
        public ChangeOrderRevenueBudget(StringValue accountGroup = default(StringValue), DecimalValue actualAmount = default(DecimalValue), DecimalValue actualQty = default(DecimalValue), DecimalValue amount = default(DecimalValue), DecimalValue completed = default(DecimalValue), StringValue costCode = default(StringValue), StringValue description = default(StringValue), DecimalValue draftInvoicesAmount = default(DecimalValue), StringValue inventoryID = default(StringValue), DecimalValue originalBudgetedAmount = default(DecimalValue), DecimalValue originalBudgetedQty = default(DecimalValue), DecimalValue otherDraftCOAmount = default(DecimalValue), DecimalValue previouslyApprovedCOAmount = default(DecimalValue), DecimalValue previouslyApprovedCOQty = default(DecimalValue), StringValue projectTaskID = default(StringValue), DecimalValue qty = default(DecimalValue), DecimalValue revisedBudgetedAmount = default(DecimalValue), DecimalValue revisedBudgetedQty = default(DecimalValue), DecimalValue totalPotentiallyRevisedAmount = default(DecimalValue), DecimalValue unitRate = default(DecimalValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AccountGroup = accountGroup;
            this.ActualAmount = actualAmount;
            this.ActualQty = actualQty;
            this.Amount = amount;
            this.Completed = completed;
            this.CostCode = costCode;
            this.Description = description;
            this.DraftInvoicesAmount = draftInvoicesAmount;
            this.InventoryID = inventoryID;
            this.OriginalBudgetedAmount = originalBudgetedAmount;
            this.OriginalBudgetedQty = originalBudgetedQty;
            this.OtherDraftCOAmount = otherDraftCOAmount;
            this.PreviouslyApprovedCOAmount = previouslyApprovedCOAmount;
            this.PreviouslyApprovedCOQty = previouslyApprovedCOQty;
            this.ProjectTaskID = projectTaskID;
            this.Qty = qty;
            this.RevisedBudgetedAmount = revisedBudgetedAmount;
            this.RevisedBudgetedQty = revisedBudgetedQty;
            this.TotalPotentiallyRevisedAmount = totalPotentiallyRevisedAmount;
            this.UnitRate = unitRate;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets AccountGroup
        /// </summary>
        [DataMember(Name="AccountGroup", EmitDefaultValue=false)]
        public StringValue AccountGroup { get; set; }

        /// <summary>
        /// Gets or Sets ActualAmount
        /// </summary>
        [DataMember(Name="ActualAmount", EmitDefaultValue=false)]
        public DecimalValue ActualAmount { get; set; }

        /// <summary>
        /// Gets or Sets ActualQty
        /// </summary>
        [DataMember(Name="ActualQty", EmitDefaultValue=false)]
        public DecimalValue ActualQty { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="Completed", EmitDefaultValue=false)]
        public DecimalValue Completed { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets DraftInvoicesAmount
        /// </summary>
        [DataMember(Name="DraftInvoicesAmount", EmitDefaultValue=false)]
        public DecimalValue DraftInvoicesAmount { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets OriginalBudgetedAmount
        /// </summary>
        [DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
        public DecimalValue OriginalBudgetedAmount { get; set; }

        /// <summary>
        /// Gets or Sets OriginalBudgetedQty
        /// </summary>
        [DataMember(Name="OriginalBudgetedQty", EmitDefaultValue=false)]
        public DecimalValue OriginalBudgetedQty { get; set; }

        /// <summary>
        /// Gets or Sets OtherDraftCOAmount
        /// </summary>
        [DataMember(Name="OtherDraftCOAmount", EmitDefaultValue=false)]
        public DecimalValue OtherDraftCOAmount { get; set; }

        /// <summary>
        /// Gets or Sets PreviouslyApprovedCOAmount
        /// </summary>
        [DataMember(Name="PreviouslyApprovedCOAmount", EmitDefaultValue=false)]
        public DecimalValue PreviouslyApprovedCOAmount { get; set; }

        /// <summary>
        /// Gets or Sets PreviouslyApprovedCOQty
        /// </summary>
        [DataMember(Name="PreviouslyApprovedCOQty", EmitDefaultValue=false)]
        public DecimalValue PreviouslyApprovedCOQty { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTaskID
        /// </summary>
        [DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
        public StringValue ProjectTaskID { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets RevisedBudgetedAmount
        /// </summary>
        [DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
        public DecimalValue RevisedBudgetedAmount { get; set; }

        /// <summary>
        /// Gets or Sets RevisedBudgetedQty
        /// </summary>
        [DataMember(Name="RevisedBudgetedQty", EmitDefaultValue=false)]
        public DecimalValue RevisedBudgetedQty { get; set; }

        /// <summary>
        /// Gets or Sets TotalPotentiallyRevisedAmount
        /// </summary>
        [DataMember(Name="TotalPotentiallyRevisedAmount", EmitDefaultValue=false)]
        public DecimalValue TotalPotentiallyRevisedAmount { get; set; }

        /// <summary>
        /// Gets or Sets UnitRate
        /// </summary>
        [DataMember(Name="UnitRate", EmitDefaultValue=false)]
        public DecimalValue UnitRate { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeOrderRevenueBudget {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
            sb.Append("  ActualAmount: ").Append(ActualAmount).Append("\n");
            sb.Append("  ActualQty: ").Append(ActualQty).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DraftInvoicesAmount: ").Append(DraftInvoicesAmount).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  OriginalBudgetedAmount: ").Append(OriginalBudgetedAmount).Append("\n");
            sb.Append("  OriginalBudgetedQty: ").Append(OriginalBudgetedQty).Append("\n");
            sb.Append("  OtherDraftCOAmount: ").Append(OtherDraftCOAmount).Append("\n");
            sb.Append("  PreviouslyApprovedCOAmount: ").Append(PreviouslyApprovedCOAmount).Append("\n");
            sb.Append("  PreviouslyApprovedCOQty: ").Append(PreviouslyApprovedCOQty).Append("\n");
            sb.Append("  ProjectTaskID: ").Append(ProjectTaskID).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  RevisedBudgetedAmount: ").Append(RevisedBudgetedAmount).Append("\n");
            sb.Append("  RevisedBudgetedQty: ").Append(RevisedBudgetedQty).Append("\n");
            sb.Append("  TotalPotentiallyRevisedAmount: ").Append(TotalPotentiallyRevisedAmount).Append("\n");
            sb.Append("  UnitRate: ").Append(UnitRate).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as ChangeOrderRevenueBudget);
        }

        /// <summary>
        /// Returns true if ChangeOrderRevenueBudget instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeOrderRevenueBudget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeOrderRevenueBudget input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AccountGroup == input.AccountGroup ||
                    (this.AccountGroup != null &&
                    this.AccountGroup.Equals(input.AccountGroup))
                ) && base.Equals(input) && 
                (
                    this.ActualAmount == input.ActualAmount ||
                    (this.ActualAmount != null &&
                    this.ActualAmount.Equals(input.ActualAmount))
                ) && base.Equals(input) && 
                (
                    this.ActualQty == input.ActualQty ||
                    (this.ActualQty != null &&
                    this.ActualQty.Equals(input.ActualQty))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.DraftInvoicesAmount == input.DraftInvoicesAmount ||
                    (this.DraftInvoicesAmount != null &&
                    this.DraftInvoicesAmount.Equals(input.DraftInvoicesAmount))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.OriginalBudgetedAmount == input.OriginalBudgetedAmount ||
                    (this.OriginalBudgetedAmount != null &&
                    this.OriginalBudgetedAmount.Equals(input.OriginalBudgetedAmount))
                ) && base.Equals(input) && 
                (
                    this.OriginalBudgetedQty == input.OriginalBudgetedQty ||
                    (this.OriginalBudgetedQty != null &&
                    this.OriginalBudgetedQty.Equals(input.OriginalBudgetedQty))
                ) && base.Equals(input) && 
                (
                    this.OtherDraftCOAmount == input.OtherDraftCOAmount ||
                    (this.OtherDraftCOAmount != null &&
                    this.OtherDraftCOAmount.Equals(input.OtherDraftCOAmount))
                ) && base.Equals(input) && 
                (
                    this.PreviouslyApprovedCOAmount == input.PreviouslyApprovedCOAmount ||
                    (this.PreviouslyApprovedCOAmount != null &&
                    this.PreviouslyApprovedCOAmount.Equals(input.PreviouslyApprovedCOAmount))
                ) && base.Equals(input) && 
                (
                    this.PreviouslyApprovedCOQty == input.PreviouslyApprovedCOQty ||
                    (this.PreviouslyApprovedCOQty != null &&
                    this.PreviouslyApprovedCOQty.Equals(input.PreviouslyApprovedCOQty))
                ) && base.Equals(input) && 
                (
                    this.ProjectTaskID == input.ProjectTaskID ||
                    (this.ProjectTaskID != null &&
                    this.ProjectTaskID.Equals(input.ProjectTaskID))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.RevisedBudgetedAmount == input.RevisedBudgetedAmount ||
                    (this.RevisedBudgetedAmount != null &&
                    this.RevisedBudgetedAmount.Equals(input.RevisedBudgetedAmount))
                ) && base.Equals(input) && 
                (
                    this.RevisedBudgetedQty == input.RevisedBudgetedQty ||
                    (this.RevisedBudgetedQty != null &&
                    this.RevisedBudgetedQty.Equals(input.RevisedBudgetedQty))
                ) && base.Equals(input) && 
                (
                    this.TotalPotentiallyRevisedAmount == input.TotalPotentiallyRevisedAmount ||
                    (this.TotalPotentiallyRevisedAmount != null &&
                    this.TotalPotentiallyRevisedAmount.Equals(input.TotalPotentiallyRevisedAmount))
                ) && base.Equals(input) && 
                (
                    this.UnitRate == input.UnitRate ||
                    (this.UnitRate != null &&
                    this.UnitRate.Equals(input.UnitRate))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.AccountGroup != null)
                    hashCode = hashCode * 59 + this.AccountGroup.GetHashCode();
                if (this.ActualAmount != null)
                    hashCode = hashCode * 59 + this.ActualAmount.GetHashCode();
                if (this.ActualQty != null)
                    hashCode = hashCode * 59 + this.ActualQty.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DraftInvoicesAmount != null)
                    hashCode = hashCode * 59 + this.DraftInvoicesAmount.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.OriginalBudgetedAmount != null)
                    hashCode = hashCode * 59 + this.OriginalBudgetedAmount.GetHashCode();
                if (this.OriginalBudgetedQty != null)
                    hashCode = hashCode * 59 + this.OriginalBudgetedQty.GetHashCode();
                if (this.OtherDraftCOAmount != null)
                    hashCode = hashCode * 59 + this.OtherDraftCOAmount.GetHashCode();
                if (this.PreviouslyApprovedCOAmount != null)
                    hashCode = hashCode * 59 + this.PreviouslyApprovedCOAmount.GetHashCode();
                if (this.PreviouslyApprovedCOQty != null)
                    hashCode = hashCode * 59 + this.PreviouslyApprovedCOQty.GetHashCode();
                if (this.ProjectTaskID != null)
                    hashCode = hashCode * 59 + this.ProjectTaskID.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.RevisedBudgetedAmount != null)
                    hashCode = hashCode * 59 + this.RevisedBudgetedAmount.GetHashCode();
                if (this.RevisedBudgetedQty != null)
                    hashCode = hashCode * 59 + this.RevisedBudgetedQty.GetHashCode();
                if (this.TotalPotentiallyRevisedAmount != null)
                    hashCode = hashCode * 59 + this.TotalPotentiallyRevisedAmount.GetHashCode();
                if (this.UnitRate != null)
                    hashCode = hashCode * 59 + this.UnitRate.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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