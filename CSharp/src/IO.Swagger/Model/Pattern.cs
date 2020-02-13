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
    /// Pattern represents one regex (pattern) that is able to detect a certain entity and how confident the result is
    /// </summary>
    [DataContract]
    public partial class Pattern :  IEquatable<Pattern>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern" /> class.
        /// </summary>
        /// <param name="name">The name of the pattern, unique.</param>
        /// <param name="regex">The Regex used by this recognizer.</param>
        /// <param name="score">The confidence of the result.</param>
        public Pattern(string name = default(string), string regex = default(string), float? score = default(float?))
        {
            this.Name = name;
            this.Regex = regex;
            this.Score = score;
        }
        
        /// <summary>
        /// The name of the pattern, unique
        /// </summary>
        /// <value>The name of the pattern, unique</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Regex used by this recognizer
        /// </summary>
        /// <value>The Regex used by this recognizer</value>
        [DataMember(Name="regex", EmitDefaultValue=false)]
        public string Regex { get; set; }

        /// <summary>
        /// The confidence of the result
        /// </summary>
        /// <value>The confidence of the result</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public float? Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pattern {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as Pattern);
        }

        /// <summary>
        /// Returns true if Pattern instances are equal
        /// </summary>
        /// <param name="input">Instance of Pattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pattern input)
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
                    this.Regex == input.Regex ||
                    (this.Regex != null &&
                    this.Regex.Equals(input.Regex))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.Regex != null)
                    hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
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
