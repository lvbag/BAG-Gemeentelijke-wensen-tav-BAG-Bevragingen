/*
 * Huidige bevragingen API
 *
 * Deze API levert actuele gegevens over adressen, adresseerbare objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: bag@kadaster.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ZoekResultaatHalCollectieEmbedded
    /// </summary>
    [DataContract]
    public partial class ZoekResultaatHalCollectieEmbedded :  IEquatable<ZoekResultaatHalCollectieEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoekResultaatHalCollectieEmbedded" /> class.
        /// </summary>
        /// <param name="zoekresultaten">zoekresultaten.</param>
        public ZoekResultaatHalCollectieEmbedded(List<ZoekResultaatHal> zoekresultaten = default(List<ZoekResultaatHal>))
        {
            this.Zoekresultaten = zoekresultaten;
        }

        /// <summary>
        /// Gets or Sets Zoekresultaten
        /// </summary>
        [DataMember(Name="zoekresultaten", EmitDefaultValue=false)]
        public List<ZoekResultaatHal> Zoekresultaten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZoekResultaatHalCollectieEmbedded {\n");
            sb.Append("  Zoekresultaten: ").Append(Zoekresultaten).Append("\n");
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
            return this.Equals(input as ZoekResultaatHalCollectieEmbedded);
        }

        /// <summary>
        /// Returns true if ZoekResultaatHalCollectieEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoekResultaatHalCollectieEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoekResultaatHalCollectieEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Zoekresultaten == input.Zoekresultaten ||
                    this.Zoekresultaten != null &&
                    input.Zoekresultaten != null &&
                    this.Zoekresultaten.SequenceEqual(input.Zoekresultaten)
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
                if (this.Zoekresultaten != null)
                    hashCode = hashCode * 59 + this.Zoekresultaten.GetHashCode();
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
