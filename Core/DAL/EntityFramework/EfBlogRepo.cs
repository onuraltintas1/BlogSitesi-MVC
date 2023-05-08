using DAL.Abstract;
using DAL.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.EntityFramework;

public class EfBlogRepo : GenericRepo<Blog> , IBlogRepo
{
    
    public List<Blog> GetListWithCategory()
    {
        using (var context=new Context.Context())
        {
            return context.Blogs.Include(x => x.Category).ToList();
        }

        
    }

    public List<Blog> GetListWithCategoryByWriter(int id)
    {
        using (var context=new Context.Context())
        {
            return context.Blogs.Include(x => x.Category).Where(x=>x.WriterId==id).ToList();
        }
    }
}