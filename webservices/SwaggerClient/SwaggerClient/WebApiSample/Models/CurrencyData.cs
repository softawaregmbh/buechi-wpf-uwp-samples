﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace SwaggerClient.Models
{
    public partial class CurrencyData
    {
        private string _country;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }
        
        private double? _euroRate;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? EuroRate
        {
            get { return this._euroRate; }
            set { this._euroRate = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _symbol;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Symbol
        {
            get { return this._symbol; }
            set { this._symbol = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CurrencyData class.
        /// </summary>
        public CurrencyData()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken countryValue = inputObject["Country"];
                if (countryValue != null && countryValue.Type != JTokenType.Null)
                {
                    this.Country = ((string)countryValue);
                }
                JToken euroRateValue = inputObject["EuroRate"];
                if (euroRateValue != null && euroRateValue.Type != JTokenType.Null)
                {
                    this.EuroRate = ((double)euroRateValue);
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken symbolValue = inputObject["Symbol"];
                if (symbolValue != null && symbolValue.Type != JTokenType.Null)
                {
                    this.Symbol = ((string)symbolValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type CurrencyData
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Country != null)
            {
                outputObject["Country"] = this.Country;
            }
            if (this.EuroRate != null)
            {
                outputObject["EuroRate"] = this.EuroRate.Value;
            }
            if (this.Name != null)
            {
                outputObject["Name"] = this.Name;
            }
            if (this.Symbol != null)
            {
                outputObject["Symbol"] = this.Symbol;
            }
            return outputObject;
        }
    }
}
