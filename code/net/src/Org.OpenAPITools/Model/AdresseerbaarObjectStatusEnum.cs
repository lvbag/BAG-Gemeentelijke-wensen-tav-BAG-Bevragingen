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
    /// Defines AdresseerbaarObjectStatus_enum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AdresseerbaarObjectStatusEnum
    {
        /// <summary>
        /// Enum Plaatsaangewezen for value: Plaats aangewezen
        /// </summary>
        [EnumMember(Value = "Plaats aangewezen")]
        Plaatsaangewezen = 1,

        /// <summary>
        /// Enum Verblijfsobjectgevormd for value: Verblijfsobject gevormd
        /// </summary>
        [EnumMember(Value = "Verblijfsobject gevormd")]
        Verblijfsobjectgevormd = 2,

        /// <summary>
        /// Enum Verblijfsobjectingebruiknietingemeten for value: Verblijfsobject in gebruik (niet ingemeten)
        /// </summary>
        [EnumMember(Value = "Verblijfsobject in gebruik (niet ingemeten)")]
        Verblijfsobjectingebruiknietingemeten = 3,

        /// <summary>
        /// Enum Verblijfsobjectingebruik for value: Verblijfsobject in gebruik
        /// </summary>
        [EnumMember(Value = "Verblijfsobject in gebruik")]
        Verblijfsobjectingebruik = 4,

        /// <summary>
        /// Enum Verbouwingverblijfsobject for value: Verbouwing verblijfsobject
        /// </summary>
        [EnumMember(Value = "Verbouwing verblijfsobject")]
        Verbouwingverblijfsobject = 5,

        /// <summary>
        /// Enum Verblijfsobjectbuitengebruik for value: Verblijfsobject buiten gebruik
        /// </summary>
        [EnumMember(Value = "Verblijfsobject buiten gebruik")]
        Verblijfsobjectbuitengebruik = 6

    }

}
