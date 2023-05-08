using System.Linq.Expressions;
using DAL.Abstract;

namespace DAL.Repositories;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    
    

    public void Insert(T t)
    {
        using var _context = new Context.Context();
        _context.Add(t);
        _context.SaveChanges();
    }

    public void Delete(T t)
    {
        using var _context = new Context.Context();
        _context.Remove(t);
        _context.SaveChanges();
    }

    public void Update(T t)
    {
        using var _context = new Context.Context();
        _context.Update(t);
        _context.SaveChanges();
    }

    public List<T> GetListAll()
    {
        using var _context = new Context.Context();
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        using var context = new Context.Context();
        return context.Set<T>().Find(id)!;
    }

    public List<T> List(Expression<Func<T, bool>> filter)
    {
        using var c = new Context.Context();
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}