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
    /// PandLinks
    /// </summary>
    [DataContract(Name = "PandLinks")]
    public partial class PandLinks : IEquatable<PandLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PandLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="adressen">adressen.</param>
        /// <param name="adresseerbareObjecten">adresseerbareObjecten.</param>
        public PandLinks(HalLink self = default(HalLink), List<HalLink> adressen = default(List<HalLink>), List<HalLink> adresseerbareObjecten = default(List<HalLink>))
        {
            this.Self = self;
            this.Adressen = adressen;
            this.AdresseerbareObjecten = adresseerbareObjecten;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public HalLink Self { get; set; }

        /// <summary>
        /// Gets or Sets Adressen
        /// </summary>
        [DataMember(Name = "adressen", EmitDefaultValue = false)]
        public List<HalLink> Adressen { get; set; }

        /// <summary>
        /// Gets or Sets AdresseerbareObjecten
        /// </summary>
        [DataMember(Name = "adresseerbareObjecten", EmitDefaultValue = false)]
        public List<HalLink> AdresseerbareObjecten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PandLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Adressen: ").Append(Adressen).Append("\n");
            sb.Append("  AdresseerbareObjecten: ").Append(AdresseerbareObjecten).Append("\n");
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
            return this.Equals(input as PandLinks);
        }

        /// <summary>
        /// Returns true if PandLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of PandLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PandLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Adressen == input.Adressen ||
                    this.Adressen != null &&
                    input.Adressen != null &&
                    this.Adressen.SequenceEqual(input.Adressen)
                ) && 
                (
                    this.AdresseerbareObjecten == input.AdresseerbareObjecten ||
                    this.AdresseerbareObjecten != null &&
                    input.AdresseerbareObjecten != null &&
                    this.AdresseerbareObjecten.SequenceEqual(input.AdresseerbareObjecten)
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Adressen != null)
                    hashCode = hashCode * 59 + this.Adressen.GetHashCode();
                if (this.AdresseerbareObjecten != null)
                    hashCode = hashCode * 59 + this.AdresseerbareObjecten.GetHashCode();
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
