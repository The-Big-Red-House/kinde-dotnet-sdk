/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Kinde.Api.Client.FileParameter;
using OpenAPIDateConverter = Kinde.Api.Client.OpenAPIDateConverter;

namespace Kinde.Api.Model
{
    /// <summary>
    /// ReplaceRedirectCallbackURLsRequest
    /// </summary>
    [DataContract(Name = "replaceRedirectCallbackURLs_request")]
    public partial class ReplaceRedirectCallbackURLsRequest : IEquatable<ReplaceRedirectCallbackURLsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceRedirectCallbackURLsRequest" /> class.
        /// </summary>
        /// <param name="urls">Array of callback urls..</param>
        public ReplaceRedirectCallbackURLsRequest(List<string> urls = default(List<string>))
        {
            this.Urls = urls;
        }

        /// <summary>
        /// Array of callback urls.
        /// </summary>
        /// <value>Array of callback urls.</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplaceRedirectCallbackURLsRequest {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplaceRedirectCallbackURLsRequest);
        }

        /// <summary>
        /// Returns true if ReplaceRedirectCallbackURLsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceRedirectCallbackURLsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceRedirectCallbackURLsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
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
                if (this.Urls != null)
                {
                    hashCode = (hashCode * 59) + this.Urls.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}