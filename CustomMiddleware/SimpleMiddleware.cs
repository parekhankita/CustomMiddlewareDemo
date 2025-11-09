
namespace CustomMiddleware
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("➡️ Before Request");

            await _next(context); // call the next middleware

            Console.WriteLine("⬅️ After Request");
        }
    }
}
