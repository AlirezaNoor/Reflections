using Reflectionproject.Entity;
using Reflectionproject.Repository;

namespace Reflectionproject.Interface;

public interface IUnitofwork
{
    GenericRepository<Products> _ProductsUW { get; }
    GenericRepository<Category> categoryuw { get; }
}