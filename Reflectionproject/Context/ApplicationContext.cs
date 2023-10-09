using Microsoft.EntityFrameworkCore;
using Reflectionproject.Entity;
using Reflectionproject.Interface;
using Reflectionproject.Services.Extenssion;


namespace Reflectionproject.Context;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var projectassembly = typeof(IFlag).Assembly;
        modelBuilder.verify<IFlag>(projectassembly);
        base.OnModelCreating(modelBuilder);
    }
}