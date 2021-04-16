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
    /// Een samengesteld geometriegegevenstype waarbij wordt afgedwongen dat voor de geometrie een keuze gemaakt moet worden tussen een vlak (GM_Surface) of een multivlak (GM_MultiSurface).
    /// </summary>
    [DataContract]
    public partial class VlakOfMultivlak :  IEquatable<VlakOfMultivlak>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VlakOfMultivlak" /> class.
        /// </summary>
        /// <param name="vlak">vlak.</param>
        /// <param name="multivlak">multivlak.</param>
        public VlakOfMultivlak(PolygonGeoJSON vlak = default(PolygonGeoJSON), MultipolygonGeoJSON multivlak = default(MultipolygonGeoJSON))
        {
            this.Vlak = vlak;
            this.Multivlak = multivlak;
        }

        /// <summary>
        /// Gets or Sets Vlak
        /// </summary>
        [DataMember(Name="vlak", EmitDefaultValue=false)]
        public PolygonGeoJSON Vlak { get; set; }

        /// <summary>
        /// Gets or Sets Multivlak
        /// </summary>
        [DataMember(Name="multivlak", EmitDefaultValue=false)]
        public MultipolygonGeoJSON Multivlak { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VlakOfMultivlak {\n");
            sb.Append("  Vlak: ").Append(Vlak).Append("\n");
            sb.Append("  Multivlak: ").Append(Multivlak).Append("\n");
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
            return this.Equals(input as VlakOfMultivlak);
        }

        /// <summary>
        /// Returns true if VlakOfMultivlak instances are equal
        /// </summary>
        /// <param name="input">Instance of VlakOfMultivlak to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VlakOfMultivlak input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vlak == input.Vlak ||
                    (this.Vlak != null &&
                    this.Vlak.Equals(input.Vlak))
                ) && 
                (
                    this.Multivlak == input.Multivlak ||
                    (this.Multivlak != null &&
                    this.Multivlak.Equals(input.Multivlak))
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
                if (this.Vlak != null)
                    hashCode = hashCode * 59 + this.Vlak.GetHashCode();
                if (this.Multivlak != null)
                    hashCode = hashCode * 59 + this.Multivlak.GetHashCode();
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
