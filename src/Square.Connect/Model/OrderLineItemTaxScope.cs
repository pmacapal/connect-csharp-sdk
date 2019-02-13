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
    /// Indicates whether this is a line item or order level tax.
    /// </summary>
    /// <value>Indicates whether this is a line item or order level tax.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderLineItemTaxScope
    {
        
        /// <summary>
        /// Enum OTHERTAXSCOPE for "OTHER_TAX_SCOPE"
        /// </summary>
        [EnumMember(Value = "OTHER_TAX_SCOPE")]
        OTHERTAXSCOPE,
        
        /// <summary>
        /// Enum LINEITEM for "LINE_ITEM"
        /// </summary>
        [EnumMember(Value = "LINE_ITEM")]
        LINEITEM,
        
        /// <summary>
        /// Enum ORDER for "ORDER"
        /// </summary>
        [EnumMember(Value = "ORDER")]
        ORDER
    }

}
