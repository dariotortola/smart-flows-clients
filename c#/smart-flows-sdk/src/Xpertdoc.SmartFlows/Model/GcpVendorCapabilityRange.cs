/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// GcpVendorCapabilityRange
    /// </summary>
    [DataContract]
    public partial class GcpVendorCapabilityRange :  IEquatable<GcpVendorCapabilityRange>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            [EnumMember(Value = "float")]
            Float = 1,
            
            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpVendorCapabilityRange" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="_Default">_Default.</param>
        /// <param name="Min">Min.</param>
        /// <param name="Max">Max.</param>
        public GcpVendorCapabilityRange(TypeEnum? Type = default(TypeEnum?), string _Default = default(string), string Min = default(string), string Max = default(string))
        {
            this.Type = Type;
            this._Default = _Default;
            this.Min = Min;
            this.Max = Max;
        }
        

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public string _Default { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public string Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public string Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcpVendorCapabilityRange {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GcpVendorCapabilityRange);
        }

        /// <summary>
        /// Returns true if GcpVendorCapabilityRange instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpVendorCapabilityRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpVendorCapabilityRange input)
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
                    this._Default == input._Default ||
                    (this._Default != null &&
                    this._Default.Equals(input._Default))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
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
                if (this._Default != null)
                    hashCode = hashCode * 59 + this._Default.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
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