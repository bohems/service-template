using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shared.BaseDbSeeder;

namespace Template.DbSeeder
{
    public class Startup : BaseStartup
    {
        public Startup(HostBuilderContext builderContext) : base(builderContext)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<EmptyDbSeeder>();
        }
    }
}