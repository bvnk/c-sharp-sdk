/*
 * BVNK API Endpoints
 *
 * The BVNK API is designed to facilitate seamless and secure transactions including payments, channels, and digital wallet transactions.
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
    /// PayOutMethodDto
    /// </summary>
    [DataContract]
    public partial class PayOutMethodDto :  IEquatable<PayOutMethodDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayOutMethodDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the pay out..</param>
        /// <param name="code">The code of the pay out..</param>
        /// <param name="currency">The currency of the pay out..</param>
        /// <param name="accountMethods">accountMethods.</param>
        public PayOutMethodDto(long id = default(long), string code = default(string), string currency = default(string), List<AccountMethodDto> accountMethods = default(List<AccountMethodDto>))
        {
            this.Id = id;
            this.Code = code;
            this.Currency = currency;
            this.AccountMethods = accountMethods;
        }

        /// <summary>
        /// The ID of the pay out.
        /// </summary>
        /// <value>The ID of the pay out.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// The code of the pay out.
        /// </summary>
        /// <value>The code of the pay out.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The currency of the pay out.
        /// </summary>
        /// <value>The currency of the pay out.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets AccountMethods
        /// </summary>
        [DataMember(Name="accountMethods", EmitDefaultValue=false)]
        public List<AccountMethodDto> AccountMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayOutMethodDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AccountMethods: ").Append(AccountMethods).Append("\n");
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
            return this.Equals(input as PayOutMethodDto);
        }

        /// <summary>
        /// Returns true if PayOutMethodDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PayOutMethodDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayOutMethodDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AccountMethods == input.AccountMethods ||
                    this.AccountMethods != null &&
                    input.AccountMethods != null &&
                    this.AccountMethods.SequenceEqual(input.AccountMethods)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.AccountMethods != null)
                    hashCode = hashCode * 59 + this.AccountMethods.GetHashCode();
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
