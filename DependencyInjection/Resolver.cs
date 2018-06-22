namespace DependencyInjection
{
    using Domain.Interfaces;
    using Domain.DependencyInjection;
    using Infrastructure;
    using Unity;

    public class Resolver : IResolver
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public Resolver()
        {
            _container.RegisterType<ISolicitationDAO, SolicitationDAO>();
        }

        public T Resolve<T>() => _container.Resolve<T>();
    }
}
