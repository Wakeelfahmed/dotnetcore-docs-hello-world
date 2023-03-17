using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class DummyResponseMiddleware
{
    private readonly RequestDelegate _next;

    public DummyResponseMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Set the content type of the response
        context.Response.ContentType = "text/plain";
    
        // Set the status code of the response
        context.Response.StatusCode = 200;
    
        // Write the response body
        await context.Response.WriteAsync("Hello, world!");
        
        // Call the next middleware in the pipeline
        await _next(context);
    }
}
