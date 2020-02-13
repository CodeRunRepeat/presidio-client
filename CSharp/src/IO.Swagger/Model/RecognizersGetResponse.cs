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
    /// RecognizersGetResponse represents a response to a get request
    /// </summary>
    [DataContract]
    public partial class RecognizersGetResponse :  IEquatable<RecognizersGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizersGetResponse" /> class.
        /// </summary>
        /// <param name="recognizers">An array of recognizers.</param>
        public RecognizersGetResponse(List<PatternRecognizer> recognizers = default(List<PatternRecognizer>))
        {
            this.Recognizers = recognizers;
        }
        
        /// <summary>
        /// An array of recognizers
        /// </summary>
        /// <value>An array of recognizers</value>
        [DataMember(Name="recognizers", EmitDefaultValue=false)]
        public List<PatternRecognizer> Recognizers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecognizersGetResponse {\n");
            sb.Append("  Recognizers: ").Append(Recognizers).Append("\n");
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
            return this.Equals(input as RecognizersGetResponse);
        }

        /// <summary>
        /// Returns true if RecognizersGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RecognizersGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecognizersGetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recognizers == input.Recognizers ||
                    this.Recognizers != null &&
                    this.Recognizers.SequenceEqual(input.Recognizers)
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
                if (this.Recognizers != null)
                    hashCode = hashCode * 59 + this.Recognizers.GetHashCode();
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
