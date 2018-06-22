namespace Presentation.Global
{
    using DependencyInjection;
    using Domain.DependencyInjection;

    public partial class APITemplate
    {
        private void ConfigureDependencyInjection() =>
            Dependencies.Resolvedor = new Resolver();
    }
}