namespace Presentation.Global
{
    public partial class APITemplate
    {
        protected void Application_Start()
       {
            ConfigureDependencyInjection();
            ApplyExceptionFilters();
            ConfigureMarkdownRenderer();
            FormatJson();
            RegisterRoutes();
        }
    }
}