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
    /// CounterSettings
    /// </summary>
    [DataContract]
    public partial class CounterSettings : IEquatable<CounterSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterSettings" /> class.
        /// </summary>
        /// <param name="WindowCounters">WindowCounters.</param>
        /// <param name="OverflowCounter">OverflowCounter.</param>
        public CounterSettings(List<Counter> WindowCounters = default(List<Counter>), Counter OverflowCounter = default(Counter))
        {
            this.WindowCounters = WindowCounters;
            this.OverflowCounter = OverflowCounter;
        }

        /// <summary>
        /// Gets or Sets WindowCounters
        /// </summary>
        [DataMember(Name = "windowCounters", EmitDefaultValue = false)]
        public List<Counter> WindowCounters { get; set; }
        /// <summary>
        /// Gets or Sets OverflowCounter
        /// </summary>
        [DataMember(Name = "overflowCounter", EmitDefaultValue = false)]
        public Counter OverflowCounter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CounterSettings {\n");
            sb.Append("  WindowCounters: ").Append(WindowCounters).Append("\n");
            sb.Append("  OverflowCounter: ").Append(OverflowCounter).Append("\n");
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
            return this.Equals(obj as CounterSettings);
        }

        /// <summary>
        /// Returns true if CounterSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CounterSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CounterSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.WindowCounters == other.WindowCounters ||
                    this.WindowCounters != null &&
                    this.WindowCounters.SequenceEqual(other.WindowCounters)
                ) &&
                (
                    this.OverflowCounter == other.OverflowCounter ||
                    this.OverflowCounter != null &&
                    this.OverflowCounter.Equals(other.OverflowCounter)
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
                if (this.WindowCounters != null)
                    hash = hash * 59 + this.WindowCounters.GetHashCode();
                if (this.OverflowCounter != null)
                    hash = hash * 59 + this.OverflowCounter.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}