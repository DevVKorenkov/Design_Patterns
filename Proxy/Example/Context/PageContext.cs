using Proxy.Example.Mock;
using Proxy.Example.Models;

namespace Proxy.Example.Context;

public class PageContext : DbContext
{
    public DbSet<Page> Pages { get; set; }
}