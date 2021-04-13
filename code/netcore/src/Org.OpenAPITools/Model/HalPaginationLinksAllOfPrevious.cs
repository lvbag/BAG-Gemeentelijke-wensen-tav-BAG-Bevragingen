/*
 * Huidige bevragingen API
 *
 * Deze API levert actuele gegevens over adressen, adresseerbare objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: bag@kadaster.nl
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// uri voor het opvragen van de vorige pagina van deze collectie
    /// </summary>
    [DataContract(Name = "HalPaginationLinks_allOf_previous")]
    public partial class HalPaginationLinksAllOfPrevious : IEquatable<HalPaginationLinksAllOfPrevious>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HalPaginationLinksAllOfPrevious" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="templated">templated.</param>
        /// <param name="title">title.</param>
        public HalPaginationLinksAllOfPrevious(string href = default(string), bool templated = default(bool), string title = default(string))
        {
            this.Href = href;
            this.Templated = templated;
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Templated
        /// </summary>
        [DataMember(Name = "templated", EmitDefaultValue = false)]
        public bool Templated { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HalPaginationLinksAllOfPrevious {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Templated: ").Append(Templated).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as HalPaginationLinksAllOfPrevious);
        }

        /// <summary>
        /// Returns true if HalPaginationLinksAllOfPrevious instances are equal
        /// </summary>
        /// <param name="input">Instance of HalPaginationLinksAllOfPrevious to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HalPaginationLinksAllOfPrevious input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Templated == input.Templated ||
                    this.Templated.Equals(input.Templated)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                hashCode = hashCode * 59 + this.Templated.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
