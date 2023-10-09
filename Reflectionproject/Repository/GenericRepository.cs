using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Reflectionproject.Context;

namespace Reflectionproject.Repository;

public class GenericRepository<TEntity> where TEntity :class
{
     private readonly ApplicationContext _context;
     private DbSet<TEntity> _table;

     public GenericRepository(ApplicationContext context)
     {
          _context = context;
          _table = context.Set<TEntity>();
     }

     public virtual void create(TEntity entity)
     {
         _table.Add(entity);
     }

     public virtual void Update(TEntity entity)
     {
         _table.Attach(entity);
         _context.Entry(entity).State = EntityState.Modified;
     }

     public virtual TEntity getbyid(object Id)
     {
         return _table.Find(Id);
     }

     public virtual IEnumerable<TEntity> Getall(Expression<Func<TEntity,bool>> ?wherevarible=null , string join="")
     {
         var query = _table.AsQueryable();
         if (wherevarible!=null)
         {
             query = query.Where(wherevarible);
         }

         if (join!="")
         {
             foreach (string j in join.Split(","))
             {
                 query = query.Include(j);
             }
         }

         return query;

     }
}