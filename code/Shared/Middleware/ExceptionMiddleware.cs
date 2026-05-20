
public class ExceptionMiddleware
{
    public async Task Invoke(HttpContext context, RequestDelegate next)
    {
        try { await next(context); }
        catch(Exception ex)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync(ex.Message);
        }
    }
}
