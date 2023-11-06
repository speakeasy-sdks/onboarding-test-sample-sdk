
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The status of the order.
    /// </summary>
    public enum OrderStatus
    {
        [JsonProperty("pending")]
        Pending,
        [JsonProperty("processing")]
        Processing,
        [JsonProperty("complete")]
        Complete,
    }

    public static class OrderStatusExtension
    {
        public static string Value(this OrderStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static OrderStatus ToEnum(this string value)
        {
            foreach(var field in typeof(OrderStatus).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is OrderStatus)
                    {
                        return (OrderStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum OrderStatus");
        }
    }
}