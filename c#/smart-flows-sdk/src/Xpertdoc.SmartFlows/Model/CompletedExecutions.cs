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
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// CompletedExecutions
    /// </summary>
    [DataContract]
    public partial class CompletedExecutions : IEquatable<CompletedExecutions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedExecutions" /> class.
        /// </summary>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="Success">Success.</param>
        /// <param name="Error">Error.</param>
        /// <param name="Cancelled">Cancelled.</param>
        /// <param name="Interrupted">Interrupted.</param>
        public CompletedExecutions(Schedule Schedule = default(Schedule), CompletedExecutionsPlan Success = default(CompletedExecutionsPlan), CompletedExecutionsPlan Error = default(CompletedExecutionsPlan), CompletedExecutionsPlan Cancelled = default(CompletedExecutionsPlan), CompletedExecutionsPlan Interrupted = default(CompletedExecutionsPlan))
        {
            this.Schedule = Schedule;
            this.Success = Success;
            this.Error = Error;
            this.Cancelled = Cancelled;
            this.Interrupted = Interrupted;
        }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public Schedule Schedule { get; set; }
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public CompletedExecutionsPlan Success { get; set; }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public CompletedExecutionsPlan Error { get; set; }
        /// <summary>
        /// Gets or Sets Cancelled
        /// </summary>
        [DataMember(Name = "cancelled", EmitDefaultValue = false)]
        public CompletedExecutionsPlan Cancelled { get; set; }
        /// <summary>
        /// Gets or Sets Interrupted
        /// </summary>
        [DataMember(Name = "interrupted", EmitDefaultValue = false)]
        public CompletedExecutionsPlan Interrupted { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletedExecutions {\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
            sb.Append("  Interrupted: ").Append(Interrupted).Append("\n");
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
            return this.Equals(obj as CompletedExecutions);
        }

        /// <summary>
        /// Returns true if CompletedExecutions instances are equal
        /// </summary>
        /// <param name="other">Instance of CompletedExecutions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletedExecutions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.Cancelled == other.Cancelled ||
                    this.Cancelled != null &&
                    this.Cancelled.Equals(other.Cancelled)
                ) &&
                (
                    this.Interrupted == other.Interrupted ||
                    this.Interrupted != null &&
                    this.Interrupted.Equals(other.Interrupted)
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
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.Cancelled != null)
                    hash = hash * 59 + this.Cancelled.GetHashCode();
                if (this.Interrupted != null)
                    hash = hash * 59 + this.Interrupted.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
