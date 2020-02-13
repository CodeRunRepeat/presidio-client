/* 
 * Presidio.
 *
 * Documentation for Presidio API Swagger.
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ScannerCronJobRequest represents the request to the scheduler service via GRPC
    /// </summary>
    [DataContract]
    public partial class ScannerCronJobRequest :  IEquatable<ScannerCronJobRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerCronJobRequest" /> class.
        /// </summary>
        /// <param name="name">Scanner cronjob name.</param>
        /// <param name="scanRequest">scanRequest.</param>
        /// <param name="trigger">trigger.</param>
        public ScannerCronJobRequest(string name = default(string), ScanRequest scanRequest = default(ScanRequest), Trigger trigger = default(Trigger))
        {
            this.Name = name;
            this.ScanRequest = scanRequest;
            this.Trigger = trigger;
        }
        
        /// <summary>
        /// Scanner cronjob name
        /// </summary>
        /// <value>Scanner cronjob name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ScanRequest
        /// </summary>
        [DataMember(Name="scanRequest", EmitDefaultValue=false)]
        public ScanRequest ScanRequest { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name="trigger", EmitDefaultValue=false)]
        public Trigger Trigger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScannerCronJobRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ScanRequest: ").Append(ScanRequest).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ScannerCronJobRequest);
        }

        /// <summary>
        /// Returns true if ScannerCronJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannerCronJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannerCronJobRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ScanRequest == input.ScanRequest ||
                    (this.ScanRequest != null &&
                    this.ScanRequest.Equals(input.ScanRequest))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ScanRequest != null)
                    hashCode = hashCode * 59 + this.ScanRequest.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
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