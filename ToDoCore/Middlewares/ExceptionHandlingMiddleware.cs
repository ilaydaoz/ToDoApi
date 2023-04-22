using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Npgsql;
using System.Net;

namespace ToDoCore.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var now = DateTime.UtcNow;
            var obj = new
            {
                Date = now,
                HttpStatusCode = httpContext.Response.StatusCode,
                Message = ex.InnerException is null ?  ex.Message : JsonConvert.SerializeObject(ex.InnerException),
                TraceIdentifier = httpContext.TraceIdentifier,
                Heart = "<3"
            };
            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(obj));
        }
    }
}
