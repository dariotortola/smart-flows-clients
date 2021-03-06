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
    /// The content of the template when type is composed. Content of standard templates should be retrieved using the contentLink
    /// </summary>
    [DataContract]
    public partial class TemplateComposedContent :  IEquatable<TemplateComposedContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateComposedContent" /> class.
        /// </summary>
        /// <param name="Bodies">Bodies.</param>
        /// <param name="Headers">Headers.</param>
        /// <param name="Footers">Footers.</param>
        /// <param name="Additions">Additions.</param>
        public TemplateComposedContent(List<Part> Bodies = default(List<Part>), List<Part> Headers = default(List<Part>), List<Part> Footers = default(List<Part>), List<Part> Additions = default(List<Part>))
        {
            this.Bodies = Bodies;
            this.Headers = Headers;
            this.Footers = Footers;
            this.Additions = Additions;
        }
        
        /// <summary>
        /// Gets or Sets Bodies
        /// </summary>
        [DataMember(Name="bodies", EmitDefaultValue=false)]
        public List<Part> Bodies { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<Part> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Footers
        /// </summary>
        [DataMember(Name="footers", EmitDefaultValue=false)]
        public List<Part> Footers { get; set; }

        /// <summary>
        /// Gets or Sets Additions
        /// </summary>
        [DataMember(Name="additions", EmitDefaultValue=false)]
        public List<Part> Additions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateComposedContent {\n");
            sb.Append("  Bodies: ").Append(Bodies).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Footers: ").Append(Footers).Append("\n");
            sb.Append("  Additions: ").Append(Additions).Append("\n");
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
            return this.Equals(obj as TemplateComposedContent);
        }

        /// <summary>
        /// Returns true if TemplateComposedContent instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateComposedContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateComposedContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bodies == other.Bodies ||
                    this.Bodies != null &&
                    this.Bodies.SequenceEqual(other.Bodies)
                ) && 
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) && 
                (
                    this.Footers == other.Footers ||
                    this.Footers != null &&
                    this.Footers.SequenceEqual(other.Footers)
                ) && 
                (
                    this.Additions == other.Additions ||
                    this.Additions != null &&
                    this.Additions.SequenceEqual(other.Additions)
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
                if (this.Bodies != null)
                    hash = hash * 59 + this.Bodies.GetHashCode();
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                if (this.Footers != null)
                    hash = hash * 59 + this.Footers.GetHashCode();
                if (this.Additions != null)
                    hash = hash * 59 + this.Additions.GetHashCode();
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
