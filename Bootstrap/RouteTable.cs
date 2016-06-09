
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Avam.ArticleStore.Web
{
    public class RouteTable
    {
        private IApplicationBuilder _appBuilder;
        public RouteTable(IApplicationBuilder appBuilder)
        {
            _appBuilder=appBuilder;
        }

        public void Build(IRouteBuilder routeCollection)
        {
            _appBuilder.UseStaticFiles();
            _appBuilder.Map("/error", errorApp =>
            {
                errorApp.Run(async ctx => await ctx.Response.WriteAsync("Sorry!! Error occuered"));
            });
            _appBuilder.Map("/mvc",mvc=>{
                mvc.UseMvcWithDefaultRoute();
            });
            _appBuilder.Map("/api",mvc=>{
                mvc.UseMvcWithDefaultRoute();
            });
            _appBuilder.Run(c=>c.Response.WriteAsync("Hello from the end of the pipeline"));
        }
    }
}