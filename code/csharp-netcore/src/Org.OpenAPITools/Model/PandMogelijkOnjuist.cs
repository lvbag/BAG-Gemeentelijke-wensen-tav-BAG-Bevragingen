/* 
 * Huidige bevragingen API
 *
 * Deze API levert actuele gegevens over adressen, adresseerbaar objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// Wanneer true is de waarde mogelijk onjuist en wordt juistheid op dit moment onderzocht. Zie toelichting.
    /// </summary>
    [DataContract]
    public partial class PandMogelijkOnjuist :  IEquatable<PandMogelijkOnjuist>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PandMogelijkOnjuist" /> class.
        /// </summary>
        /// <param name="geometrie">geometrie.</param>
        /// <param name="oorspronkelijkBouwjaar">oorspronkelijkBouwjaar.</param>
        /// <param name="status">status.</param>
        /// <param name="toelichting">toelichting.</param>
        public PandMogelijkOnjuist(bool geometrie = default(bool), bool oorspronkelijkBouwjaar = default(bool), bool status = default(bool), List<string> toelichting = default(List<string>))
        {
            this.Geometrie = geometrie;
            this.OorspronkelijkBouwjaar = oorspronkelijkBouwjaar;
            this.Status = status;
            this.Toelichting = toelichting;
        }
        
        /// <summary>
        /// Gets or Sets Geometrie
        /// </summary>
        [DataMember(Name="geometrie", EmitDefaultValue=false)]
        public bool Geometrie { get; set; }

        /// <summary>
        /// Gets or Sets OorspronkelijkBouwjaar
        /// </summary>
        [DataMember(Name="oorspronkelijkBouwjaar", EmitDefaultValue=false)]
        public bool OorspronkelijkBouwjaar { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or Sets Toelichting
        /// </summary>
        [DataMember(Name="toelichting", EmitDefaultValue=false)]
        public List<string> Toelichting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PandMogelijkOnjuist {\n");
            sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
            sb.Append("  OorspronkelijkBouwjaar: ").Append(OorspronkelijkBouwjaar).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Toelichting: ").Append(Toelichting).Append("\n");
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
            return this.Equals(input as PandMogelijkOnjuist);
        }

        /// <summary>
        /// Returns true if PandMogelijkOnjuist instances are equal
        /// </summary>
        /// <param name="input">Instance of PandMogelijkOnjuist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PandMogelijkOnjuist input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geometrie == input.Geometrie ||
                    this.Geometrie.Equals(input.Geometrie)
                ) && 
                (
                    this.OorspronkelijkBouwjaar == input.OorspronkelijkBouwjaar ||
                    this.OorspronkelijkBouwjaar.Equals(input.OorspronkelijkBouwjaar)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Toelichting == input.Toelichting ||
                    this.Toelichting != null &&
                    input.Toelichting != null &&
                    this.Toelichting.SequenceEqual(input.Toelichting)
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
                hashCode = hashCode * 59 + this.Geometrie.GetHashCode();
                hashCode = hashCode * 59 + this.OorspronkelijkBouwjaar.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Toelichting != null)
                    hashCode = hashCode * 59 + this.Toelichting.GetHashCode();
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