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
    /// Contains exchange rate information to convert from base currency to counter currency.
    /// </summary>
    [DataContract]
    public partial class ExchangeRateDto :  IEquatable<ExchangeRateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateDto" /> class.
        /// </summary>
        /// <param name="_base">The base currency acronym..</param>
        /// <param name="counter">The counter currency acronym..</param>
        /// <param name="rate">The exchange rate.</param>
        public ExchangeRateDto(string _base = default(string), string counter = default(string), decimal rate = default(decimal))
        {
            this.Base = _base;
            this.Counter = counter;
            this.Rate = rate;
        }

        /// <summary>
        /// The base currency acronym.
        /// </summary>
        /// <value>The base currency acronym.</value>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public string Base { get; set; }

        /// <summary>
        /// The counter currency acronym.
        /// </summary>
        /// <value>The counter currency acronym.</value>
        [DataMember(Name="counter", EmitDefaultValue=false)]
        public string Counter { get; set; }

        /// <summary>
        /// The exchange rate
        /// </summary>
        /// <value>The exchange rate</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public decimal Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeRateDto {\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as ExchangeRateDto);
        }

        /// <summary>
        /// Returns true if ExchangeRateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Base == input.Base ||
                    (this.Base != null &&
                    this.Base.Equals(input.Base))
                ) && 
                (
                    this.Counter == input.Counter ||
                    (this.Counter != null &&
                    this.Counter.Equals(input.Counter))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
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
                if (this.Base != null)
                    hashCode = hashCode * 59 + this.Base.GetHashCode();
                if (this.Counter != null)
                    hashCode = hashCode * 59 + this.Counter.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
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
