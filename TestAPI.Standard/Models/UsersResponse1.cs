// <copyright file="UsersResponse1.cs" company="APIMatic">
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
    /// UsersResponse1.
    /// </summary>
    public class UsersResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersResponse1"/> class.
        /// </summary>
        public UsersResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersResponse1"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="message">message.</param>
        public UsersResponse1(
            int? id = null,
            string message = null)
        {
            this.Id = id;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsersResponse1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsersResponse1 other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
        }
    }
}