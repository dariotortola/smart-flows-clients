/* 
 * Xpertdoc SmartFlows
 *
 * This describes the REST api for one Xpertdoc SmartFlows project
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Client.Model
{
    /// <summary>
    /// GcpPrintProps
    /// </summary>
    [DataContract]
    public partial class GcpPrintProps :  IEquatable<GcpPrintProps>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Duplexing
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DuplexingEnum
        {
            
            /// <summary>
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum NoDuplex for "noDuplex"
            /// </summary>
            [EnumMember(Value = "noDuplex")]
            NoDuplex,
            
            /// <summary>
            /// Enum LongEdge for "longEdge"
            /// </summary>
            [EnumMember(Value = "longEdge")]
            LongEdge,
            
            /// <summary>
            /// Enum ShortEdge for "shortEdge"
            /// </summary>
            [EnumMember(Value = "shortEdge")]
            ShortEdge
        }

        /// <summary>
        /// Gets or Sets Collate
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CollateEnum
        {
            
            /// <summary>
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum True for "true"
            /// </summary>
            [EnumMember(Value = "true")]
            True,
            
            /// <summary>
            /// Enum False for "false"
            /// </summary>
            [EnumMember(Value = "false")]
            False
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            
            /// <summary>
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum Auto for "auto"
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto,
            
            /// <summary>
            /// Enum StandardColor for "standardColor"
            /// </summary>
            [EnumMember(Value = "standardColor")]
            StandardColor,
            
            /// <summary>
            /// Enum StandardMonochrome for "standardMonochrome"
            /// </summary>
            [EnumMember(Value = "standardMonochrome")]
            StandardMonochrome,
            
            /// <summary>
            /// Enum CustomColor for "customColor"
            /// </summary>
            [EnumMember(Value = "customColor")]
            CustomColor,
            
            /// <summary>
            /// Enum CustomMonochrome for "customMonochrome"
            /// </summary>
            [EnumMember(Value = "customMonochrome")]
            CustomMonochrome
        }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum Auto for "auto"
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto,
            
            /// <summary>
            /// Enum Portrait for "portrait"
            /// </summary>
            [EnumMember(Value = "portrait")]
            Portrait,
            
            /// <summary>
            /// Enum Landscape for "landscape"
            /// </summary>
            [EnumMember(Value = "landscape")]
            Landscape
        }

        /// <summary>
        /// Gets or Sets Duplexing
        /// </summary>
        [DataMember(Name="duplexing", EmitDefaultValue=false)]
        public DuplexingEnum? Duplexing { get; set; }
        /// <summary>
        /// Gets or Sets Collate
        /// </summary>
        [DataMember(Name="collate", EmitDefaultValue=false)]
        public CollateEnum? Collate { get; set; }
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public OrientationEnum? Orientation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpPrintProps" /> class.
        /// </summary>
        /// <param name="Duplexing">Duplexing.</param>
        /// <param name="Collate">Collate.</param>
        /// <param name="Color">Color.</param>
        /// <param name="Orientation">Orientation.</param>
        /// <param name="VendorCapabilities">VendorCapabilities.</param>
        public GcpPrintProps(DuplexingEnum? Duplexing = default(DuplexingEnum?), CollateEnum? Collate = default(CollateEnum?), ColorEnum? Color = default(ColorEnum?), OrientationEnum? Orientation = default(OrientationEnum?), List<Dictionary<string, string>> VendorCapabilities = default(List<Dictionary<string, string>>))
        {
            this.Duplexing = Duplexing;
            this.Collate = Collate;
            this.Color = Color;
            this.Orientation = Orientation;
            this.VendorCapabilities = VendorCapabilities;
        }
        




        /// <summary>
        /// Gets or Sets VendorCapabilities
        /// </summary>
        [DataMember(Name="vendorCapabilities", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> VendorCapabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcpPrintProps {\n");
            sb.Append("  Duplexing: ").Append(Duplexing).Append("\n");
            sb.Append("  Collate: ").Append(Collate).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  VendorCapabilities: ").Append(VendorCapabilities).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GcpPrintProps);
        }

        /// <summary>
        /// Returns true if GcpPrintProps instances are equal
        /// </summary>
        /// <param name="other">Instance of GcpPrintProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpPrintProps other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Duplexing == other.Duplexing ||
                    this.Duplexing != null &&
                    this.Duplexing.Equals(other.Duplexing)
                ) && 
                (
                    this.Collate == other.Collate ||
                    this.Collate != null &&
                    this.Collate.Equals(other.Collate)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Orientation == other.Orientation ||
                    this.Orientation != null &&
                    this.Orientation.Equals(other.Orientation)
                ) && 
                (
                    this.VendorCapabilities == other.VendorCapabilities ||
                    this.VendorCapabilities != null &&
                    this.VendorCapabilities.SequenceEqual(other.VendorCapabilities)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Duplexing != null)
                    hash = hash * 59 + this.Duplexing.GetHashCode();
                if (this.Collate != null)
                    hash = hash * 59 + this.Collate.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Orientation != null)
                    hash = hash * 59 + this.Orientation.GetHashCode();
                if (this.VendorCapabilities != null)
                    hash = hash * 59 + this.VendorCapabilities.GetHashCode();
                return hash;
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