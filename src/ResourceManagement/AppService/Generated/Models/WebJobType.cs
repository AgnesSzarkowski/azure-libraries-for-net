// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebJobType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebJobType
    {
        [EnumMember(Value = "Continuous")]
        Continuous,
        [EnumMember(Value = "Triggered")]
        Triggered
    }
    internal static class WebJobTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebJobType? value)
        {
            return value == null ? null : ((WebJobType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebJobType value)
        {
            switch( value )
            {
                case WebJobType.Continuous:
                    return "Continuous";
                case WebJobType.Triggered:
                    return "Triggered";
            }
            return null;
        }

        internal static WebJobType? ParseWebJobType(this string value)
        {
            switch( value )
            {
                case "Continuous":
                    return WebJobType.Continuous;
                case "Triggered":
                    return WebJobType.Triggered;
            }
            return null;
        }
    }
}
