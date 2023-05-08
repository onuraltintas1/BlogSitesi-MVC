using EntityLayer.Concrete;

namespace DAL.Abstract;

public interface IBlogRepo:IGenericRepo<Blog>
{
    List<Blog> GetListWithCategory();
    List<Blog> GetListWithCategoryByWriter(int id);
}