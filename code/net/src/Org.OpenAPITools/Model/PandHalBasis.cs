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
    /// PandHalBasis
    /// </summary>
    [DataContract]
    public partial class PandHalBasis :  IEquatable<PandHalBasis>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusPandEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PandHalBasis" /> class.
        /// </summary>
        /// <param name="identificatie">De unieke aanduiding van een pand. Elk pand waarvan gegevens zijn opgenomen in de BAG wordt uniek aangeduid door middel van een identificatiecode..</param>
        /// <param name="domein">Het domein waartoe de identificatie behoort..</param>
        /// <param name="geometrie">geometrie.</param>
        /// <param name="oorspronkelijkBouwjaar">Het jaar waarin een pand oorspronkelijk als bouwkundig gereed is opgeleverd. Door de gemeente wordt een inschatting gemaakt van het bouwjaar, en aangepast als het pand wordt opgeleverd. Wijzigingen aan een pand na oplevering leiden niet tot wijziging van het bouwjaar..</param>
        /// <param name="status">status.</param>
        /// <param name="geconstateerd">Indicatie dat het pand in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. Het pand is mogelijk illegaal..</param>
        /// <param name="documentdatum">De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object..</param>
        /// <param name="documentnummer">De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan..</param>
        /// <param name="adresseerbaarObjectIdentificaties">adresseerbaarObjectIdentificaties.</param>
        /// <param name="nummeraanduidingIdentificaties">Identificatie(s) van de hoofd- en nevenadressen van het pand..</param>
        /// <param name="mogelijkOnjuist">mogelijkOnjuist.</param>
        /// <param name="links">links.</param>
        public PandHalBasis(string identificatie = default(string), string domein = default(string), PolygonGeoJSON geometrie = default(PolygonGeoJSON), int oorspronkelijkBouwjaar = default(int), StatusPandEnum? status = default(StatusPandEnum?), bool geconstateerd = default(bool), DateTime documentdatum = default(DateTime), string documentnummer = default(string), List<string> adresseerbaarObjectIdentificaties = default(List<string>), List<NummeraanduidingIdentificatiesArray> nummeraanduidingIdentificaties = default(List<NummeraanduidingIdentificatiesArray>), PandMogelijkOnjuist mogelijkOnjuist = default(PandMogelijkOnjuist), PandLinks links = default(PandLinks))
        {
            this.Identificatie = identificatie;
            this.Domein = domein;
            this.Geometrie = geometrie;
            this.OorspronkelijkBouwjaar = oorspronkelijkBouwjaar;
            this.Status = status;
            this.Geconstateerd = geconstateerd;
            this.Documentdatum = documentdatum;
            this.Documentnummer = documentnummer;
            this.AdresseerbaarObjectIdentificaties = adresseerbaarObjectIdentificaties;
            this.NummeraanduidingIdentificaties = nummeraanduidingIdentificaties;
            this.MogelijkOnjuist = mogelijkOnjuist;
            this.Links = links;
        }

        /// <summary>
        /// De unieke aanduiding van een pand. Elk pand waarvan gegevens zijn opgenomen in de BAG wordt uniek aangeduid door middel van een identificatiecode.
        /// </summary>
        /// <value>De unieke aanduiding van een pand. Elk pand waarvan gegevens zijn opgenomen in de BAG wordt uniek aangeduid door middel van een identificatiecode.</value>
        [DataMember(Name="identificatie", EmitDefaultValue=false)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Het domein waartoe de identificatie behoort.
        /// </summary>
        /// <value>Het domein waartoe de identificatie behoort.</value>
        [DataMember(Name="domein", EmitDefaultValue=false)]
        public string Domein { get; set; }

        /// <summary>
        /// Gets or Sets Geometrie
        /// </summary>
        [DataMember(Name="geometrie", EmitDefaultValue=false)]
        public PolygonGeoJSON Geometrie { get; set; }

        /// <summary>
        /// Het jaar waarin een pand oorspronkelijk als bouwkundig gereed is opgeleverd. Door de gemeente wordt een inschatting gemaakt van het bouwjaar, en aangepast als het pand wordt opgeleverd. Wijzigingen aan een pand na oplevering leiden niet tot wijziging van het bouwjaar.
        /// </summary>
        /// <value>Het jaar waarin een pand oorspronkelijk als bouwkundig gereed is opgeleverd. Door de gemeente wordt een inschatting gemaakt van het bouwjaar, en aangepast als het pand wordt opgeleverd. Wijzigingen aan een pand na oplevering leiden niet tot wijziging van het bouwjaar.</value>
        [DataMember(Name="oorspronkelijkBouwjaar", EmitDefaultValue=false)]
        public int OorspronkelijkBouwjaar { get; set; }


        /// <summary>
        /// Indicatie dat het pand in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. Het pand is mogelijk illegaal.
        /// </summary>
        /// <value>Indicatie dat het pand in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. Het pand is mogelijk illegaal.</value>
        [DataMember(Name="geconstateerd", EmitDefaultValue=false)]
        public bool Geconstateerd { get; set; }

        /// <summary>
        /// De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.
        /// </summary>
        /// <value>De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.</value>
        [DataMember(Name="documentdatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Documentdatum { get; set; }

        /// <summary>
        /// De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan.
        /// </summary>
        /// <value>De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan.</value>
        [DataMember(Name="documentnummer", EmitDefaultValue=false)]
        public string Documentnummer { get; set; }

        /// <summary>
        /// Gets or Sets AdresseerbaarObjectIdentificaties
        /// </summary>
        [DataMember(Name="adresseerbaarObjectIdentificaties", EmitDefaultValue=false)]
        public List<string> AdresseerbaarObjectIdentificaties { get; set; }

        /// <summary>
        /// Identificatie(s) van de hoofd- en nevenadressen van het pand.
        /// </summary>
        /// <value>Identificatie(s) van de hoofd- en nevenadressen van het pand.</value>
        [DataMember(Name="nummeraanduidingIdentificaties", EmitDefaultValue=false)]
        public List<NummeraanduidingIdentificatiesArray> NummeraanduidingIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets MogelijkOnjuist
        /// </summary>
        [DataMember(Name="mogelijkOnjuist", EmitDefaultValue=false)]
        public PandMogelijkOnjuist MogelijkOnjuist { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PandLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PandHalBasis {\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Domein: ").Append(Domein).Append("\n");
            sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
            sb.Append("  OorspronkelijkBouwjaar: ").Append(OorspronkelijkBouwjaar).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
            sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
            sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
            sb.Append("  AdresseerbaarObjectIdentificaties: ").Append(AdresseerbaarObjectIdentificaties).Append("\n");
            sb.Append("  NummeraanduidingIdentificaties: ").Append(NummeraanduidingIdentificaties).Append("\n");
            sb.Append("  MogelijkOnjuist: ").Append(MogelijkOnjuist).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PandHalBasis);
        }

        /// <summary>
        /// Returns true if PandHalBasis instances are equal
        /// </summary>
        /// <param name="input">Instance of PandHalBasis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PandHalBasis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.Domein == input.Domein ||
                    (this.Domein != null &&
                    this.Domein.Equals(input.Domein))
                ) && 
                (
                    this.Geometrie == input.Geometrie ||
                    (this.Geometrie != null &&
                    this.Geometrie.Equals(input.Geometrie))
                ) && 
                (
                    this.OorspronkelijkBouwjaar == input.OorspronkelijkBouwjaar ||
                    (this.OorspronkelijkBouwjaar != null &&
                    this.OorspronkelijkBouwjaar.Equals(input.OorspronkelijkBouwjaar))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Geconstateerd == input.Geconstateerd ||
                    (this.Geconstateerd != null &&
                    this.Geconstateerd.Equals(input.Geconstateerd))
                ) && 
                (
                    this.Documentdatum == input.Documentdatum ||
                    (this.Documentdatum != null &&
                    this.Documentdatum.Equals(input.Documentdatum))
                ) && 
                (
                    this.Documentnummer == input.Documentnummer ||
                    (this.Documentnummer != null &&
                    this.Documentnummer.Equals(input.Documentnummer))
                ) && 
                (
                    this.AdresseerbaarObjectIdentificaties == input.AdresseerbaarObjectIdentificaties ||
                    this.AdresseerbaarObjectIdentificaties != null &&
                    input.AdresseerbaarObjectIdentificaties != null &&
                    this.AdresseerbaarObjectIdentificaties.SequenceEqual(input.AdresseerbaarObjectIdentificaties)
                ) && 
                (
                    this.NummeraanduidingIdentificaties == input.NummeraanduidingIdentificaties ||
                    this.NummeraanduidingIdentificaties != null &&
                    input.NummeraanduidingIdentificaties != null &&
                    this.NummeraanduidingIdentificaties.SequenceEqual(input.NummeraanduidingIdentificaties)
                ) && 
                (
                    this.MogelijkOnjuist == input.MogelijkOnjuist ||
                    (this.MogelijkOnjuist != null &&
                    this.MogelijkOnjuist.Equals(input.MogelijkOnjuist))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Domein != null)
                    hashCode = hashCode * 59 + this.Domein.GetHashCode();
                if (this.Geometrie != null)
                    hashCode = hashCode * 59 + this.Geometrie.GetHashCode();
                if (this.OorspronkelijkBouwjaar != null)
                    hashCode = hashCode * 59 + this.OorspronkelijkBouwjaar.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Geconstateerd != null)
                    hashCode = hashCode * 59 + this.Geconstateerd.GetHashCode();
                if (this.Documentdatum != null)
                    hashCode = hashCode * 59 + this.Documentdatum.GetHashCode();
                if (this.Documentnummer != null)
                    hashCode = hashCode * 59 + this.Documentnummer.GetHashCode();
                if (this.AdresseerbaarObjectIdentificaties != null)
                    hashCode = hashCode * 59 + this.AdresseerbaarObjectIdentificaties.GetHashCode();
                if (this.NummeraanduidingIdentificaties != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificaties.GetHashCode();
                if (this.MogelijkOnjuist != null)
                    hashCode = hashCode * 59 + this.MogelijkOnjuist.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
