using cadastropessoa.Models;
using Microsoft.EntityFrameworkCore;

namespace cadastropessoa.Data;

public class AppDdContext : DbContext
{
    public AppDdContext(DbContextOptions options) : base(options)
    {

    }
    DbSet<Pessoa> Pessoas { get; set; } = null!;
}
