using Shared.BaseDbSeeder.Seeder;
using Template.Dal;

namespace Template.DbSeeder
{
    internal class EmptyDbSeeder : BaseEfSeeder<TemplateDbContext>, IDbSeeder
    {
        public EmptyDbSeeder(TemplateDbContext dbContext) : base(dbContext)
        {
        }

        protected override Task EnsureSeedData()
        {
            throw new NotImplementedException();
        }
    }
}