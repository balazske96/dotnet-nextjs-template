using System;
using Microsoft.AspNetCore.Builder;
using web_api_with_react.Middlewares;

namespace web_api_with_react.Extensions
{
    public static class NextJsMiddlewareExtensions
    {
        public static IApplicationBuilder UseNextJsProxy(this IApplicationBuilder builder, Action<INextJsOptions> nextJsBuilder)
        {
            DefaultNextJsOptions options = new DefaultNextJsOptions();
            nextJsBuilder(options);
            
            return builder.UseMiddleware<NextJsProxyMiddleware>(options);
        }
    }
}