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
    /// ScanRequest represents the request to the scanner service via GRPC
    /// </summary>
    [DataContract]
    public partial class ScanRequest :  IEquatable<ScanRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanRequest" /> class.
        /// </summary>
        /// <param name="analyzeTemplate">analyzeTemplate.</param>
        /// <param name="anonymizeTemplate">anonymizeTemplate.</param>
        /// <param name="datasinkTemplate">datasinkTemplate.</param>
        /// <param name="scanTemplate">scanTemplate.</param>
        public ScanRequest(AnalyzeTemplate analyzeTemplate = default(AnalyzeTemplate), AnonymizeTemplate anonymizeTemplate = default(AnonymizeTemplate), DatasinkTemplate datasinkTemplate = default(DatasinkTemplate), ScanTemplate scanTemplate = default(ScanTemplate))
        {
            this.AnalyzeTemplate = analyzeTemplate;
            this.AnonymizeTemplate = anonymizeTemplate;
            this.DatasinkTemplate = datasinkTemplate;
            this.ScanTemplate = scanTemplate;
        }
        
        /// <summary>
        /// Gets or Sets AnalyzeTemplate
        /// </summary>
        [DataMember(Name="analyzeTemplate", EmitDefaultValue=false)]
        public AnalyzeTemplate AnalyzeTemplate { get; set; }

        /// <summary>
        /// Gets or Sets AnonymizeTemplate
        /// </summary>
        [DataMember(Name="anonymizeTemplate", EmitDefaultValue=false)]
        public AnonymizeTemplate AnonymizeTemplate { get; set; }

        /// <summary>
        /// Gets or Sets DatasinkTemplate
        /// </summary>
        [DataMember(Name="datasinkTemplate", EmitDefaultValue=false)]
        public DatasinkTemplate DatasinkTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ScanTemplate
        /// </summary>
        [DataMember(Name="scanTemplate", EmitDefaultValue=false)]
        public ScanTemplate ScanTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanRequest {\n");
            sb.Append("  AnalyzeTemplate: ").Append(AnalyzeTemplate).Append("\n");
            sb.Append("  AnonymizeTemplate: ").Append(AnonymizeTemplate).Append("\n");
            sb.Append("  DatasinkTemplate: ").Append(DatasinkTemplate).Append("\n");
            sb.Append("  ScanTemplate: ").Append(ScanTemplate).Append("\n");
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
            return this.Equals(input as ScanRequest);
        }

        /// <summary>
        /// Returns true if ScanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnalyzeTemplate == input.AnalyzeTemplate ||
                    (this.AnalyzeTemplate != null &&
                    this.AnalyzeTemplate.Equals(input.AnalyzeTemplate))
                ) && 
                (
                    this.AnonymizeTemplate == input.AnonymizeTemplate ||
                    (this.AnonymizeTemplate != null &&
                    this.AnonymizeTemplate.Equals(input.AnonymizeTemplate))
                ) && 
                (
                    this.DatasinkTemplate == input.DatasinkTemplate ||
                    (this.DatasinkTemplate != null &&
                    this.DatasinkTemplate.Equals(input.DatasinkTemplate))
                ) && 
                (
                    this.ScanTemplate == input.ScanTemplate ||
                    (this.ScanTemplate != null &&
                    this.ScanTemplate.Equals(input.ScanTemplate))
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
                if (this.AnalyzeTemplate != null)
                    hashCode = hashCode * 59 + this.AnalyzeTemplate.GetHashCode();
                if (this.AnonymizeTemplate != null)
                    hashCode = hashCode * 59 + this.AnonymizeTemplate.GetHashCode();
                if (this.DatasinkTemplate != null)
                    hashCode = hashCode * 59 + this.DatasinkTemplate.GetHashCode();
                if (this.ScanTemplate != null)
                    hashCode = hashCode * 59 + this.ScanTemplate.GetHashCode();
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