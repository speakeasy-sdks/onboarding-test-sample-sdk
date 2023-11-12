
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar
{
    using Speakeasy.Bar.Models.Components;
    using Speakeasy.Bar.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// The Speakeasy Bar: A bar that serves drinks.
    /// 
    /// <remarks>
    /// A secret underground bar that serves drinks to those in the know.
    /// </remarks>
    /// 
    /// <see>https://docs.speakeasy.bar} - The Speakeasy Bar Documentation.</see>
    /// </summary>
    public interface ISpeakeasy
    {

        /// <summary>
        /// The authentication endpoints.
        /// </summary>
        public IAuthentication Authentication { get; }

        /// <summary>
        /// The drinks endpoints.
        /// </summary>
        public IDrinks Drinks { get; }

        /// <summary>
        /// The ingredients endpoints.
        /// </summary>
        public IIngredients Ingredients { get; }

        /// <summary>
        /// The orders endpoints.
        /// </summary>
        public IOrders Orders { get; }
        public IConfig Config { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// The Speakeasy Bar: A bar that serves drinks.
    /// 
    /// <remarks>
    /// A secret underground bar that serves drinks to those in the know.
    /// </remarks>
    /// 
    /// <see>https://docs.speakeasy.bar} - The Speakeasy Bar Documentation.</see>
    /// </summary>
    public class Speakeasy: ISpeakeasy
    {
        public SDKConfig Config { get; private set; }
        public static Dictionary<string, string> ServerList = new Dictionary<string, string>()
        {
            {"Serverprod", "https://speakeasy.bar" },
            {"Serverstaging", "https://staging.speakeasy.bar" },
            {"Servercustomer", "https://{organization}.{environment}.speakeasy.bar" },
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.188.1";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.188.1 1.0.0 Speakeasy.Bar";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAuthentication Authentication { get; private set; }
        public IDrinks Drinks { get; private set; }
        public IIngredients Ingredients { get; private set; }
        public IOrders Orders { get; private set; }
        public IConfig Config { get; private set; }

        public Speakeasy(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? Speakeasy.ServerList["Serverprod"];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            Authentication = new Authentication(_defaultClient, _securityClient, _serverUrl, Config);
            Drinks = new Drinks(_defaultClient, _securityClient, _serverUrl, Config);
            Ingredients = new Ingredients(_defaultClient, _securityClient, _serverUrl, Config);
            Orders = new Orders(_defaultClient, _securityClient, _serverUrl, Config);
            Config = new Config(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}