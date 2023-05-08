using EntityLayer.Concrete;

namespace BAL.Abstract;

public interface IBlogService : IGenericService<Blog>
{
    List<Blog> GetBlogWithCategory();
    List<Blog> GetBlogListWriter(int id);

}