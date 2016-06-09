using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Avam.ArticleStore.Web
{
    public class Bootstrapper
    {
        #region Public Methods
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder appBuilder, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            appBuilder.UseStatusCodePagesWithReExecute("/error");
            appBuilder.UseMvc(new RouteTable(appBuilder).Build);
        }
        #endregion
    }
}