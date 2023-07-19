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
    /// PayInInstruction
    /// </summary>
    [DataContract]
    public partial class PayInInstruction :  IEquatable<PayInInstruction>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum REDIRECT for value: REDIRECT
            /// </summary>
            [EnumMember(Value = "REDIRECT")]
            REDIRECT = 1,

            /// <summary>
            /// Enum FORM for value: FORM
            /// </summary>
            [EnumMember(Value = "FORM")]
            FORM = 2,

            /// <summary>
            /// Enum DISPLAY for value: DISPLAY
            /// </summary>
            [EnumMember(Value = "DISPLAY")]
            DISPLAY = 3,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 4

        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayInInstruction" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="form">form.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        /// <param name="displayParameters">displayParameters.</param>
        public PayInInstruction(ActionEnum? action = default(ActionEnum?), Form form = default(Form), string redirectUrl = default(string), Object displayParameters = default(Object))
        {
            this.Action = action;
            this.Form = form;
            this.RedirectUrl = redirectUrl;
            this.DisplayParameters = displayParameters;
        }


        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public Form Form { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or Sets DisplayParameters
        /// </summary>
        [DataMember(Name="displayParameters", EmitDefaultValue=false)]
        public Object DisplayParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayInInstruction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  DisplayParameters: ").Append(DisplayParameters).Append("\n");
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
            return this.Equals(input as PayInInstruction);
        }

        /// <summary>
        /// Returns true if PayInInstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of PayInInstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayInInstruction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Form == input.Form ||
                    (this.Form != null &&
                    this.Form.Equals(input.Form))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.DisplayParameters == input.DisplayParameters ||
                    (this.DisplayParameters != null &&
                    this.DisplayParameters.Equals(input.DisplayParameters))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Form != null)
                    hashCode = hashCode * 59 + this.Form.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.DisplayParameters != null)
                    hashCode = hashCode * 59 + this.DisplayParameters.GetHashCode();
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
