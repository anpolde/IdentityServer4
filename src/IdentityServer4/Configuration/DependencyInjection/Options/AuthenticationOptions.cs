﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace IdentityServer4.Configuration
{
    /// <summary>
    /// Configures the login and logout views and behavior.
    /// </summary>
    public class AuthenticationOptions
    {
        // TODO: new
        // TODO: does this class still make sense? maybe consolidate UI settings somewhere else?
        public string AuthenticationScheme { get; set; }

        internal string EffectiveAuthenticationScheme
        {
            get
            {
                return AuthenticationScheme ?? IdentityServerConstants.DefaultCookieAuthenticationScheme;
            }
        }

        /// <summary>
        /// Indicates if user must be authenticated to accept parameters to end session endpoint. Defaults to false.
        /// </summary>
        /// <value>
        /// <c>true</c> if required; otherwise, <c>false</c>.
        /// </value>
        public bool RequireAuthenticatedUserForSignOutMessage { get; set; } = false;

        /// <summary>
        /// Gets or sets the federated sign out paths.
        /// </summary>
        /// <value>
        /// The federated sign out paths.
        /// </value>
        public ICollection<PathString> FederatedSignOutPaths { get; set; } = new List<PathString>();
    }
}