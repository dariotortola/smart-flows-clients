/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// StandardTemplateDefinition
    /// </summary>
    [DataContract]
    public partial class StandardTemplateDefinition : IEquatable<StandardTemplateDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardTemplateDefinition" /> class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="Datasets">Datasets.</param>
        /// <param name="Schemas">Schemas.</param>
        public StandardTemplateDefinition(byte[] Content = default(byte[]), List<string> Datasets = default(List<string>), List<SchemaContent> Schemas = default(List<SchemaContent>))
        {
            this.Content = Content;
            this.Datasets = Datasets;
            this.Schemas = Schemas;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public byte[] Content { get; set; }
        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name = "datasets", EmitDefaultValue = false)]
        public List<string> Datasets { get; set; }
        /// <summary>
        /// Gets or Sets Schemas
        /// </summary>
        [DataMember(Name = "schemas", EmitDefaultValue = false)]
        public List<SchemaContent> Schemas { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardTemplateDefinition {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
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
            return this.Equals(obj as StandardTemplateDefinition);
        }

        /// <summary>
        /// Returns true if StandardTemplateDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of StandardTemplateDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardTemplateDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.Datasets == other.Datasets ||
                    this.Datasets != null &&
                    this.Datasets.SequenceEqual(other.Datasets)
                ) &&
                (
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.Datasets != null)
                    hash = hash * 59 + this.Datasets.GetHashCode();
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
