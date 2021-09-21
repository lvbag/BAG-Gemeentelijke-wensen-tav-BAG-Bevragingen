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
    /// AdresUitgebreid
    /// </summary>
    [DataContract(Name = "AdresUitgebreid")]
    public partial class AdresUitgebreid : IEquatable<AdresUitgebreid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresUitgebreid" /> class.
        /// </summary>
        /// <param name="straat">Een naam die door de gemeente aan een openbare ruimte is gegeven..</param>
        /// <param name="huisnummer">Een nummer dat door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="huisletter">Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="huisnummertoevoeging">Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="postcode">De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort..</param>
        /// <param name="woonplaats">Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam..</param>
        /// <param name="adresregel1">De eerste regel van het adres zoals deze gebruikt kan worden in postadressering..</param>
        /// <param name="adresregel2">De tweede regel van het adres zoals deze gebruikt kan worden in postadressering..</param>
        /// <param name="korteNaam">De officiële openbareruimtenaam of een verkorte versie. Beiden hebben maximaal 24 tekens..</param>
        /// <param name="nummeraanduidingIdentificatie">Fungeert ook als identificatie van het adres..</param>
        /// <param name="openbareRuimteIdentificatie">openbareRuimteIdentificatie.</param>
        /// <param name="woonplaatsIdentificatie">woonplaatsIdentificatie.</param>
        /// <param name="adresseerbaarObjectIdentificatie">adresseerbaarObjectIdentificatie.</param>
        /// <param name="pandIdentificaties">Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is..</param>
        /// <param name="isNevenadres">Indicatie dat dit adres een nevenadres is van een adresseerbaar object. Het adres is een hoofdadres als deze indicatie niet wordt meegeleverd..</param>
        /// <param name="geconstateerd">Indicatie dat dit adres in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. Het adres is mogelijk illegaal..</param>
        /// <param name="mogelijkOnjuist">mogelijkOnjuist.</param>
        public AdresUitgebreid(string straat = default(string), int huisnummer = default(int), string huisletter = default(string), string huisnummertoevoeging = default(string), string postcode = default(string), string woonplaats = default(string), string adresregel1 = default(string), string adresregel2 = default(string), string korteNaam = default(string), string nummeraanduidingIdentificatie = default(string), string openbareRuimteIdentificatie = default(string), string woonplaatsIdentificatie = default(string), string adresseerbaarObjectIdentificatie = default(string), List<string> pandIdentificaties = default(List<string>), bool isNevenadres = default(bool), bool geconstateerd = default(bool), AdresMogelijkOnjuist mogelijkOnjuist = default(AdresMogelijkOnjuist))
        {
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Huisletter = huisletter;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
            this.Adresregel1 = adresregel1;
            this.Adresregel2 = adresregel2;
            this.KorteNaam = korteNaam;
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
            this.OpenbareRuimteIdentificatie = openbareRuimteIdentificatie;
            this.WoonplaatsIdentificatie = woonplaatsIdentificatie;
            this.AdresseerbaarObjectIdentificatie = adresseerbaarObjectIdentificatie;
            this.PandIdentificaties = pandIdentificaties;
            this.IsNevenadres = isNevenadres;
            this.Geconstateerd = geconstateerd;
            this.MogelijkOnjuist = mogelijkOnjuist;
        }

        /// <summary>
        /// Een naam die door de gemeente aan een openbare ruimte is gegeven.
        /// </summary>
        /// <value>Een naam die door de gemeente aan een openbare ruimte is gegeven.</value>
        [DataMember(Name = "straat", EmitDefaultValue = false)]
        public string Straat { get; set; }

        /// <summary>
        /// Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
        public int Huisnummer { get; set; }

        /// <summary>
        /// Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name = "huisletter", EmitDefaultValue = false)]
        public string Huisletter { get; set; }

        /// <summary>
        /// Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = false)]
        public string Huisnummertoevoeging { get; set; }

        /// <summary>
        /// De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.
        /// </summary>
        /// <value>De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.
        /// </summary>
        /// <value>Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.</value>
        [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
        public string Woonplaats { get; set; }

        /// <summary>
        /// De eerste regel van het adres zoals deze gebruikt kan worden in postadressering.
        /// </summary>
        /// <value>De eerste regel van het adres zoals deze gebruikt kan worden in postadressering.</value>
        [DataMember(Name = "adresregel1", EmitDefaultValue = false)]
        public string Adresregel1 { get; set; }

        /// <summary>
        /// De tweede regel van het adres zoals deze gebruikt kan worden in postadressering.
        /// </summary>
        /// <value>De tweede regel van het adres zoals deze gebruikt kan worden in postadressering.</value>
        [DataMember(Name = "adresregel2", EmitDefaultValue = false)]
        public string Adresregel2 { get; set; }

        /// <summary>
        /// De officiële openbareruimtenaam of een verkorte versie. Beiden hebben maximaal 24 tekens.
        /// </summary>
        /// <value>De officiële openbareruimtenaam of een verkorte versie. Beiden hebben maximaal 24 tekens.</value>
        [DataMember(Name = "korteNaam", EmitDefaultValue = false)]
        public string KorteNaam { get; set; }

        /// <summary>
        /// Fungeert ook als identificatie van het adres.
        /// </summary>
        /// <value>Fungeert ook als identificatie van het adres.</value>
        [DataMember(Name = "nummeraanduidingIdentificatie", EmitDefaultValue = false)]
        public string NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets OpenbareRuimteIdentificatie
        /// </summary>
        [DataMember(Name = "openbareRuimteIdentificatie", EmitDefaultValue = false)]
        public string OpenbareRuimteIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets WoonplaatsIdentificatie
        /// </summary>
        [DataMember(Name = "woonplaatsIdentificatie", EmitDefaultValue = false)]
        public string WoonplaatsIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets AdresseerbaarObjectIdentificatie
        /// </summary>
        [DataMember(Name = "adresseerbaarObjectIdentificatie", EmitDefaultValue = false)]
        public string AdresseerbaarObjectIdentificatie { get; set; }

        /// <summary>
        /// Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is.
        /// </summary>
        /// <value>Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is.</value>
        [DataMember(Name = "pandIdentificaties", EmitDefaultValue = false)]
        public List<string> PandIdentificaties { get; set; }

        /// <summary>
        /// Indicatie dat dit adres een nevenadres is van een adresseerbaar object. Het adres is een hoofdadres als deze indicatie niet wordt meegeleverd.
        /// </summary>
        /// <value>Indicatie dat dit adres een nevenadres is van een adresseerbaar object. Het adres is een hoofdadres als deze indicatie niet wordt meegeleverd.</value>
        [DataMember(Name = "isNevenadres", EmitDefaultValue = true)]
        public bool IsNevenadres { get; set; }

        /// <summary>
        /// Indicatie dat dit adres in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. Het adres is mogelijk illegaal.
        /// </summary>
        /// <value>Indicatie dat dit adres in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. Het adres is mogelijk illegaal.</value>
        [DataMember(Name = "geconstateerd", EmitDefaultValue = true)]
        public bool Geconstateerd { get; set; }

        /// <summary>
        /// Gets or Sets MogelijkOnjuist
        /// </summary>
        [DataMember(Name = "mogelijkOnjuist", EmitDefaultValue = false)]
        public AdresMogelijkOnjuist MogelijkOnjuist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdresUitgebreid {\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
            sb.Append("  Adresregel1: ").Append(Adresregel1).Append("\n");
            sb.Append("  Adresregel2: ").Append(Adresregel2).Append("\n");
            sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
            sb.Append("  OpenbareRuimteIdentificatie: ").Append(OpenbareRuimteIdentificatie).Append("\n");
            sb.Append("  WoonplaatsIdentificatie: ").Append(WoonplaatsIdentificatie).Append("\n");
            sb.Append("  AdresseerbaarObjectIdentificatie: ").Append(AdresseerbaarObjectIdentificatie).Append("\n");
            sb.Append("  PandIdentificaties: ").Append(PandIdentificaties).Append("\n");
            sb.Append("  IsNevenadres: ").Append(IsNevenadres).Append("\n");
            sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
            sb.Append("  MogelijkOnjuist: ").Append(MogelijkOnjuist).Append("\n");
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
            return this.Equals(input as AdresUitgebreid);
        }

        /// <summary>
        /// Returns true if AdresUitgebreid instances are equal
        /// </summary>
        /// <param name="input">Instance of AdresUitgebreid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdresUitgebreid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Straat == input.Straat ||
                    (this.Straat != null &&
                    this.Straat.Equals(input.Straat))
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    this.Huisnummer.Equals(input.Huisnummer)
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
                    this.AdresseerbaarObjectIdentificatie == input.AdresseerbaarObjectIdentificatie ||
                    (this.AdresseerbaarObjectIdentificatie != null &&
                    this.AdresseerbaarObjectIdentificatie.Equals(input.AdresseerbaarObjectIdentificatie))
                ) && 
                (
                    this.PandIdentificaties == input.PandIdentificaties ||
                    this.PandIdentificaties != null &&
                    input.PandIdentificaties != null &&
                    this.PandIdentificaties.SequenceEqual(input.PandIdentificaties)
                ) && 
                (
                    this.IsNevenadres == input.IsNevenadres ||
                    this.IsNevenadres.Equals(input.IsNevenadres)
                ) && 
                (
                    this.Geconstateerd == input.Geconstateerd ||
                    this.Geconstateerd.Equals(input.Geconstateerd)
                ) && 
                (
                    this.MogelijkOnjuist == input.MogelijkOnjuist ||
                    (this.MogelijkOnjuist != null &&
                    this.MogelijkOnjuist.Equals(input.MogelijkOnjuist))
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
                if (this.Straat != null)
                    hashCode = hashCode * 59 + this.Straat.GetHashCode();
                hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                if (this.Huisletter != null)
                    hashCode = hashCode * 59 + this.Huisletter.GetHashCode();
                if (this.Huisnummertoevoeging != null)
                    hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Woonplaats != null)
                    hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
                if (this.Adresregel1 != null)
                    hashCode = hashCode * 59 + this.Adresregel1.GetHashCode();
                if (this.Adresregel2 != null)
                    hashCode = hashCode * 59 + this.Adresregel2.GetHashCode();
                if (this.KorteNaam != null)
                    hashCode = hashCode * 59 + this.KorteNaam.GetHashCode();
                if (this.NummeraanduidingIdentificatie != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificatie.GetHashCode();
                if (this.OpenbareRuimteIdentificatie != null)
                    hashCode = hashCode * 59 + this.OpenbareRuimteIdentificatie.GetHashCode();
                if (this.WoonplaatsIdentificatie != null)
                    hashCode = hashCode * 59 + this.WoonplaatsIdentificatie.GetHashCode();
                if (this.AdresseerbaarObjectIdentificatie != null)
                    hashCode = hashCode * 59 + this.AdresseerbaarObjectIdentificatie.GetHashCode();
                if (this.PandIdentificaties != null)
                    hashCode = hashCode * 59 + this.PandIdentificaties.GetHashCode();
                hashCode = hashCode * 59 + this.IsNevenadres.GetHashCode();
                hashCode = hashCode * 59 + this.Geconstateerd.GetHashCode();
                if (this.MogelijkOnjuist != null)
                    hashCode = hashCode * 59 + this.MogelijkOnjuist.GetHashCode();
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
            // KorteNaam (string) maxLength
            if(this.KorteNaam != null && this.KorteNaam.Length > 24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KorteNaam, length must be less than 24.", new [] { "KorteNaam" });
            }

            yield break;
        }
    }

}
