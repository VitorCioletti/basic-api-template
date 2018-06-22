namespace Domain.DependencyInjection
{
    using Interfaces;

    public static class Dependencies
    {
        private static IResolver _resolver;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "É necessário por ser o resolvedor")]
        public static IResolver Resolvedor
        {
            get
            {
                if (_resolver == null)
                    throw new ResolverNotConfiguredException();

                return _resolver;
            }

            set
            {
                _resolver = value;
            }
        }

        public static ISolicitationDAO SolicitationDAO
        {
            get { return Resolvedor.Resolve<ISolicitationDAO>(); }
        }
    }
}
