
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar.Models.Webhooks
{
    using Newtonsoft.Json;
    using Speakeasy.Bar.Models.Components;
    
    public class StockUpdateRequestBody
    {

        [JsonProperty("drink")]
        public DrinkInput? Drink { get; set; }

        [JsonProperty("ingredient")]
        public IngredientInput? Ingredient { get; set; }
    }
}