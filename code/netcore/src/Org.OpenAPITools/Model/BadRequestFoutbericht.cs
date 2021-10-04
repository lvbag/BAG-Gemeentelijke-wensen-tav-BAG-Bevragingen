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
    /// BadRequestFoutbericht
    /// </summary>
    [DataContract(Name = "BadRequestFoutbericht")]
    public partial class BadRequestFoutbericht : IEquatable<BadRequestFoutbericht>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestFoutbericht" /> class.
        /// </summary>
        /// <param name="type">Link naar meer informatie over deze fout.</param>
        /// <param name="title">Beschrijving van de fout.</param>
        /// <param name="status">Http status code.</param>
        /// <param name="detail">Details over de fout.</param>
        /// <param name="instance">Uri van de aanroep die de fout heeft veroorzaakt.</param>
        /// <param name="code">Systeemcode die het type fout aangeeft.</param>
        /// <param name="invalidParams">Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld..</param>
        public BadRequestFoutbericht(string type = default(string), string title = default(string), int status = default(int), string detail = default(string), string instance = default(string), string code = default(string), List<InvalidParams> invalidParams = default(List<InvalidParams>))
        {
            this.Type = type;
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.Instance = instance;
            this.Code = code;
            this.InvalidParams = invalidParams;
        }

        /// <summary>
        /// Link naar meer informatie over deze fout
        /// </summary>
        /// <value>Link naar meer informatie over deze fout</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Beschrijving van de fout
        /// </summary>
        /// <value>Beschrijving van de fout</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Http status code
        /// </summary>
        /// <value>Http status code</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Details over de fout
        /// </summary>
        /// <value>Details over de fout</value>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// Uri van de aanroep die de fout heeft veroorzaakt
        /// </summary>
        /// <value>Uri van de aanroep die de fout heeft veroorzaakt</value>
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Systeemcode die het type fout aangeeft
        /// </summary>
        /// <value>Systeemcode die het type fout aangeeft</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld.
        /// </summary>
        /// <value>Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld.</value>
        [DataMember(Name = "invalidParams", EmitDefaultValue = false)]
        public List<InvalidParams> InvalidParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BadRequestFoutbericht {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InvalidParams: ").Append(InvalidParams).Append("\n");
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
            return this.Equals(input as BadRequestFoutbericht);
        }

        /// <summary>
        /// Returns true if BadRequestFoutbericht instances are equal
        /// </summary>
        /// <param name="input">Instance of BadRequestFoutbericht to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadRequestFoutbericht input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.InvalidParams == input.InvalidParams ||
                    this.InvalidParams != null &&
                    input.InvalidParams != null &&
                    this.InvalidParams.SequenceEqual(input.InvalidParams)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.InvalidParams != null)
                    hashCode = hashCode * 59 + this.InvalidParams.GetHashCode();
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
            // Code (string) minLength
            if(this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            yield break;
        }
    }

}