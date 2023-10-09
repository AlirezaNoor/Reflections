using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Reflectionproject.Services.Extenssion;

public static class DbEx
{
    public static void verify<Tbase>(this ModelBuilder modelBuilder, params Assembly[] assemblies)
    {
        IEnumerable<Type> types = assemblies.SelectMany(a => a.GetExportedTypes()).Where(
            c => c.IsClass && !c.IsAbstract && c.IsPublic && typeof(Tbase).IsAssignableFrom(c)
        );
        foreach (var item in types)
        {
            modelBuilder.Entity(item);
        }
    }
}