using Alphastellar.Case.WebApı.Middlewares;

namespace Alphastellar.Case.WebApı.Extensions
{
    public static class CustomExceptionMiddlewareExtension
    {
        public static void CustomExceptionMiddleWare(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
