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
    /// Represents the Google Storage configuration
    /// </summary>
    [DataContract]
    public partial class GoogleStorageConfig :  IEquatable<GoogleStorageConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleStorageConfig" /> class.
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="json">The json.</param>
        /// <param name="projectId">The project id.</param>
        /// <param name="scopes">The scopes authentication [there are different scopes, which you can find here https://cloud.google.com/storage/docs/authentication].</param>
        public GoogleStorageConfig(string bucketName = default(string), string json = default(string), string projectId = default(string), string scopes = default(string))
        {
            this.BucketName = bucketName;
            this.Json = json;
            this.ProjectId = projectId;
            this.Scopes = scopes;
        }
        
        /// <summary>
        /// The bucket name
        /// </summary>
        /// <value>The bucket name</value>
        [DataMember(Name="bucketName", EmitDefaultValue=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The json
        /// </summary>
        /// <value>The json</value>
        [DataMember(Name="json", EmitDefaultValue=false)]
        public string Json { get; set; }

        /// <summary>
        /// The project id
        /// </summary>
        /// <value>The project id</value>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The scopes authentication [there are different scopes, which you can find here https://cloud.google.com/storage/docs/authentication]
        /// </summary>
        /// <value>The scopes authentication [there are different scopes, which you can find here https://cloud.google.com/storage/docs/authentication]</value>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public string Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleStorageConfig {\n");
            sb.Append("  BucketName: ").Append(BucketName).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as GoogleStorageConfig);
        }

        /// <summary>
        /// Returns true if GoogleStorageConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleStorageConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleStorageConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.Json == input.Json ||
                    (this.Json != null &&
                    this.Json.Equals(input.Json))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    (this.Scopes != null &&
                    this.Scopes.Equals(input.Scopes))
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
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Json != null)
                    hashCode = hashCode * 59 + this.Json.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Scopes != null)
                    hashCode = hashCode * 59 + this.Scopes.GetHashCode();
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