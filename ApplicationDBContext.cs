using Entitiyframework;
using Microsoft.EntityFrameworkCore;
using System;

public class ApplicationDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {

        options.UseSqlServer("Data Source=(local);Initial Catalog=EFCore2; Integrated Security=true; TrustServerCertificate=True");
    }
    public DbSet<Employee> Employees { get; set; }
}
