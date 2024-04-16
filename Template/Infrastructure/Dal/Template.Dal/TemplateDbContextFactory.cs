using Microsoft.EntityFrameworkCore;
using Shared.Dal;

namespace Template.Dal
{
    /// <summary>
    /// Design factory
    /// </summary>
    internal class TemplateDbContextFactory : BasePgDbContextFactory<TemplateDbContext>
    {
        protected override TemplateDbContext CreateInstance(DbContextOptions<TemplateDbContext> options)
        {
            return new TemplateDbContext(options);
        }
    }
}