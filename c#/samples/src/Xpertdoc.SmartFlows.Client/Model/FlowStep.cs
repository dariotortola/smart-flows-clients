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
    /// FlowStep
    /// </summary>
    [DataContract]
    public partial class FlowStep :  IEquatable<FlowStep>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Data for "data"
            /// </summary>
            [EnumMember(Value = "data")]
            Data,
            
            /// <summary>
            /// Enum Gendoc for "gendoc"
            /// </summary>
            [EnumMember(Value = "gendoc")]
            Gendoc,
            
            /// <summary>
            /// Enum Convert for "convert"
            /// </summary>
            [EnumMember(Value = "convert")]
            Convert,
            
            /// <summary>
            /// Enum Postprocess for "postprocess"
            /// </summary>
            [EnumMember(Value = "postprocess")]
            Postprocess
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowStep" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowStep() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowStep" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="IconClass">IconClass.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Type">Type.</param>
        /// <param name="PrimaryParameters">PrimaryParameters.</param>
        /// <param name="InputSchema">InputSchema.</param>
        /// <param name="InputForm">InputForm.</param>
        /// <param name="OutputId">OutputId.</param>
        /// <param name="ExternalOutputParameters">ExternalOutputParameters.</param>
        /// <param name="OutputSchema">OutputSchema.</param>
        public FlowStep(string Id = default(string), string DisplayName = default(string), string Description = default(string), string IconClass = default(string), string Group = default(string), TypeEnum? Type = default(TypeEnum?), List<string> PrimaryParameters = default(List<string>), Object InputSchema = default(Object), List<Object> InputForm = default(List<Object>), string OutputId = default(string), List<string> ExternalOutputParameters = default(List<string>), Object OutputSchema = default(Object))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for FlowStep and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for FlowStep and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            this.Description = Description;
            this.IconClass = IconClass;
            this.Group = Group;
            this.Type = Type;
            this.PrimaryParameters = PrimaryParameters;
            this.InputSchema = InputSchema;
            this.InputForm = InputForm;
            this.OutputId = OutputId;
            this.ExternalOutputParameters = ExternalOutputParameters;
            this.OutputSchema = OutputSchema;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IconClass
        /// </summary>
        [DataMember(Name="iconClass", EmitDefaultValue=false)]
        public string IconClass { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }


        /// <summary>
        /// Gets or Sets PrimaryParameters
        /// </summary>
        [DataMember(Name="primaryParameters", EmitDefaultValue=false)]
        public List<string> PrimaryParameters { get; set; }

        /// <summary>
        /// Gets or Sets InputSchema
        /// </summary>
        [DataMember(Name="inputSchema", EmitDefaultValue=false)]
        public Object InputSchema { get; set; }

        /// <summary>
        /// Gets or Sets InputForm
        /// </summary>
        [DataMember(Name="inputForm", EmitDefaultValue=false)]
        public List<Object> InputForm { get; set; }

        /// <summary>
        /// Gets or Sets OutputId
        /// </summary>
        [DataMember(Name="outputId", EmitDefaultValue=false)]
        public string OutputId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalOutputParameters
        /// </summary>
        [DataMember(Name="externalOutputParameters", EmitDefaultValue=false)]
        public List<string> ExternalOutputParameters { get; set; }

        /// <summary>
        /// Gets or Sets OutputSchema
        /// </summary>
        [DataMember(Name="outputSchema", EmitDefaultValue=false)]
        public Object OutputSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowStep {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconClass: ").Append(IconClass).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PrimaryParameters: ").Append(PrimaryParameters).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  InputForm: ").Append(InputForm).Append("\n");
            sb.Append("  OutputId: ").Append(OutputId).Append("\n");
            sb.Append("  ExternalOutputParameters: ").Append(ExternalOutputParameters).Append("\n");
            sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
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
            return this.Equals(obj as FlowStep);
        }

        /// <summary>
        /// Returns true if FlowStep instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.IconClass == other.IconClass ||
                    this.IconClass != null &&
                    this.IconClass.Equals(other.IconClass)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.PrimaryParameters == other.PrimaryParameters ||
                    this.PrimaryParameters != null &&
                    this.PrimaryParameters.SequenceEqual(other.PrimaryParameters)
                ) && 
                (
                    this.InputSchema == other.InputSchema ||
                    this.InputSchema != null &&
                    this.InputSchema.Equals(other.InputSchema)
                ) && 
                (
                    this.InputForm == other.InputForm ||
                    this.InputForm != null &&
                    this.InputForm.SequenceEqual(other.InputForm)
                ) && 
                (
                    this.OutputId == other.OutputId ||
                    this.OutputId != null &&
                    this.OutputId.Equals(other.OutputId)
                ) && 
                (
                    this.ExternalOutputParameters == other.ExternalOutputParameters ||
                    this.ExternalOutputParameters != null &&
                    this.ExternalOutputParameters.SequenceEqual(other.ExternalOutputParameters)
                ) && 
                (
                    this.OutputSchema == other.OutputSchema ||
                    this.OutputSchema != null &&
                    this.OutputSchema.Equals(other.OutputSchema)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.IconClass != null)
                    hash = hash * 59 + this.IconClass.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.PrimaryParameters != null)
                    hash = hash * 59 + this.PrimaryParameters.GetHashCode();
                if (this.InputSchema != null)
                    hash = hash * 59 + this.InputSchema.GetHashCode();
                if (this.InputForm != null)
                    hash = hash * 59 + this.InputForm.GetHashCode();
                if (this.OutputId != null)
                    hash = hash * 59 + this.OutputId.GetHashCode();
                if (this.ExternalOutputParameters != null)
                    hash = hash * 59 + this.ExternalOutputParameters.GetHashCode();
                if (this.OutputSchema != null)
                    hash = hash * 59 + this.OutputSchema.GetHashCode();
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