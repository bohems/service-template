namespace Template
{
    public static class Program
    {
        public static Task<int> Main(string[] args)
        {
            return new TemplateHost().Run(args);
        }
    }
}