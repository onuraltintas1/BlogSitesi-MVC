using System.Linq.Expressions;
using EntityLayer.Concrete;

namespace DAL.Abstract;

public interface IGenericRepo<T> where T : class
{
    void Insert(T t);
    void Delete(T t);
    void Update(T t);
    List<T> GetListAll();
    T GetById(int id);
    List<T> List(Expression<Func<T,bool>> filter);
}