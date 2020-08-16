using System;
using System.Security.Claims;
using System.Threading.Tasks;
using JWTAuthApi;
using Microsoft.AspNetCore.Authorization;

public class FirstNameHandler : AuthorizationHandler<FirstNameRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                   FirstNameRequirement requirement)
    {
        if (!context.User.HasClaim(c => c.Type == "FirstName" ))
        {
            //TODO: Use the following if targeting a version of
            //.NET Framework older than 4.6:
            //      return Task.FromResult(0);
            return Task.CompletedTask;
        }

        var firstname = context.User.FindFirst(c => c.Type == "FirstName" ).Value;

        

        if (firstname == requirement.FirstName)
        {
            context.Succeed(requirement);
        }

        //TODO: Use the following if targeting a version of
        //.NET Framework older than 4.6:
        //      return Task.FromResult(0);
        return Task.CompletedTask;
    }
}