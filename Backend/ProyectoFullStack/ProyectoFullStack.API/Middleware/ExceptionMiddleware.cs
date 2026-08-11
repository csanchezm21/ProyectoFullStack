using System.Net;
using System.Text.Json;
using ProyectoFullStack.API.DTOs;

namespace ProyectoFullStack.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);            
            }

        }
        
        private static async Task HandleExceptionAsync(
            HttpContext context,
            Exception exception)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType= "application/json";

            var response = new ErrorResponseDto
            {
                StatusCode = context.Response.StatusCode,
                Message = "Ocurrio un error interno en el servidor."
            };

            var jsonResponse = JsonSerializer.Serialize(response);

            await context.Response.WriteAsync(jsonResponse);

        }
   
    }
}
