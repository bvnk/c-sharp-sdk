/*
 * BVNK API Endpoints
 *
 * The BVNK API is designed to facilitate seamless and secure transactions including payments, channels, anddigital wallet transactions.
 *
 * The version of the OpenAPI document: 1.0.1
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TransactionReportRequestData
    /// </summary>
    [DataContract]
    public partial class TransactionReportRequestData :  IEquatable<TransactionReportRequestData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionReportRequestData" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="externalProcessing">externalProcessing.</param>
        /// <param name="walletId">walletId.</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="fromDate">fromDate.</param>
        /// <param name="toDate">toDate.</param>
        /// <param name="format">format.</param>
        /// <param name="languageTag">languageTag.</param>
        /// <param name="category">category.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="include">include.</param>
        /// <param name="exclude">exclude.</param>
        public TransactionReportRequestData(string type = default(string), string externalProcessing = default(string), long walletId = default(long), string transactionType = default(string), string fromDate = default(string), string toDate = default(string), string format = default(string), string languageTag = default(string), int category = default(int), string accountName = default(string), string include = default(string), string exclude = default(string))
        {
            this.Type = type;
            this.ExternalProcessing = externalProcessing;
            this.WalletId = walletId;
            this.TransactionType = transactionType;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Format = format;
            this.LanguageTag = languageTag;
            this.Category = category;
            this.AccountName = accountName;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ExternalProcessing
        /// </summary>
        [DataMember(Name="externalProcessing", EmitDefaultValue=false)]
        public string ExternalProcessing { get; set; }

        /// <summary>
        /// Gets or Sets WalletId
        /// </summary>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public long WalletId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name="transactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets FromDate
        /// </summary>
        [DataMember(Name="fromDate", EmitDefaultValue=false)]
        public string FromDate { get; set; }

        /// <summary>
        /// Gets or Sets ToDate
        /// </summary>
        [DataMember(Name="toDate", EmitDefaultValue=false)]
        public string ToDate { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets LanguageTag
        /// </summary>
        [DataMember(Name="languageTag", EmitDefaultValue=false)]
        public string LanguageTag { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public int Category { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public string Include { get; set; }

        /// <summary>
        /// Gets or Sets Exclude
        /// </summary>
        [DataMember(Name="exclude", EmitDefaultValue=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionReportRequestData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExternalProcessing: ").Append(ExternalProcessing).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  LanguageTag: ").Append(LanguageTag).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionReportRequestData);
        }

        /// <summary>
        /// Returns true if TransactionReportRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionReportRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionReportRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ExternalProcessing == input.ExternalProcessing ||
                    (this.ExternalProcessing != null &&
                    this.ExternalProcessing.Equals(input.ExternalProcessing))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.LanguageTag == input.LanguageTag ||
                    (this.LanguageTag != null &&
                    this.LanguageTag.Equals(input.LanguageTag))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
                ) && 
                (
                    this.Exclude == input.Exclude ||
                    (this.Exclude != null &&
                    this.Exclude.Equals(input.Exclude))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExternalProcessing != null)
                    hashCode = hashCode * 59 + this.ExternalProcessing.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.FromDate != null)
                    hashCode = hashCode * 59 + this.FromDate.GetHashCode();
                if (this.ToDate != null)
                    hashCode = hashCode * 59 + this.ToDate.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.LanguageTag != null)
                    hashCode = hashCode * 59 + this.LanguageTag.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Include != null)
                    hashCode = hashCode * 59 + this.Include.GetHashCode();
                if (this.Exclude != null)
                    hashCode = hashCode * 59 + this.Exclude.GetHashCode();
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
