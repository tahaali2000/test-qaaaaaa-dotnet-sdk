// <copyright file="UsersRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TestAPI.Standard;
using TestAPI.Standard.Utilities;

namespace TestAPI.Standard.Models
{
    /// <summary>
    /// UsersRequest.
    /// </summary>
    public class UsersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRequest"/> class.
        /// </summary>
        public UsersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRequest"/> class.
        /// </summary>
        /// <param name="age">age.</param>
        /// <param name="signupDate">signupDate.</param>
        /// <param name="username">username.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="rating">rating.</param>
        public UsersRequest(
            int age,
            DateTime signupDate,
            string username = null,
            bool? isActive = null,
            double? rating = null)
        {
            this.Username = username;
            this.Age = age;
            this.IsActive = isActive;
            this.Rating = rating;
            this.SignupDate = signupDate;
        }

        /// <summary>
        /// User's username
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// User's age
        /// </summary>
        [JsonProperty("age")]
        public int Age { get; set; }

        /// <summary>
        /// Whether the user is active
        /// </summary>
        [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// User's rating
        /// </summary>
        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rating { get; set; }

        /// <summary>
        /// Signup date
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("signupDate")]
        public DateTime SignupDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsersRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsersRequest other &&
                (this.Username == null && other.Username == null ||
                 this.Username?.Equals(other.Username) == true) &&
                (this.Age.Equals(other.Age)) &&
                (this.IsActive == null && other.IsActive == null ||
                 this.IsActive?.Equals(other.IsActive) == true) &&
                (this.Rating == null && other.Rating == null ||
                 this.Rating?.Equals(other.Rating) == true) &&
                (this.SignupDate.Equals(other.SignupDate));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Username = {this.Username ?? "null"}");
            toStringOutput.Add($"Age = {this.Age}");
            toStringOutput.Add($"IsActive = {(this.IsActive == null ? "null" : this.IsActive.ToString())}");
            toStringOutput.Add($"Rating = {(this.Rating == null ? "null" : this.Rating.ToString())}");
            toStringOutput.Add($"SignupDate = {this.SignupDate}");
        }
    }
}