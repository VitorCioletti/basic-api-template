namespace Domain.DependencyInjection
{
    using System;

    [Serializable]
    public class ResolverNotConfiguredException : Exception
    {
        public ResolverNotConfiguredException() : base(
            string.Format("There is no instance of \"{0}\" on domain.", typeof(IResolver).Name)){}
    }
}
