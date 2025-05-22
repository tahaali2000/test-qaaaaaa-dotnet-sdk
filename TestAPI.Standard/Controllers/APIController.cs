// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using TestAPI.Standard;
using TestAPI.Standard.Http.Client;
using TestAPI.Standard.Utilities;

namespace TestAPI.Standard.Controllers
{
    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        internal APIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of users, optionally filtered by search.
        /// </summary>
        /// <param name="search">Optional parameter: Filter users by search term.</param>
        /// <param name="limit">Optional parameter: Limit the number of users returned.</param>
        /// <returns>Returns the List of Models.UsersResponse response from the API call.</returns>
        public List<Models.UsersResponse> Getusers(
                string search = null,
                int? limit = null)
            => CoreHelper.RunTask(GetusersAsync(search, limit));

        /// <summary>
        /// Returns a list of users, optionally filtered by search.
        /// </summary>
        /// <param name="search">Optional parameter: Filter users by search term.</param>
        /// <param name="limit">Optional parameter: Limit the number of users returned.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.UsersResponse response from the API call.</returns>
        public async Task<List<Models.UsersResponse>> GetusersAsync(
                string search = null,
                int? limit = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UsersResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/users")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("search", search))
                      .Query(_query => _query.Setup("limit", limit))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a user with default values if not provided.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the Models.UsersResponse1 response from the API call.</returns>
        public Models.UsersResponse1 Createanewuser(
                Models.UsersRequest body)
            => CoreHelper.RunTask(CreateanewuserAsync(body));

        /// <summary>
        /// Creates a user with default values if not provided.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsersResponse1 response from the API call.</returns>
        public async Task<Models.UsersResponse1> CreateanewuserAsync(
                Models.UsersRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/users")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}