// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace Gameteki.Identity
{
    using IdentityModel;
    using IdentityServer4;

    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiResource> Apis =>
            new[]
            {
                new ApiResource("api1", "My API")
                {
                    UserClaims =  { JwtClaimTypes.Name, JwtClaimTypes.Email }
                }
            };

        public static IEnumerable<Client> Clients =>
            new[]
            {
                new Client
                {
                    ClientId = "keyteki",
                    ClientName = "The Crucible Online",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,

                    RedirectUris = { "https://localhost:5001/callback" },
                    PostLogoutRedirectUris = { "https://localhost:5001" },
                    AllowedCorsOrigins = { "https://localhost:5001" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    }
                }
            };

    }
}