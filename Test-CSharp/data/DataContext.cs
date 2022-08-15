using Microsoft.EntityFrameworkCore;
using Test_CSharp.Entities;

namespace Test_CSharp.data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
}