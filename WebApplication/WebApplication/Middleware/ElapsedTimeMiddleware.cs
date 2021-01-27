using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace WebApplication1.Middleware
{
    public class ElapsedTimeMiddleware
    {
        private RequestDelegate _next;

        public ElapsedTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var sw = new Stopwatch();
            sw.Start();
            await _next(context);
            Console.WriteLine($"{context.Request.Path} Executed in {sw.ElapsedMilliseconds} ms");
        }
    }
}