using BAL.Abstract;
using DAL.Abstract;
using DAL.EntityFramework;
using DAL.Repositories;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class CategoryManager : ICategoryService
{
    readonly ICategoryRepo _categoryRepo;
 
    public CategoryManager(ICategoryRepo categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }
    
    public void TAdd(Category t)
    {
        _categoryRepo.Insert(t);
    }

    public void TDelete(Category t)
    {
        _categoryRepo.Delete(t);
    }

    public void TUpdate(Category t)
    {
        _categoryRepo.Update(t);
    }

    public List<Category> GetList()
    {
        return _categoryRepo.GetListAll();
    }

    public Category? GetById(int id)
    {
        return _categoryRepo.GetById(id);
    }
}