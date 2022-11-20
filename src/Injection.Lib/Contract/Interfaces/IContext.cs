namespace Injection.Lib.Contract.Interfaces
{
    public interface IContext
    {
         IDbSet<T>? GetSet<T>() where T : class, IEntity;
    }
}