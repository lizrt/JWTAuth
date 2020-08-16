using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace JWTAuthApi
{
    public class FirstNameRequirement : IAuthorizationRequirement
{
    public string FirstName { get; }

    public FirstNameRequirement(string firstName)
    {
        FirstName = firstName;
    }
}
}