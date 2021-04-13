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
    /// Wanneer true is de waarde mogelijk onjuist en wordt juistheid op dit moment onderzocht. Zie toelichting.
    /// </summary>
    [DataContract(Name = "OpenbareRuimteMogelijkOnjuist")]
    public partial class OpenbareRuimteMogelijkOnjuist : IEquatable<OpenbareRuimteMogelijkOnjuist>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenbareRuimteMogelijkOnjuist" /> class.
        /// </summary>
        /// <param name="naam">naam.</param>
        /// <param name="korteNaam">korteNaam.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="woonplaatsIdentificatie">woonplaatsIdentificatie.</param>
        /// <param name="toelichting">toelichting.</param>
        public OpenbareRuimteMogelijkOnjuist(bool naam = default(bool), bool korteNaam = default(bool), bool type = default(bool), bool status = default(bool), bool woonplaatsIdentificatie = default(bool), List<string> toelichting = default(List<string>))
        {
            this.Naam = naam;
            this.KorteNaam = korteNaam;
            this.Type = type;
            this.Status = status;
            this.WoonplaatsIdentificatie = woonplaatsIdentificatie;
            this.Toelichting = toelichting;
        }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name = "naam", EmitDefaultValue = false)]
        public bool Naam { get; set; }

        /// <summary>
        /// Gets or Sets KorteNaam
        /// </summary>
        [DataMember(Name = "korteNaam", EmitDefaultValue = false)]
        public bool KorteNaam { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public bool Type { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or Sets WoonplaatsIdentificatie
        /// </summary>
        [DataMember(Name = "woonplaatsIdentificatie", EmitDefaultValue = false)]
        public bool WoonplaatsIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets Toelichting
        /// </summary>
        [DataMember(Name = "toelichting", EmitDefaultValue = false)]
        public List<string> Toelichting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenbareRuimteMogelijkOnjuist {\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WoonplaatsIdentificatie: ").Append(WoonplaatsIdentificatie).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenbareRuimteMogelijkOnjuist);
        }

        /// <summary>
        /// Returns true if OpenbareRuimteMogelijkOnjuist instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenbareRuimteMogelijkOnjuist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenbareRuimteMogelijkOnjuist input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Naam == input.Naam ||
                    this.Naam.Equals(input.Naam)
                ) && 
                (
                    this.KorteNaam == input.KorteNaam ||
                    this.KorteNaam.Equals(input.KorteNaam)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.WoonplaatsIdentificatie == input.WoonplaatsIdentificatie ||
                    this.WoonplaatsIdentificatie.Equals(input.WoonplaatsIdentificatie)
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
                hashCode = hashCode * 59 + this.Naam.GetHashCode();
                hashCode = hashCode * 59 + this.KorteNaam.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.WoonplaatsIdentificatie.GetHashCode();
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
