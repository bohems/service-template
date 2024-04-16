using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shared.Api;
using Shared.Dal.Extensions;
using Template.Dal;

namespace Template
{
    public class Startup : BaseStartup
    {
        public override string ApplicationName => "<Rename please> service";

        public Startup(IWebHostEnvironment environment, IConfiguration configuration) : base(environment, configuration)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            // grpc
            services.AddGrpc();

            // EF
            services.RegisterDal<TemplateDbContext, ReadOnlyTemplateDbContext>(
                Configuration.GetConnectionString("DefaultConnection"),
                Configuration.GetConnectionString("ReadOnlyDefaultConnection"));

            // services
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UsePathBase(new PathString("/template")); // for proxy, remove prefix from request (/template/get == /get)

            if (env.IsDevelopment())
            {
            }

            base.Configure(app, env);
        }
    }
}