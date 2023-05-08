using BAL.Abstract;
using DAL.Abstract;
using DAL.Context;
using DAL.EntityFramework;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class BlogManager : IBlogService
{
    private IBlogRepo _blogRepo;

    public BlogManager(IBlogRepo blogRepo)
    {
        _blogRepo = blogRepo;
    }

    public List<Blog> Test(int id)
    {
        return _blogRepo.GetListWithCategoryByWriter(id);
    }

    public void TAdd(Blog t)
    {
        _blogRepo.Insert(t);
    }

    public void TDelete(Blog t)
    {
        _blogRepo.Delete(t);
    }

    public void TUpdate(Blog t)
    {
        var value = _blogRepo.GetById(t.BlogID);
        value.Content = t.Content;
        value.Title = t.Title;
        var orginal = value.BlogID;
        var orginal1 = value.Date;
        var orginal2 = value.WriterId;
        value.ThumbnailImage = t.ThumbnailImage;
        value.Category = t.Category;
        value.Image = t.Image;
        value.Status = true;
        
        _blogRepo.Update(value);
    }

    public List<Blog> GetList()
    {
        return _blogRepo.GetListAll();
    }

    public Blog GetById(int id)
    {
        return _blogRepo.GetById(id);
    }

    public List<Blog> GetBlogById(int id)
    {
        return _blogRepo.List(x => x.BlogID == id);
    }

    public List<Blog> GetBlogWithCategory()
    {
        return _blogRepo.GetListWithCategory();
    }

    public List<Blog> GetBlogListWriter(int id)
    {
        return _blogRepo.List(x=>x.WriterId ==id);
    }

    public List<Blog> GetLast3Blog()
    {
        return _blogRepo.GetListAll().Take(3).ToList();
    }
}