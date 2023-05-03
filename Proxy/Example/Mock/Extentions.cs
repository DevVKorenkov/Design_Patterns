namespace Proxy.Example.Mock;

public static class Extentions
{
    public static T FirstOrDefault<T>(this DbSet<T> dbSet, Func<T, bool> func)
    {
        return (T)new object();
    }
}