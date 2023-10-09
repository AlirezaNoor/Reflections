using Reflectionproject.Context;
using Reflectionproject.Entity;
using Reflectionproject.Interface;
using Reflectionproject.Repository;

namespace Reflectionproject.UnitofWorks;

public class Unitofwork:IDisposable,IUnitofwork
{
    private readonly ApplicationContext _context;
    private GenericRepository<Products> _products;
    private GenericRepository<Category> _Category;

    public Unitofwork(ApplicationContext context)
    {
        _context = context;
    }

    public GenericRepository<Products> _ProductsUW
    {
        get
        {
            if (_products==null)
            {
                _products = new GenericRepository<Products>(_context);
            }

            return _products;

        }
    }

    public GenericRepository<Category> categoryuw
    {
        get
        {
            if (_Category==null)
            {
                _Category = new GenericRepository<Category>(_context);
            }

            return _Category;

        }
    }

    public void Dispose()
    {
        // TODO release managed resources here
    }
}