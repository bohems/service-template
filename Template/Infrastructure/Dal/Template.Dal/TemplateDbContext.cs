using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Shared.Dal;

namespace Template.Dal
{
    internal class TemplateDbContext : BaseDbContext<TemplateDbContext>
    {
#pragma warning disable CA2255
        [ModuleInitializer]
#pragma warning restore CA2255
        public static void RegisterEnums()
        {
            // регистрация енама
            //RegisterEnum<UserStatus>();
        }

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}