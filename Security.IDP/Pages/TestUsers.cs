// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Security.IDP;

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {


            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "50069b4b-dd62-43b1-b569-2a30e9b781aa",
                    Username = "David",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg")

                    }
                },
                new TestUser
                {
                    SubjectId = "87702cae-5c5e-47f7-81d0-b5175c2d3a1b",
                    Username = "Emma",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "Emma"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg")
                    }
                }
            };
        }
    }
}