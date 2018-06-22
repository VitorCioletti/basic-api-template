namespace Presentation.Global
{
    using MarkdownMvcLibrary;
    using System.Web.Mvc;

    public partial class APITemplate
    {
        private void ConfigureMarkdownRenderer() =>
            ViewEngines.Engines.Add(new MarkdownViewEngine());
    }
}