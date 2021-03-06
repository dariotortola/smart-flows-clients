/* 
 * Xpertdoc SmartFlows
 *
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Client.Model
{
    /// <summary>
    /// Defines conditionValueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionValueType
    {
        
        /// <summary>
        /// Enum Nothing for "nothing"
        /// </summary>
        [EnumMember(Value = "nothing")]
        Nothing,
        
        /// <summary>
        /// Enum DocProp for "docProp"
        /// </summary>
        [EnumMember(Value = "docProp")]
        DocProp,
        
        /// <summary>
        /// Enum Constant for "constant"
        /// </summary>
        [EnumMember(Value = "constant")]
        Constant,
        
        /// <summary>
        /// Enum Field for "field"
        /// </summary>
        [EnumMember(Value = "field")]
        Field,
        
        /// <summary>
        /// Enum Expression for "expression"
        /// </summary>
        [EnumMember(Value = "expression")]
        Expression,
        
        /// <summary>
        /// Enum FlowVariable for "flowVariable"
        /// </summary>
        [EnumMember(Value = "flowVariable")]
        FlowVariable
    }

}
