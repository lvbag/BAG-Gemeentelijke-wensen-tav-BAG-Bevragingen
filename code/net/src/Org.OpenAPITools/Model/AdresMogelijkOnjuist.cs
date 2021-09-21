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
    /// Wanneer true is de waarde mogelijk onjuist en wordt juistheid op dit moment onderzocht. Zie toelichting.
    /// </summary>
    [DataContract]
    public partial class AdresMogelijkOnjuist :  IEquatable<AdresMogelijkOnjuist>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresMogelijkOnjuist" /> class.
        /// </summary>
        /// <param name="adresregel1">adresregel1.</param>
        /// <param name="adresregel2">adresregel2.</param>
        /// <param name="korteNaam">korteNaam.</param>
        /// <param name="straat">straat.</param>
        /// <param name="huisnummer">huisnummer.</param>
        /// <param name="huisletter">huisletter.</param>
        /// <param name="huisnummertoevoeging">huisnummertoevoeging.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="woonplaats">woonplaats.</param>
        /// <param name="nummeraanduidingIdentificatie">nummeraanduidingIdentificatie.</param>
        /// <param name="openbareRuimteIdentificatie">openbareRuimteIdentificatie.</param>
        /// <param name="woonplaatsIdentificatie">woonplaatsIdentificatie.</param>
        /// <param name="toelichting">toelichting.</param>
        public AdresMogelijkOnjuist(bool adresregel1 = default(bool), bool adresregel2 = default(bool), bool korteNaam = default(bool), bool straat = default(bool), bool huisnummer = default(bool), bool huisletter = default(bool), bool huisnummertoevoeging = default(bool), bool postcode = default(bool), bool woonplaats = default(bool), bool nummeraanduidingIdentificatie = default(bool), bool openbareRuimteIdentificatie = default(bool), bool woonplaatsIdentificatie = default(bool), List<string> toelichting = default(List<string>))
        {
            this.Adresregel1 = adresregel1;
            this.Adresregel2 = adresregel2;
            this.KorteNaam = korteNaam;
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Huisletter = huisletter;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
            this.OpenbareRuimteIdentificatie = openbareRuimteIdentificatie;
            this.WoonplaatsIdentificatie = woonplaatsIdentificatie;
            this.Toelichting = toelichting;
        }

        /// <summary>
        /// Gets or Sets Adresregel1
        /// </summary>
        [DataMember(Name="adresregel1", EmitDefaultValue=false)]
        public bool Adresregel1 { get; set; }

        /// <summary>
        /// Gets or Sets Adresregel2
        /// </summary>
        [DataMember(Name="adresregel2", EmitDefaultValue=false)]
        public bool Adresregel2 { get; set; }

        /// <summary>
        /// Gets or Sets KorteNaam
        /// </summary>
        [DataMember(Name="korteNaam", EmitDefaultValue=false)]
        public bool KorteNaam { get; set; }

        /// <summary>
        /// Gets or Sets Straat
        /// </summary>
        [DataMember(Name="straat", EmitDefaultValue=false)]
        public bool Straat { get; set; }

        /// <summary>
        /// Gets or Sets Huisnummer
        /// </summary>
        [DataMember(Name="huisnummer", EmitDefaultValue=false)]
        public bool Huisnummer { get; set; }

        /// <summary>
        /// Gets or Sets Huisletter
        /// </summary>
        [DataMember(Name="huisletter", EmitDefaultValue=false)]
        public bool Huisletter { get; set; }

        /// <summary>
        /// Gets or Sets Huisnummertoevoeging
        /// </summary>
        [DataMember(Name="huisnummertoevoeging", EmitDefaultValue=false)]
        public bool Huisnummertoevoeging { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public bool Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Woonplaats
        /// </summary>
        [DataMember(Name="woonplaats", EmitDefaultValue=false)]
        public bool Woonplaats { get; set; }

        /// <summary>
        /// Gets or Sets NummeraanduidingIdentificatie
        /// </summary>
        [DataMember(Name="nummeraanduidingIdentificatie", EmitDefaultValue=false)]
        public bool NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets OpenbareRuimteIdentificatie
        /// </summary>
        [DataMember(Name="openbareRuimteIdentificatie", EmitDefaultValue=false)]
        public bool OpenbareRuimteIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets WoonplaatsIdentificatie
        /// </summary>
        [DataMember(Name="woonplaatsIdentificatie", EmitDefaultValue=false)]
        public bool WoonplaatsIdentificatie { get; set; }

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
            sb.Append("class AdresMogelijkOnjuist {\n");
            sb.Append("  Adresregel1: ").Append(Adresregel1).Append("\n");
            sb.Append("  Adresregel2: ").Append(Adresregel2).Append("\n");
            sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
            sb.Append("  OpenbareRuimteIdentificatie: ").Append(OpenbareRuimteIdentificatie).Append("\n");
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
            return this.Equals(input as AdresMogelijkOnjuist);
        }

        /// <summary>
        /// Returns true if AdresMogelijkOnjuist instances are equal
        /// </summary>
        /// <param name="input">Instance of AdresMogelijkOnjuist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdresMogelijkOnjuist input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adresregel1 == input.Adresregel1 ||
                    (this.Adresregel1 != null &&
                    this.Adresregel1.Equals(input.Adresregel1))
                ) && 
                (
                    this.Adresregel2 == input.Adresregel2 ||
                    (this.Adresregel2 != null &&
                    this.Adresregel2.Equals(input.Adresregel2))
                ) && 
                (
                    this.KorteNaam == input.KorteNaam ||
                    (this.KorteNaam != null &&
                    this.KorteNaam.Equals(input.KorteNaam))
                ) && 
                (
                    this.Straat == input.Straat ||
                    (this.Straat != null &&
                    this.Straat.Equals(input.Straat))
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    (this.Huisnummer != null &&
                    this.Huisnummer.Equals(input.Huisnummer))
                ) && 
                (
                    this.Huisletter == input.Huisletter ||
                    (this.Huisletter != null &&
                    this.Huisletter.Equals(input.Huisletter))
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    (this.Huisnummertoevoeging != null &&
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    (this.Woonplaats != null &&
                    this.Woonplaats.Equals(input.Woonplaats))
                ) && 
                (
                    this.NummeraanduidingIdentificatie == input.NummeraanduidingIdentificatie ||
                    (this.NummeraanduidingIdentificatie != null &&
                    this.NummeraanduidingIdentificatie.Equals(input.NummeraanduidingIdentificatie))
                ) && 
                (
                    this.OpenbareRuimteIdentificatie == input.OpenbareRuimteIdentificatie ||
                    (this.OpenbareRuimteIdentificatie != null &&
                    this.OpenbareRuimteIdentificatie.Equals(input.OpenbareRuimteIdentificatie))
                ) && 
                (
                    this.WoonplaatsIdentificatie == input.WoonplaatsIdentificatie ||
                    (this.WoonplaatsIdentificatie != null &&
                    this.WoonplaatsIdentificatie.Equals(input.WoonplaatsIdentificatie))
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
                if (this.Adresregel1 != null)
                    hashCode = hashCode * 59 + this.Adresregel1.GetHashCode();
                if (this.Adresregel2 != null)
                    hashCode = hashCode * 59 + this.Adresregel2.GetHashCode();
                if (this.KorteNaam != null)
                    hashCode = hashCode * 59 + this.KorteNaam.GetHashCode();
                if (this.Straat != null)
                    hashCode = hashCode * 59 + this.Straat.GetHashCode();
                if (this.Huisnummer != null)
                    hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                if (this.Huisletter != null)
                    hashCode = hashCode * 59 + this.Huisletter.GetHashCode();
                if (this.Huisnummertoevoeging != null)
                    hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Woonplaats != null)
                    hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
                if (this.NummeraanduidingIdentificatie != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificatie.GetHashCode();
                if (this.OpenbareRuimteIdentificatie != null)
                    hashCode = hashCode * 59 + this.OpenbareRuimteIdentificatie.GetHashCode();
                if (this.WoonplaatsIdentificatie != null)
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
