/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace Square.Connect.Model
{
    /// <summary>
    /// Indicates whether customers should be included in, or excluded from, the result set when they match the filtering criteria.
    /// </summary>
    /// <value>Indicates whether customers should be included in, or excluded from, the result set when they match the filtering criteria.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerInclusionExclusion
    {
        
        /// <summary>
        /// Enum INCLUDE for "INCLUDE"
        /// </summary>
        [EnumMember(Value = "INCLUDE")]
        INCLUDE,
        
        /// <summary>
        /// Enum EXCLUDE for "EXCLUDE"
        /// </summary>
        [EnumMember(Value = "EXCLUDE")]
        EXCLUDE
    }

}
