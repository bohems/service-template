using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Shared.Dal;

namespace Template.Dal.Public
{
    public sealed class PublicTemplateReadDbContext : BaseDbContext<PublicTemplateReadDbContext>
    {
        protected override bool IsReadOnly => true;

#pragma warning disable CA2255
        [ModuleInitializer]
#pragma warning restore CA2255
        public static void RegisterEnums()
        {
            // RegisterEnum<Status>();
        }

        public PublicTemplateReadDbContext(DbContextOptions<PublicTemplateReadDbContext> options)
            : base(options)
        {
        }

        public static void CreateModels(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null) throw new ArgumentNullException(nameof(modelBuilder));

            // register models here
        }

        protected override Type[] GetIgnoreConcurrencyTokenTypes()
        {
            // игнорируем все ридонли типы
            return Array.Empty<Type>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CreateModels(modelBuilder);
        }
    }
}