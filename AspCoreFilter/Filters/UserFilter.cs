using AspCoreFilter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using AspCoreFilter.Extensions;
using Microsoft.AspNetCore.Routing;

namespace AspCoreFilter.Filters
{
    public class UserFilter : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var user = context.HttpContext.Session.Get<User>("login-user");
            if (user == null)
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller", "Account" }, { "action", "Index" } });
            }
        }
    }
}
