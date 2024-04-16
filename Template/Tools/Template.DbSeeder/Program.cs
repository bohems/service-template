using Shared.BaseDbSeeder;

namespace Template.DbSeeder
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            await SeedRunner.Seed<Startup, EmptyDbSeeder>(args);
        }
    }
}