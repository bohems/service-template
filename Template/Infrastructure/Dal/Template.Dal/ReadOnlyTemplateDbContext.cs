using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Shared.Dal;

namespace Template.Dal
{
    public sealed class ReadOnlyTemplateDbContext : BaseDbContext<ReadOnlyTemplateDbContext>
    {
        protected override bool IsReadOnly => true;

#pragma warning disable CA2255
        [ModuleInitializer]
#pragma warning restore CA2255
        public static void RegisterEnums()
        {
            // RegisterEnum<Status>();
        }

        public ReadOnlyTemplateDbContext(DbContextOptions<ReadOnlyTemplateDbContext> options)
            : base(options)
        {
        }

        protected override Type[] GetIgnoreConcurrencyTokenTypes()
        {
            // игнорируем все ридонли типы
            return new Type[]
            {
                //typeof(UserReadOnlyDb)
            };
        }
    }
}