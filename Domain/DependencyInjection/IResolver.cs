namespace Domain.DependencyInjection
{
    public interface IResolver
    {
        T Resolve<T>();
    }
}
